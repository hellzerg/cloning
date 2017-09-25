namespace Cloning
{
    partial class DriversForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversForm));
            this.DriverList = new System.Windows.Forms.DataGridView();
            this.DriverProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDeviceGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.botPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblSelectedDrivers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DriverList)).BeginInit();
            this.topPanel.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverList
            // 
            this.DriverList.AllowUserToAddRows = false;
            this.DriverList.AllowUserToDeleteRows = false;
            this.DriverList.AllowUserToResizeRows = false;
            this.DriverList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DriverList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DriverList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverProvider,
            this.DriverDescription,
            this.DriverDeviceGUID,
            this.DriverID});
            this.DriverList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverList.EnableHeadersVisualStyles = false;
            this.DriverList.GridColor = System.Drawing.Color.DodgerBlue;
            this.DriverList.Location = new System.Drawing.Point(0, 0);
            this.DriverList.Name = "DriverList";
            this.DriverList.ReadOnly = true;
            this.DriverList.RowHeadersVisible = false;
            this.DriverList.RowTemplate.Height = 24;
            this.DriverList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriverList.Size = new System.Drawing.Size(844, 523);
            this.DriverList.TabIndex = 1;
            this.DriverList.SelectionChanged += new System.EventHandler(this.DriverList_SelectionChanged);
            // 
            // DriverProvider
            // 
            this.DriverProvider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverProvider.DataPropertyName = "DriverProvider";
            this.DriverProvider.HeaderText = "PROVIDER:";
            this.DriverProvider.Name = "DriverProvider";
            this.DriverProvider.ReadOnly = true;
            this.DriverProvider.Width = 113;
            // 
            // DriverDescription
            // 
            this.DriverDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverDescription.DataPropertyName = "DriverDescription";
            this.DriverDescription.HeaderText = "DESCRIPTION:";
            this.DriverDescription.Name = "DriverDescription";
            this.DriverDescription.ReadOnly = true;
            this.DriverDescription.Width = 135;
            // 
            // DriverDeviceGUID
            // 
            this.DriverDeviceGUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverDeviceGUID.DataPropertyName = "DriverDeviceGUID";
            this.DriverDeviceGUID.HeaderText = "DEVICE GUID:";
            this.DriverDeviceGUID.Name = "DriverDeviceGUID";
            this.DriverDeviceGUID.ReadOnly = true;
            this.DriverDeviceGUID.Width = 132;
            // 
            // DriverID
            // 
            this.DriverID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverID.DataPropertyName = "DriverID";
            this.DriverID.HeaderText = "DRIVER ID:";
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            this.DriverID.Width = 112;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.DriverList);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(846, 525);
            this.topPanel.TabIndex = 2;
            // 
            // botPanel
            // 
            this.botPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.botPanel.Controls.Add(this.button1);
            this.botPanel.Controls.Add(this.checkBox1);
            this.botPanel.Controls.Add(this.lblSelectedDrivers);
            this.botPanel.Controls.Add(this.label7);
            this.botPanel.Controls.Add(this.label3);
            this.botPanel.Controls.Add(this.linkLabel1);
            this.botPanel.Controls.Add(this.linkLabel2);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(0, 525);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(846, 66);
            this.botPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(734, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 29;
            this.button1.Tag = "themeable";
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(540, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 24);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Show Microsoft drivers";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblSelectedDrivers
            // 
            this.lblSelectedDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectedDrivers.AutoSize = true;
            this.lblSelectedDrivers.ForeColor = System.Drawing.Color.White;
            this.lblSelectedDrivers.Location = new System.Drawing.Point(155, 36);
            this.lblSelectedDrivers.Name = "lblSelectedDrivers";
            this.lblSelectedDrivers.Size = new System.Drawing.Size(17, 20);
            this.lblSelectedDrivers.TabIndex = 27;
            this.lblSelectedDrivers.Text = "0";
            this.lblSelectedDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Selected drivers:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "|";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(86, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 20);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "themeable";
            this.linkLabel1.Text = "Deselect all";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(11, 7);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 20);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "themeable";
            this.linkLabel2.Text = "Select all";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(846, 591);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DriversForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.DriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DriverList)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DriverList;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Label lblSelectedDrivers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDeviceGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
    }
}