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
using MC_Capacity.Services;
using MC_Capacity.Helper;

namespace MC_Capacity
{
    public partial class Form1 : Form
    {
        ConnectDB conn = new ConnectDB();
        public Form1()
        {
            InitializeComponent();
        }


        private void btstart_Click(object sender, EventArgs e)
        {
            Array driveInfo = DriveService.getInfo();
            if (driveInfo.Length > 0)
            {
                setInfo(driveInfo);               
            }
            else { 
                //Set Warning message
            }
        }

        private void setInfo(Array driveInfo) {
            /*Show Table*/
            DriveDatabaseHelper helper = new DriveDatabaseHelper();
            Dictionary<string, object> machine = DriveService.getMachineInfo();
            foreach (DriveInfo d in driveInfo)
            {
                if (d.DriveType.ToString() == "Fixed")
                {
                    rtbresual.Text += Environment.NewLine + "Drive" + d.Name;
                    if (d.DriveType.ToString() == "Fixed")
                    {
                        rtbresual.Text += Environment.NewLine + "Volum label : " + d.VolumeLabel;
                        rtbresual.Text += Environment.NewLine + "File System : " + d.DriveFormat;
                        rtbresual.Text += Environment.NewLine + "Year : " + d.RootDirectory.Root.CreationTime.Year;
                        rtbresual.Text += Environment.NewLine + "Availabel space to current used : " + DriveService.convertByte(d.AvailableFreeSpace);
                        rtbresual.Text += Environment.NewLine + "Total size of drive : " + DriveService.convertByte(d.TotalSize);
                        rtbresual.Text += Environment.NewLine + "Total available space : " + DriveService.convertByte(d.TotalFreeSpace);

                        //Insert Store Procedures
                        String result = helper.insert(d, machine);
                        rtbresual.Text += Environment.NewLine + "Result : " + result;
                        rtbresual.Text += Environment.NewLine;
                    }
                }
            }
        }
    }
}
