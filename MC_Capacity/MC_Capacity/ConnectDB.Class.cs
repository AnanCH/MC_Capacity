using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Capacity
{
    class ConnectDB
    {
        string Error;
        public SqlConnection ConnectionDB()
        {
            try {
                var appSettings = ConfigurationManager.AppSettings;
                string Server = appSettings.Get("Server");
                string DataBase = appSettings.Get("DBName");
                string User = appSettings.Get("User");
                string PW = appSettings.Get("PW");
                string PoolSize = appSettings.Get("PoolSize");
                string Timeout = appSettings.Get("Timeout");
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=" + Server + ";"
                                 + "Initial Catalog=" + DataBase + ";"
                                 + "User ID=" + User + ";"
                                 + "Password=" + PW + ";"
                                 + "Max Pool Size=" + PoolSize + ";"
                                 + "Connect Timeout=" + Timeout + ";";
                cnn = new SqlConnection(connectionString);               
                return cnn;
            }
            catch (SqlException e) {
                SqlConnection cnn;
                cnn = new SqlConnection();
                Error = e.ToString();               
                return cnn;
            }
        }

    }
}
