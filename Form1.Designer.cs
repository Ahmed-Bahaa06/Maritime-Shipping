namespace MaritimeShippingManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlViewBottom = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbJoinViews = new System.Windows.Forms.ComboBox();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.tblInsert = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.tblUpdate = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabJoin = new System.Windows.Forms.TabPage();
            this.dgvJoin = new System.Windows.Forms.DataGridView();
            this.pnlJoinTop = new System.Windows.Forms.Panel();
            this.cmbJoinQueries = new System.Windows.Forms.ComboBox();
            this.lblJoinParam = new System.Windows.Forms.Label();
            this.numJoinParam = new System.Windows.Forms.NumericUpDown();
            this.btnRunJoin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlViewBottom.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.pnlInsert.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.tabJoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoin)).BeginInit();
            this.pnlJoinTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinParam)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.pnlTop.Controls.Add(this.lblConnection);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 60);
            this.pnlTop.TabIndex = 2;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.LightGray;
            this.lblConnection.Location = new System.Drawing.Point(1850, 20);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(284, 20);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Connected to: AhmedBahaa\\SQLEXPRESS";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(512, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🚢 Maritime Shipping Management System";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(90)))));
            this.pnlSidebar.Controls.Add(this.lstTables);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(967, 664);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lstTables
            // 
            this.lstTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.lstTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstTables.ForeColor = System.Drawing.Color.White;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 23;
            this.lstTables.Items.AddRange(new object[] {
            "CLIENT",
            "PORT",
            "VESSEL",
            "VOYAGE",
            "CONTAINER",
            "CREWMEMBER",
            "MANIFEST",
            "CARRIES",
            "LISTS_IN",
            "HAS"});
            this.lstTables.Location = new System.Drawing.Point(0, 0);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(967, 664);
            this.lstTables.TabIndex = 0;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabView);
            this.tabMain.Controls.Add(this.tabInsert);
            this.tabMain.Controls.Add(this.tabUpdate);
            this.tabMain.Controls.Add(this.tabJoin);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(229, 664);
            this.tabMain.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.White;
            this.tabView.Controls.Add(this.dgvMain);
            this.tabView.Controls.Add(this.pnlViewBottom);
            this.tabView.Location = new System.Drawing.Point(4, 30);
            this.tabView.Name = "tabView";
            this.tabView.Size = new System.Drawing.Size(221, 630);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "📋 View Data";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeight = 29;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(221, 575);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // pnlViewBottom
            // 
            this.pnlViewBottom.Controls.Add(this.btnRefresh);
            this.pnlViewBottom.Controls.Add(this.cmbJoinViews);
            this.pnlViewBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewBottom.Location = new System.Drawing.Point(0, 575);
            this.pnlViewBottom.Name = "pnlViewBottom";
            this.pnlViewBottom.Size = new System.Drawing.Size(221, 55);
            this.pnlViewBottom.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "🔍 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbJoinViews
            // 
            this.cmbJoinViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoinViews.FormattingEnabled = true;
            this.cmbJoinViews.Items.AddRange(new object[] {
            "Voyage Full Details",
            "Containers With Client And Voyage",
            "Crew By Voyage",
            "Manifest With Containers",
            "Voyages With Container Count"});
            this.cmbJoinViews.Location = new System.Drawing.Point(190, 15);
            this.cmbJoinViews.Name = "cmbJoinViews";
            this.cmbJoinViews.Size = new System.Drawing.Size(320, 29);
            this.cmbJoinViews.TabIndex = 1;
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.White;
            this.tabInsert.Controls.Add(this.pnlInsert);
            this.tabInsert.Location = new System.Drawing.Point(4, 30);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Size = new System.Drawing.Size(192, 66);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "➕ Insert";
            // 
            // pnlInsert
            // 
            this.pnlInsert.Controls.Add(this.tblInsert);
            this.pnlInsert.Controls.Add(this.btnInsert);
            this.pnlInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInsert.Location = new System.Drawing.Point(0, 0);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInsert.Size = new System.Drawing.Size(192, 66);
            this.pnlInsert.TabIndex = 0;
            // 
            // tblInsert
            // 
            this.tblInsert.AutoSize = true;
            this.tblInsert.ColumnCount = 2;
            this.tblInsert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInsert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblInsert.Location = new System.Drawing.Point(20, 20);
            this.tblInsert.Name = "tblInsert";
            this.tblInsert.Size = new System.Drawing.Size(152, 0);
            this.tblInsert.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(20, 500);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 40);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.White;
            this.tabUpdate.Controls.Add(this.pnlUpdate);
            this.tabUpdate.Location = new System.Drawing.Point(4, 30);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(192, 66);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "✏️ Update / 🗑️ Delete";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.tblUpdate);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdate.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Padding = new System.Windows.Forms.Padding(20);
            this.pnlUpdate.Size = new System.Drawing.Size(192, 66);
            this.pnlUpdate.TabIndex = 0;
            // 
            // tblUpdate
            // 
            this.tblUpdate.AutoSize = true;
            this.tblUpdate.ColumnCount = 2;
            this.tblUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblUpdate.Location = new System.Drawing.Point(20, 20);
            this.tblUpdate.Name = "tblUpdate";
            this.tblUpdate.Size = new System.Drawing.Size(152, 0);
            this.tblUpdate.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(190, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabJoin
            // 
            this.tabJoin.BackColor = System.Drawing.Color.White;
            this.tabJoin.Controls.Add(this.dgvJoin);
            this.tabJoin.Controls.Add(this.pnlJoinTop);
            this.tabJoin.Location = new System.Drawing.Point(4, 30);
            this.tabJoin.Name = "tabJoin";
            this.tabJoin.Size = new System.Drawing.Size(192, 66);
            this.tabJoin.TabIndex = 3;
            this.tabJoin.Text = "🔗 Join Queries";
            // 
            // dgvJoin
            // 
            this.dgvJoin.AllowUserToAddRows = false;
            this.dgvJoin.AllowUserToDeleteRows = false;
            this.dgvJoin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJoin.BackgroundColor = System.Drawing.Color.White;
            this.dgvJoin.ColumnHeadersHeight = 29;
            this.dgvJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJoin.Location = new System.Drawing.Point(0, 70);
            this.dgvJoin.Name = "dgvJoin";
            this.dgvJoin.ReadOnly = true;
            this.dgvJoin.RowHeadersWidth = 51;
            this.dgvJoin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJoin.Size = new System.Drawing.Size(192, 0);
            this.dgvJoin.TabIndex = 0;
            // 
            // pnlJoinTop
            // 
            this.pnlJoinTop.Controls.Add(this.cmbJoinQueries);
            this.pnlJoinTop.Controls.Add(this.lblJoinParam);
            this.pnlJoinTop.Controls.Add(this.numJoinParam);
            this.pnlJoinTop.Controls.Add(this.btnRunJoin);
            this.pnlJoinTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlJoinTop.Location = new System.Drawing.Point(0, 0);
            this.pnlJoinTop.Name = "pnlJoinTop";
            this.pnlJoinTop.Size = new System.Drawing.Size(192, 70);
            this.pnlJoinTop.TabIndex = 1;
            // 
            // cmbJoinQueries
            // 
            this.cmbJoinQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoinQueries.FormattingEnabled = true;
            this.cmbJoinQueries.Items.AddRange(new object[] {
            "Voyage Full Details",
            "Containers With Client And Voyage",
            "Crew By Voyage",
            "Manifest With Containers",
            "Voyages With Container Count"});
            this.cmbJoinQueries.Location = new System.Drawing.Point(20, 20);
            this.cmbJoinQueries.Name = "cmbJoinQueries";
            this.cmbJoinQueries.Size = new System.Drawing.Size(320, 29);
            this.cmbJoinQueries.TabIndex = 0;
            // 
            // lblJoinParam
            // 
            this.lblJoinParam.AutoSize = true;
            this.lblJoinParam.Location = new System.Drawing.Point(370, 24);
            this.lblJoinParam.Name = "lblJoinParam";
            this.lblJoinParam.Size = new System.Drawing.Size(28, 21);
            this.lblJoinParam.TabIndex = 1;
            this.lblJoinParam.Text = "ID:";
            // 
            // numJoinParam
            // 
            this.numJoinParam.Location = new System.Drawing.Point(410, 20);
            this.numJoinParam.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numJoinParam.Name = "numJoinParam";
            this.numJoinParam.Size = new System.Drawing.Size(120, 29);
            this.numJoinParam.TabIndex = 2;
            // 
            // btnRunJoin
            // 
            this.btnRunJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.btnRunJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunJoin.ForeColor = System.Drawing.Color.White;
            this.btnRunJoin.Location = new System.Drawing.Point(560, 15);
            this.btnRunJoin.Name = "btnRunJoin";
            this.btnRunJoin.Size = new System.Drawing.Size(170, 38);
            this.btnRunJoin.TabIndex = 3;
            this.btnRunJoin.Text = "RUN QUERY";
            this.btnRunJoin.UseVisualStyleBackColor = false;
            this.btnRunJoin.Click += new System.EventHandler(this.btnRunJoin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblRecordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 724);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.BackColor = System.Drawing.Color.White;
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(1135, 20);
            this.lblRecordCount.Spring = true;
            this.lblRecordCount.Text = "Records: 0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 60);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.pnlSidebar);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.tabMain);
            this.mainContainer.Size = new System.Drawing.Size(1200, 664);
            this.mainContainer.SplitterDistance = 967;
            this.mainContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🚢 Maritime Shipping Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlViewBottom.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.pnlInsert.ResumeLayout(false);
            this.pnlInsert.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.tabJoin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoin)).EndInit();
            this.pnlJoinTop.ResumeLayout(false);
            this.pnlJoinTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinParam)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConnection;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.ListBox lstTables;

        private System.Windows.Forms.TabControl tabMain;

        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlViewBottom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbJoinViews;

        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.TableLayoutPanel tblInsert;
        private System.Windows.Forms.Button btnInsert;

        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.TableLayoutPanel tblUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.TabPage tabJoin;
        private System.Windows.Forms.Panel pnlJoinTop;
        private System.Windows.Forms.ComboBox cmbJoinQueries;
        private System.Windows.Forms.Label lblJoinParam;
        private System.Windows.Forms.NumericUpDown numJoinParam;
        private System.Windows.Forms.Button btnRunJoin;
        private System.Windows.Forms.DataGridView dgvJoin;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblRecordCount;

        private System.Windows.Forms.SplitContainer mainContainer;
    }
}