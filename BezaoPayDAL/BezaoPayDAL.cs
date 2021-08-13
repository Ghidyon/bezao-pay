using System;
using System.Data;
using System.Data.SqlClient;

namespace BezaoPayDAL
{
    public class BezaoPayDAL
    {
        private readonly string _connectionString;

        private SqlConnection _sqlConnection = null;

        // Default constructor with chaining (Constructor Overloading)
        public BezaoPayDAL() : 
            this(@"Data Source = (localdb)\mssqllocaldb;Integrated Security=true;Initial Catalog=BezaoPay")
        { 
        }

        public BezaoPayDAL(string connectionString)
            => _connectionString = connectionString;

        private void OpenConnection()
        {

        }
    }
}
