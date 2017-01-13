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
        public static Product GetProduct(int id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                NpgsqlCommand myCommand = new NpgsqlCommand("select * from public.product " +
                                                            "where id = " + id,
                                                            connection);

                NpgsqlDataReader myReader = myCommand.ExecuteReader();

                myReader.Read();

                var product = new Product
                {
                    Id = myReader.GetInt16(0),
                    Price = myReader.GetDouble(1),
                    Name = myReader.GetString(2),
                    CreatedAt = myReader.GetDateTime(3)
                };

                return product;
            }
        }

        public static List<Product> GetAllProducts()
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                NpgsqlCommand myCommand = new NpgsqlCommand("select * from public.product",
                                                            connection);

                NpgsqlDataReader myReader = myCommand.ExecuteReader();

                var prodList = new List<Product>();

                while (myReader.Read())
                {
                    var product = new Product
                    {
                        Id = myReader.GetInt16(0),
                        Price = myReader.GetDouble(1),
                        Name = myReader.GetString(2),
                        CreatedAt = myReader.GetDateTime(3)
                    };

                    prodList.Add(product);
                }

                return prodList;
            }
        }

        public static void CreateNewProduct(User newUser)
        {
            newUser.EncryptedPassword = RandomString(8);
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string insertsql =
                    "insert into public.user(id, name, email, encrypted_password) VALUES(@Id, @Name, @Email, @Password)";

                NpgsqlCommand cmd = new NpgsqlCommand(insertsql, connection);
                cmd.Parameters.Add("@Id", NpgsqlDbType.Integer);
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