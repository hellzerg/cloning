namespace Cloning
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.clonesdetected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.clonelist = new System.Windows.Forms.CheckedListBox();
            this.totalsizetxt = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clonesdetected
            // 
            this.clonesdetected.AutoSize = true;
            this.clonesdetected.ForeColor = System.Drawing.Color.White;
            this.clonesdetected.Location = new System.Drawing.Point(14, 52);
            this.clonesdetected.Name = "clonesdetected";
            this.clonesdetected.Size = new System.Drawing.Size(77, 20);
            this.clonesdetected.TabIndex = 3;
            this.clonesdetected.Text = "Backups : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 2;
            this.label1.Tag = "themeable";
            this.label1.Text = "Backup Manager";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(111, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(12, 447);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(93, 39);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Delete all";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clonelist);
            this.panel1.Location = new System.Drawing.Point(18, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 318);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 318);
            this.label2.TabIndex = 6;
            this.label2.Tag = "themeable";
            this.label2.Text = "No backups";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // clonelist
            // 
            this.clonelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clonelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clonelist.CheckOnClick = true;
            this.clonelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clonelist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clonelist.ForeColor = System.Drawing.Color.White;
            this.clonelist.FormattingEnabled = true;
            this.clonelist.Location = new System.Drawing.Point(0, 0);
            this.clonelist.Name = "clonelist";
            this.clonelist.Size = new System.Drawing.Size(360, 318);
            this.clonelist.TabIndex = 5;
            // 
            // totalsizetxt
            // 
            this.totalsizetxt.AutoSize = true;
            this.totalsizetxt.ForeColor = System.Drawing.Color.White;
            this.totalsizetxt.Location = new System.Drawing.Point(14, 81);
            this.totalsizetxt.Name = "totalsizetxt";
            this.totalsizetxt.Size = new System.Drawing.Size(75, 20);
            this.totalsizetxt.TabIndex = 13;
            this.totalsizetxt.Text = "Total size:";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(293, 447);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 39);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "OK";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(202, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Manager
            // 
            this.AcceptButton = this.btnclose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(390, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.totalsizetxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.clonesdetected);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clonesdetected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clonelist;
        private System.Windows.Forms.Label totalsizetxt;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}