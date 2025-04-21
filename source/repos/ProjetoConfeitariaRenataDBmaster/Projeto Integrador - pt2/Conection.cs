using Projeto_Integrador___pt2.Properties;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Projeto_Integrador___pt2
{
    class Conection
    {
        private SqlConnection connection;
        private bool _disposed = false;
        public String connectionString = Properties.Settings.Default.RenataDBConnectionString;
        public Conection()
        {
            connection = new SqlConnection(connectionString);
        }
        public void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open) 
            { 
                connection.Open();
            }
        }
        public void Close() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            { connection.Close(); }
        }

        public SqlConnection Connection => connection;
 
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
