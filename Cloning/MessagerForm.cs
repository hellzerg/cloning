using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Cloning
{
    public partial class MessagerForm : Form
    {
        ManagerForm _manager;
        MessagerType mode;

        private void Confirm()
        {
            if (mode == MessagerType.Info)
            {
                this.Close();
            }
            if (mode == MessagerType.Question)
            {
                _manager.DeleteAll();

                _manager.LoadCloneList();
            }
        }

        public MessagerForm(ManagerForm manager, MessagerType m, string s)
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            _manager = manager;
            mode = m;
            msg.Text = s;

            if (mode == MessagerType.Info)
            {
                nobtn.Visible = false;
                yesbtn.Text = "OK";

                this.AcceptButton = nobtn;
                this.AcceptButton = yesbtn;
                this.CancelButton = nobtn;
                this.CancelButton = yesbtn;
            }
        }

        private void Messager_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.BringToFront();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            Confirm();
            this.Close();
        }
    }
}
