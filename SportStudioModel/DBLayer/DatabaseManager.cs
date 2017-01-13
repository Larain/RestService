using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using SportStudioModel.Entities;

namespace SportStudioModel.DBLayer
{
    public static partial class DatabaseManager {
        private static string _dbConnection;
        private static bool _isConnectionOpen;

        private static string ConnectionString {
            get {
                if (_dbConnection != null)
                    return _dbConnection;

                NpgsqlConnectionStringBuilder connectionString = new NpgsqlConnectionStringBuilder();
                connectionString.Host = "localhost";
                connectionString.Port = 5432;
                connectionString.Username = "postgres";
                connectionString.Password = "root";
                connectionString.Database = "sportshop";
                _dbConnection = connectionString.ToString();
                return _dbConnection;
            }
        }
        static DatabaseManager() {
            IsConnectionOpen = OpenConnection();
            if (!IsConnectionOpen)
                throw new ArgumentException("Cannot connect to DataBase.");
        }

        public static bool IsConnectionOpen
        {
            get { return _isConnectionOpen; }
            private set { _isConnectionOpen = value; }
        }

        private static bool OpenConnection()
        {
            return true;
        }    

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}