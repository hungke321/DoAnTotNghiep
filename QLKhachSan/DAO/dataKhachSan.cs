using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace DAO
{
    class dataKhachSan
    {
        private static SqlConnection _connection = null;

        public dataKhachSan()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Execute select query
        /// </summary>
        /// <param name="query">a string of select query</param>
        /// <returns>DataTable of query</returns>
        /// <exception cref="Something went wrong"></exception>
        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Execute query erorr: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return table;
        }

        /// <summary>
        /// Execute insert, update, delete query
        /// </summary>
        /// <param name="query">a query string</param>
        /// <exception cref="Something went wrong"></exception>
        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);

            try
            {
                _connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

                if (command != null)
                {
                    command.Dispose();
                }
            }
        }
    }
}
