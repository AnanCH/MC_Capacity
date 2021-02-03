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
using System.Net.Mail;

namespace MC_Capacity
{
    public partial class Form1 : Form
    {
        ConnectDB conn = new ConnectDB();


        public Form1()
        {
            InitializeComponent();
            int time = (1 * 1000);
            scheduler.Interval = time;
            scheduler.Enabled = true;

        }



        //private void btstart_Click(object sender, EventArgs e)
        //{
        //    Array driveInfo = DriveService.getInfo();
        //    if (driveInfo.Length > 0)
        //    {

        //        setInfo(driveInfo);
        //    }
        //    else
        //    {
        //        //Set Warning message
        //    }
        //}

        public void setInfo(DriveInfo info)
        {

            if (info.DriveType.ToString() == "Fixed")
            {
                rtbresual.Text += Environment.NewLine + "Drive : " + info.Name;
                rtbresual.Text += Environment.NewLine + "Year : " + info.RootDirectory.Root.CreationTime.Year;
                rtbresual.Text += Environment.NewLine + "Total size of drive : " + DriveService.convertByte(info.TotalSize);
                rtbresual.Text += Environment.NewLine + "Used space : " + DriveService.convertByte(info.TotalSize - info.AvailableFreeSpace);
                rtbresual.Text += Environment.NewLine + "Free space : " + DriveService.convertByte(info.AvailableFreeSpace);

            }

        }


        public void scheduler_Tick(object sender, EventArgs e)
        {

            runtime();
        }

        public void runtime()
        {

            string vDatetime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            showtime.Text = "Date : " + vDatetime;
            string timecheck = DateTime.Now.ToString("ss");

            if (timecheck == "00")
            {
                rtbresual.Clear();

                Array driveInfo = DriveService.getInfo();
                DriveDatabaseHelper helper = new DriveDatabaseHelper();
                Dictionary<string, object> machine = DriveService.getMachineInfo();

                foreach (DriveInfo d in driveInfo)
                {

                    if (d.DriveType.ToString() == "Fixed")
                    {
                        setInfo(d);
                        //Insert Store Procedures
                        String result = helper.insert(d, machine);
                        rtbresual.Text += Environment.NewLine + "Result : " + result;
                        rtbresual.Text += Environment.NewLine + "Date Update : " + vDatetime;

                    }
                }



            }

        }





        //Send E-mail
        //private void sendmail(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient("smtpm.csloxinfo.com");

        //        mail.From = new MailAddress("mis@siix-ems.com");
        //        mail.To.Add("mis@siix-ems.com");
        //        mail.Subject = "Test Mail";
        //        mail.Body = "This is for testing SMTP mail from GMAIL";

        //        SmtpServer.Port = 587;
        //        SmtpServer.Credentials = new System.Net.NetworkCredential("mis@siix-ems.com", "TC_siix2018");
        //        SmtpServer.EnableSsl = true;

        //        SmtpServer.Send(mail);
        //        MessageBox.Show("mail Send");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}  

    }
}
