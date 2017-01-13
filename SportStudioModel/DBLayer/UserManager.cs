using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using NpgsqlTypes;
using SportStudioModel.Entities;

namespace SportStudioModel.DBLayer
{
    public partial class DatabaseManager
    {
        public static User GetUser(int id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                NpgsqlCommand myCommand = new NpgsqlCommand("select id, name, email, encrypted_password"
                                                          + " from public.user" +
                                                            " where id = " + id,
                                                            connection);

                NpgsqlDataReader myReader = myCommand.ExecuteReader();

                myReader.Read();

                var user = new User
                {
                    Id = myReader.GetInt16(0),
                    Name = myReader.GetString(1),
                    Email = myReader.GetString(2),
                    EncryptedPassword = myReader.GetString(3)
                };

                return user;
            }
        }

        public static List<User> GetAllUsers()
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                NpgsqlCommand myCommand = new NpgsqlCommand("select id, name, email, encrypted_password"
                                                          + " from public.user",
                                                            connection);

                NpgsqlDataReader myReader = myCommand.ExecuteReader();

                var userList = new List<User>();

                while (myReader.Read())
                {
                    var user = new User
                    {
                        Id = myReader.GetInt16(0),
                        Name = myReader.GetString(1),
                        Email = myReader.GetString(2),
                        EncryptedPassword = myReader.GetString(3)
                    };

                    userList.Add(user);
                }

                return userList;
            }
        }

        public static void CreateNewUser(User newUser)
        {
            newUser.EncryptedPassword = RandomString(8);
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string insertsql =
                    "insert into public.user(id, name, email, encrypted_password) VALUES(@Id, @Name, @Email, @Password)";

                NpgsqlCommand cmd = new NpgsqlCommand(insertsql, connection);
                //cmd.Parameters.Add("@Id", NpgsqlDbType.Integer);
                cmd.Parameters.Add("@Name", NpgsqlDbType.Varchar);
                cmd.Parameters.Add("@Email", NpgsqlDbType.Varchar);
                cmd.Parameters.Add("@Password", NpgsqlDbType.Varchar);

                cmd.Parameters["@Id"].Value = newUser.Id;
                cmd.Parameters["@Name"].Value = newUser.Name;
                cmd.Parameters["@Email"].Value = newUser.Email;
                cmd.Parameters["@Password"].Value = newUser.EncryptedPassword;

                cmd.ExecuteNonQuery();
            }
        }
    }
}