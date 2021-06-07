using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cloning
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void About_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "C";
            string s2 = "Cl";
            string s3 = "Clo";
            string s4 = "Clon";
            string s5 = "Cloni";
            string s6 = "Clonin";
            string s7 = "Cloning";

            switch (l1.Text)
            {
                case "":
                    l1.Text = s1;
                    break;
                case "C":
                    l1.Text = s2;
                    break;
                case "Cl":
                    l1.Text = s3;
                    break;
                case "Clo":
                    l1.Text = s4;
                    break;
                case "Clon":
                    l1.Text = s5;
                    break;
                case "Cloni":
                    l1.Text = s6;
                    break;
                case "Clonin":
                    l1.Text = s7;
                    t1.Stop();
                    t2.Start();
                    break;
                case "Cloning":
                    l1.Text = s0;
                    break;
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "d";
            string s2 = "de";
            string s3 = "dea";
            string s4 = "dead";
            string s5 = "deadm";
            string s6 = "deadmo";
            string s7 = "deadmoo";
            string s8 = "deadmoon";
            string s9 = "deadmoon © ";
            string s10 = "deadmoon © ∞";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "d":
                    l2.Text = s2;
                    break;
                case "de":
                    l2.Text = s3;
                    break;
                case "dea":
                    l2.Text = s4;
                    break;
                case "dead":
                    l2.Text = s5;
                    break;
                case "deadm":
                    l2.Text = s6;
                    break;
                case "deadmo":
                    l2.Text = s7;
                    break;
                case "deadmoo":
                    l2.Text = s8;
                    break;
                case "deadmoon":
                    l2.Text = s9;
                    break;
                case "deadmoon © ":
                    l2.Text = s10;
                    t2.Stop();
                    break;
                case "deadmoon © ∞":
                    l2.Text = s0;
                    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/hellzerg/cloning");
        }
    }
}
