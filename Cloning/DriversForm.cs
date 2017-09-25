using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Cloning
{
    public partial class DriversForm : Form
    {
        readonly string DriverBackupFolder = Application.StartupPath + "\\Drivers\\";
        readonly string Now = (DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString()).Replace("/", "-").Replace(":", ".");
        readonly string ErrorMessage = "An error occured while copying drivers";

        DriverUtility driverUtility;

        public DriversForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
            FixColor();
            driverUtility = new DriverUtility();
        }

        private void DetectDrivers(bool showMicrosoft)
        {
            DriverList.DataSource = null;
            ArrayList al = driverUtility.ListDrivers(showMicrosoft);
            DriverList.AutoGenerateColumns = false;
            DriverList.DataSource = al;
            this.Text = string.Format("Drivers [{0} detected]", al.Count);
        }

        private void FixColor()
        {
            DriverList.GridColor = Options.ForegroundColor;
            DriverList.ColumnHeadersDefaultCellStyle.BackColor = Options.BackgroundColor;
            DriverList.ColumnHeadersDefaultCellStyle.ForeColor = Options.ForegroundColor;

            foreach (DataGridViewColumn column in DriverList.Columns)
            {
                column.DefaultCellStyle.BackColor = Options.BackgroundColor;
                column.DefaultCellStyle.ForeColor = Options.ForegroundColor;
            }
        }

        private string Backup()
        {
            try
            {
                foreach (DataGridViewRow selectedDriver in DriverList.SelectedRows)
                {
                    string deviceGUID = selectedDriver.Cells[2].Value.ToString();
                    string driverID = selectedDriver.Cells[3].Value.ToString();

                    driverUtility.BackupDriver(deviceGUID, driverID, DriverBackupFolder + Now + "\\");
                }
                return DriverBackupFolder + Now;
            }
            catch
            {
                MessagerForm f = new MessagerForm(null, MessagerType.Info, ErrorMessage);
                f.ShowDialog();
                return string.Empty;
            }
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            DetectDrivers(checkBox1.Checked);

            if (!Directory.Exists(DriverBackupFolder))
            {
                Directory.CreateDirectory(DriverBackupFolder);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverList.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverList.ClearSelection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DetectDrivers(checkBox1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task<string> t = Task<string>.Factory.StartNew(() => Backup());
            
            if (!string.IsNullOrEmpty(t.Result))
            {
                Process.Start(t.Result);
            }
        }

        private void DriverList_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDrivers.Text = DriverList.SelectedRows.Count.ToString();
        }
    }
}
