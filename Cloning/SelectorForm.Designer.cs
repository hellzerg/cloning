namespace Cloning
{
    partial class SelectorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.clonelist = new System.Windows.Forms.ListBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 3;
            this.label1.Tag = "themeable";
            this.label1.Text = "Choose backup, by date";
            // 
            // clonelist
            // 
            this.clonelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clonelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clonelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clonelist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clonelist.ForeColor = System.Drawing.Color.White;
            this.clonelist.FormattingEnabled = true;
            this.clonelist.ItemHeight = 28;
            this.clonelist.Location = new System.Drawing.Point(0, 0);
            this.clonelist.Name = "clonelist";
            this.clonelist.Size = new System.Drawing.Size(360, 384);
            this.clonelist.TabIndex = 4;
            this.clonelist.DoubleClick += new System.EventHandler(this.clonelist_DoubleClick);
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.okbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.okbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.okbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okbtn.ForeColor = System.Drawing.Color.White;
            this.okbtn.Location = new System.Drawing.Point(273, 447);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(105, 39);
            this.okbtn.TabIndex = 13;
            this.okbtn.Tag = "themeable";
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = false;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(162, 447);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(105, 39);
            this.cancelbtn.TabIndex = 12;
            this.cancelbtn.Tag = "themeable";
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 384);
            this.label2.TabIndex = 14;
            this.label2.Tag = "themeable";
            this.label2.Text = "No backups";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.clonelist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 384);
            this.panel1.TabIndex = 15;
            // 
            // Selector
            // 
            this.AcceptButton = this.okbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(390, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Selector_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox clonelist;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}