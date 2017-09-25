using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloning
{
    public partial class SelectorForm : Form
    {
        MainForm _main;

        public SelectorForm(MainForm m)
        {
            InitializeComponent();
            _main = m;
            Options.ApplyTheme(this);
        }

        internal void LoadCloneList()
        {
            clonelist.Items.Clear();

            if (Directory.Exists(Options.DataFolder))
            {
                string[] clones = Directory.GetDirectories(Options.DataFolder);

                foreach (string clone in clones)
                {
                    clonelist.Items.Add(Path.GetFileName(clone));
                }
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

        private void Selector_Load(object sender, EventArgs e)
        {
            LoadCloneList();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (clonelist.SelectedItems.Count == 1)
            {
                _main.CurrentRestorePath = Options.DataFolder + clonelist.SelectedItem.ToString() + "\\";
                this.Close();
            }
        }

        private void clonelist_DoubleClick(object sender, EventArgs e)
        {
            if (clonelist.SelectedItems.Count == 1)
            {
                _main.CurrentRestorePath = Options.DataFolder + clonelist.SelectedItem.ToString() + "\\";
                this.Close();
            }
        }
    }
}
