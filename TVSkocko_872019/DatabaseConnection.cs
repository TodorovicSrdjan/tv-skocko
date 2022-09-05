using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    public sealed class DatabaseConnection
    {
        private static readonly object lockObject = new object();

        private DatabaseConnection()
        {
            this.Connection = new SqlConnection(Settings.Default.ConnectionString);
        }


        public SqlConnection Connection { get; set; }

        private static DatabaseConnection instance = null;

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null) { instance = new DatabaseConnection(); }
                    }
                }

                return instance;
            }
        }
    }
}
