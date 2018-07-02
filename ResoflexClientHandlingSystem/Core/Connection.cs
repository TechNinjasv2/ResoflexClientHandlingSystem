using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResoflexClientHandlingSystem.Core
{
    class DBConnection
    {
        private static string connString = string.Format("Server=localhost; database=ResoflexClientHandlingSystem; UID=root; password=; SSLMode=none");
        private static MySqlConnection conn = new MySqlConnection(connString);
        private static MySqlConnection tmpConn = null;

        private DBConnection() { }

        private static MySqlConnection getConnection()
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State.ToString().Equals("closed") || conn.State.ToString().Equals("Closed"))
                        conn.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error!\nCheck if the MySQL connection has started!", "MySQL Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            return conn;
        }

        private static MySqlConnection getTmpConnection()
        {
            if (tmpConn == null)
            {
                tmpConn = new MySqlConnection(connString);
            }

            if (tmpConn.State.ToString().Equals("Closed") || tmpConn.State.ToString().Equals("closed"))
                tmpConn.Open();

            return tmpConn;
        }

        public static MySqlDataReader getDataViaTmpConnection(string qry)
        {
            return new MySqlCommand(qry, getTmpConnection()).ExecuteReader();
        }

        public static void closeTmpConnection()
        {
            if (tmpConn.State.ToString().Equals("Open") || tmpConn.State.ToString().Equals("open"))
                tmpConn.Close();
        }
        
        public static MySqlDataReader getData(string qry)
        {
            if (conn != null)
                return new MySqlCommand(qry, getConnection()).ExecuteReader();
            else
                return null;
        }

        public static void updateDB(string qry)
        {
            if (conn != null)
            {
                new MySqlCommand(qry, getConnection()).ExecuteNonQuery();
            }
        }
        /*
        public static void backupDB()
        {
            try
            {
                string file = "C:/Users/Geeth Sandaru/Downloads/Backup.sql";

                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = getConnection();
                            mb.ExportToFile(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
