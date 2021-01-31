using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Capacity.Services
{
    class DriveService
    {
        public static Array getInfo() {
            DriveInfo[] drives = DriveInfo.GetDrives();
            return drives;
        }

        public static string convertByte(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            string type = null;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024) {
                dblSByte = bytes / 1024.0;
                type = Suffix[i];
            }
            return String.Format(dblSByte.ToString())+" "+type;
        }

        public static Dictionary<string, object> getMachineInfo() {
            Dictionary<string, object> machine = new Dictionary<string, object>();
            machine.Add("name", ConfigurationManager.AppSettings["Machine"]);
            machine.Add("type", ConfigurationManager.AppSettings["Type"]);
            machine.Add("line", ConfigurationManager.AppSettings["Line"]);
            return machine;
        }
    }
}
