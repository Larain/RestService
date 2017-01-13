using System.Data.SqlClient;
using System.Threading;

namespace SportStudioModel
{
    class TransactionOperator
    {
        #region Singleton

        private static TransactionOperator _instance = null;
        private static readonly object Locker = new object();

        public static TransactionOperator Instance
        {
            get
            {
                lock (Locker)
                {
                    return _instance ?? (_instance = new TransactionOperator());
                }
            }
        }


        #endregion

        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private string _connectionString;

        public void Initialize(string connectionString)
        {
            if (_connection == null)
            {
                _connectionString = connectionString;
                _connection = new SqlConnection(connectionString);
                _connection.Open();
            }
        }
    }
}
