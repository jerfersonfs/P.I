using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using Npgsql;
using System.Configuration;
using System.Data;

namespace Projeto_Integrador___pt2
{
    class Conection : IDisposable
    {
        private NpgsqlConnection connection;
        private bool _disposed = false;

        private string connectionString;
        public Conection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new NpgsqlConnection(connectionString);
        }
        public void Open()
        {
            if (connection.State != ConnectionState.Open) 
            { 
                connection.Open();
            }
        }
        public void Close() 
        {
            if (connection.State == ConnectionState.Open)
            { connection.Close(); }
        }

        public NpgsqlConnection Connection => connection;
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed) 
            { 
            if (disposing)
                {
                    if (connection != null)
                    {
                        Close();
                        connection.Dispose();
                    }
                }
                _disposed = true;
            }
        }
    }
}
