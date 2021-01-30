using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Capacity
{
    public partial class Form1 : Form
    {
        ConnectDB conn = new ConnectDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetInfo() 
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives) 
            {
                if (d.DriveType.ToString() == "Fixed") 
                {
                    rtbresual.Text += Environment.NewLine + "Drive" + d.Name;
                    if (d.DriveType.ToString() == "Fixed") 
                    {
                        rtbresual.Text += Environment.NewLine + "Volum label" + d.VolumeLabel;
                        rtbresual.Text += Environment.NewLine + "File System" + d.DriveFormat;
                        rtbresual.Text += Environment.NewLine + "Year" + d.RootDirectory.Root.CreationTime.Year;
                        rtbresual.Text += Environment.NewLine + "Availabel space to current used" + FormatBytes(d.AvailableFreeSpace) + "bytes";
                        rtbresual.Text += Environment.NewLine + "Total size of drive" + FormatBytes(d.TotalSize) + "bytes";
                        rtbresual.Text += Environment.NewLine + "Total available space" + FormatBytes(d.TotalFreeSpace) + "bytes";
                        
                    }
                }
            }
        }

        private static string FormatBytes(long bytes) 
        {
            string[] Suffix = {"B","KB","MB","GB","TB"};
            int i;
            double dblSByte = bytes; 
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024) {
                dblSByte = bytes / 1024.0;
            }
            return String.Format(dblSByte.ToString());
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            //GetInfo();
            
        }

    }
}
