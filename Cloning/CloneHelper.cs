using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloning
{
    public partial class CloneHelper : Form
    {
        MainForm _Main;
        CloneType _Type;

        public CloneHelper(MainForm main, CloneType type)
        {
            InitializeComponent();
            _Main = main;
            _Type = type;

            Options.ApplyTheme(this);

            if (_Type == CloneType.Backup)
            {
                label1.Text = "Backing up, please wait";
            }
            if (_Type == CloneType.Restore)
            {
                label1.Text = "Restoring, please wait";
            }
        }

        private void CloningAnimation()
        {
            if (_Type == CloneType.Backup)
            {
                foreach (Addon a in _Main.selectedAddons)
                {
                    a.Backup(_Main.CurrentBackupPath);
                }

                this.Close();
            }
            if (_Type == CloneType.Restore)
            {
                foreach (Addon a in _Main.selectedAddons)
                {
                    a.Restore(_Main.CurrentRestorePath);
                }

                this.Close();
            }
        }

        private void CloneHelper_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            dotter.Start();

            Task t = new Task(() => CloningAnimation());
            t.Start();

            this.BringToFront();
        }

        private void dotter_Tick(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "":
                    label2.Text = ".";
                    break;
                case ".":
                    label2.Text = "..";
                    break;
                case "..":
                    label2.Text = "...";
                    break;
                case "...":
                    label2.Text = "";
                    break;
            }
        }
    }
}
