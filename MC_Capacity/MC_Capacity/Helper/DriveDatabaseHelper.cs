using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Capacity.Helper
{
    class DriveDatabaseHelper
    {  
        ConnectDB db = new ConnectDB();
        public string insert(DriveInfo info, Dictionary<string, object> machine) {
            string result;
            try
            {
                SqlConnection conn = this.db.ConnectionDB();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter atAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                using (conn) {
                    strStored = "INT_Capacity";
                    cmd.Parameters.Add(new SqlParameter("@pName", machine["name"]));
                    cmd.Parameters.Add(new SqlParameter("@pType", machine["type"]));
                    cmd.Parameters.Add(new SqlParameter("@pLine", machine["line"]));
                    cmd.Parameters.Add(new SqlParameter("@pDrive", info.Name));
                    cmd.Parameters.Add(new SqlParameter("@pTotal", info.TotalSize));
                    cmd.Parameters.Add(new SqlParameter("@pUsed", info.AvailableFreeSpace));
                    cmd.Parameters.Add(new SqlParameter("@pFree_Space", info.TotalFreeSpace));
                    cmd.Parameters.Add(new SqlParameter("@pDisk_Year", (int)info.RootDirectory.Root.CreationTime.Year));
                    cmd.Connection = conn;
                    cmd.CommandText = strStored;
                    cmd.CommandType = CommandType.StoredProcedure;
                    atAdapter.SelectCommand = cmd;
                    atAdapter.Fill(ds);
                    dt = ds.Tables[0];
                    conn.Close();
                }
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        result = "Insert OK";
                    }
                    else
                    {
                        result = "Can't Insert";
                    }
                }
                catch
                {
                    result = "Can't Insert";
                }
            }
            catch (SqlException e) {
                result = (e.ToString());
            }
            return result;
        }
    }
}
