using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloning
{
    public partial class ManagerForm : Form
    {
        DirectoryInfo CloneToDelete;
        List<string> CheckedClones = new List<string>();

        string deleteallclonesmsg = "Are you sure you want to delete all backups?";

        internal void DeleteAll()
        {
            try
            {
                foreach (string s in clonelist.Items)
                {
                    if (Directory.Exists(Options.DataFolder + s))
                    {
                        Directory.Delete(Options.DataFolder + s, true);
                    }
                }
            }
            catch { }
        }

        private void DeleteSelected()
        {
            foreach (string item in CheckedClones)
            {
                CloneToDelete = new DirectoryInfo(Options.DataFolder + item + "\\");
                CloneToDelete.Delete(true);
            }
        }

        private void RefreshCheckedClones()
        {
            CheckedClones.Clear();

            foreach (var item in clonelist.CheckedItems)
            {
                CheckedClones.Add(item.ToString());
            }
        }

        internal void LoadCloneList()
        {
            clonelist.Items.Clear();

            int counter = 0;
            ByteSize totalsize = ByteSize.FromBytes(0);

            if (Directory.Exists(Options.DataFolder))
            {
                string[] clones = Directory.GetDirectories(Options.DataFolder);

                foreach (string clone in clones)
                {
                    counter++;
                    clonelist.Items.Add(Path.GetFileName(clone));

                    DirectoryInfo di = new DirectoryInfo(clone);
                    totalsize += ByteSize.FromBytes(Convert.ToDouble(di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length)));
                }
            }

            clonesdetected.Text = "Backups: " + counter.ToString();
            
            if (counter > 0)
            {
                totalsizetxt.Text = "Total size: " + totalsize;
            }
            else
            {
                totalsizetxt.Text = "Total size: -";
            }

            if (clonelist.Items.Count == 0)
            {
                clonelist.Visible = false;
                label2.Visible = true;
            }
            else
            {
                clonelist.Visible = true;
                label2.Visible = false;
            }
        }

        public ManagerForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            LoadCloneList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCheckedClones();
            DeleteSelected();

            LoadCloneList();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (clonelist.Items.Count > 0)
            {
                MessagerForm f = new MessagerForm(this, MessagerType.Question, deleteallclonesmsg);
                f.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start(Options.DataFolder);
        }
    }
}
