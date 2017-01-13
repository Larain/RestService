using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MySql.Data.MySqlClient;
using SportStudioModel.Entities;

namespace SportStudioModel
{
    public static class DatabaseManager {
        private static SportStudioDataSet dataSet;
        private static string dbConnection;
        private static bool isConnectionOpen;

        private static string ConnectionString {
            get {
                if (dbConnection != null)
                    return dbConnection;

                MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
                connectionString.Server = "localhost";
                connectionString.UserID = "root";
                connectionString.Password = "";
                connectionString.Database = "sportstudiodb";
                dbConnection = connectionString.ToString();
                return dbConnection;
            }
        }
        static DatabaseManager() {
            dataSet = new SportStudioDataSet();
            IsConnectionOpen = OpenConnection();
            if (!IsConnectionOpen)
                throw new ArgumentException("Cannot connect to DataBase.");
        }

        public static bool IsConnectionOpen
        {
            get { return isConnectionOpen; }
            private set { isConnectionOpen = value; }
        }

        private static bool OpenConnection()
        {
            return true;
        }

        public static User GetUser(int id) {
            using (var connection = new MySqlConnection(ConnectionString)) {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM USER WHERE ID = " + id, connection);
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                User user = new User();
                myReader.Read();

                user.Id = myReader.GetInt16(0);
                user.Email = myReader.GetString(0);
                user.EncryptedPassword = myReader.GetString(0);
                
                return user;
            }
        }

        public static List<User> GetAllUsers()
        {
            if (IsConnectionOpen)
            {
                List<User> userList = new List<User>();
                return userList;
            }
            throw new FieldAccessException("Connection to DataBase in not established.");
        }

        public static Product GetProduct(int id)
        {
            if (IsConnectionOpen)
            {
                Product product = new Product();
                return product;
            }
            throw new FieldAccessException("Connection to DataBase in not established.");
        }

        public static List<Product> GetAllProducts()
        {
            if (IsConnectionOpen)
            {
                List<Product> productsList = new List<Product>();
                return productsList;
            }
            throw new FieldAccessException("Connection to DataBase in not established.");
        }

    }
}