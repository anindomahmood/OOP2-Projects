namespace HRMS
{
    partial class Payroll
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
            this.tlpinfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblmonth = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.cmbinfo = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblgdate = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.dtpgdate = new System.Windows.Forms.DateTimePicker();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvpayroll = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.tlpinfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayroll)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpinfo
            // 
            this.tlpinfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlpinfo.ColumnCount = 2;
            this.tlpinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpinfo.Controls.Add(this.panel4, 1, 1);
            this.tlpinfo.Controls.Add(this.panel3, 0, 1);
            this.tlpinfo.Controls.Add(this.panel2, 1, 0);
            this.tlpinfo.Controls.Add(this.panel1, 0, 0);
            this.tlpinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpinfo.Location = new System.Drawing.Point(0, 0);
            this.tlpinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpinfo.Name = "tlpinfo";
            this.tlpinfo.RowCount = 2;
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpinfo.Size = new System.Drawing.Size(1304, 629);
            this.tlpinfo.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblmonth);
            this.panel4.Controls.Add(this.cmbmonth);
            this.panel4.Controls.Add(this.cmbinfo);
            this.panel4.Controls.Add(this.cmbstatus);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Controls.Add(this.lblgdate);
            this.panel4.Controls.Add(this.lblPID);
            this.panel4.Controls.Add(this.dtpgdate);
            this.panel4.Controls.Add(this.txtpid);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(907, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 565);
            this.panel4.TabIndex = 3;
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmonth.Location = new System.Drawing.Point(16, 151);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(92, 25);
            this.lblmonth.TabIndex = 27;
            this.lblmonth.Text = "MONTH:";
            // 
            // cmbmonth
            // 
            this.cmbmonth.BackColor = System.Drawing.Color.OldLace;
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.cmbmonth.Location = new System.Drawing.Point(123, 151);
            this.cmbmonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(249, 24);
            this.cmbmonth.TabIndex = 26;
            // 
            // cmbinfo
            // 
            this.cmbinfo.BackColor = System.Drawing.Color.OldLace;
            this.cmbinfo.FormattingEnabled = true;
            this.cmbinfo.Location = new System.Drawing.Point(99, 41);
            this.cmbinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbinfo.Name = "cmbinfo";
            this.cmbinfo.Size = new System.Drawing.Size(273, 24);
            this.cmbinfo.TabIndex = 25;
            // 
            // cmbstatus
            // 
            this.cmbstatus.BackColor = System.Drawing.Color.OldLace;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "APPROVED",
            "PENDING"});
            this.cmbstatus.Location = new System.Drawing.Point(123, 263);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(249, 24);
            this.cmbstatus.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(15, 263);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 25);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblgdate
            // 
            this.lblgdate.AutoSize = true;
            this.lblgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgdate.Location = new System.Drawing.Point(16, 204);
            this.lblgdate.Name = "lblgdate";
            this.lblgdate.Size = new System.Drawing.Size(94, 25);
            this.lblgdate.TabIndex = 21;
            this.lblgdate.Text = "G-DATE:";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPID.Location = new System.Drawing.Point(40, 94);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(50, 25);
            this.lblPID.TabIndex = 20;
            this.lblPID.Text = "PID:";
            // 
            // dtpgdate
            // 
            this.dtpgdate.Location = new System.Drawing.Point(123, 206);
            this.dtpgdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpgdate.Name = "dtpgdate";
            this.dtpgdate.Size = new System.Drawing.Size(249, 22);
            this.dtpgdate.TabIndex = 18;
            // 
            // txtpid
            // 
            this.txtpid.BackColor = System.Drawing.Color.OldLace;
            this.txtpid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(99, 91);
            this.txtpid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(273, 27);
            this.txtpid.TabIndex = 17;
            this.txtpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(55, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvpayroll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 565);
            this.panel3.TabIndex = 2;
            // 
            // dgvpayroll
            // 
            this.dgvpayroll.AllowUserToAddRows = false;
            this.dgvpayroll.AllowUserToDeleteRows = false;
            this.dgvpayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgvpid,
            this.dgvmonth,
            this.dgvgdate,
            this.dgvstatus});
            this.dgvpayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpayroll.Location = new System.Drawing.Point(0, 0);
            this.dgvpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpayroll.Name = "dgvpayroll";
            this.dgvpayroll.ReadOnly = true;
            this.dgvpayroll.RowHeadersWidth = 51;
            this.dgvpayroll.RowTemplate.Height = 24;
            this.dgvpayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpayroll.Size = new System.Drawing.Size(896, 563);
            this.dgvpayroll.TabIndex = 0;
            this.dgvpayroll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayroll_CellDoubleClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 142;
            // 
            // dgvNAME
            // 
            this.dgvNAME.DataPropertyName = "NAME";
            this.dgvNAME.HeaderText = "NAME";
            this.dgvNAME.MinimumWidth = 6;
            this.dgvNAME.Name = "dgvNAME";
            this.dgvNAME.ReadOnly = true;
            this.dgvNAME.Width = 125;
            // 
            // dgvpid
            // 
            this.dgvpid.DataPropertyName = "PID";
            this.dgvpid.HeaderText = "Payroll ID";
            this.dgvpid.MinimumWidth = 6;
            this.dgvpid.Name = "dgvpid";
            this.dgvpid.ReadOnly = true;
            this.dgvpid.Width = 150;
            // 
            // dgvmonth
            // 
            this.dgvmonth.DataPropertyName = "MONTH";
            this.dgvmonth.HeaderText = "MONTH";
            this.dgvmonth.MinimumWidth = 6;
            this.dgvmonth.Name = "dgvmonth";
            this.dgvmonth.ReadOnly = true;
            this.dgvmonth.Width = 200;
            // 
            // dgvgdate
            // 
            this.dgvgdate.DataPropertyName = "GDATE";
            this.dgvgdate.HeaderText = "GENERATE DATE";
            this.dgvgdate.MinimumWidth = 6;
            this.dgvgdate.Name = "dgvgdate";
            this.dgvgdate.ReadOnly = true;
            this.dgvgdate.Width = 200;
            // 
            // dgvstatus
            // 
            this.dgvstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvstatus.DataPropertyName = "STATUS";
            this.dgvstatus.HeaderText = "STATUS";
            this.dgvstatus.MinimumWidth = 6;
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(907, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 56);
            this.panel2.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(213, 2);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 46);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsave.Location = new System.Drawing.Point(108, 2);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 46);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Location = new System.Drawing.Point(3, 2);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(99, 46);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tlp2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 56);
            this.panel1.TabIndex = 0;
            // 
            // tlp2
            // 
            this.tlp2.BackColor = System.Drawing.SystemColors.Control;
            this.tlp2.ColumnCount = 3;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.panel7, 1, 0);
            this.tlp2.Controls.Add(this.panel6, 0, 0);
            this.tlp2.Controls.Add(this.panel5, 2, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(896, 54);
            this.tlp2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnsearch);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(110, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(101, 50);
            this.panel7.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(0, 0);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 50);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(101, 50);
            this.panel6.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 50);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtsearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(217, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 50);
            this.panel5.TabIndex = 3;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.OldLace;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(674, 48);
            this.txtsearch.TabIndex = 0;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 629);
            this.Controls.Add(this.tlpinfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.tlpinfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayroll)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpinfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.ComboBox cmbinfo;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblgdate;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DateTimePicker dtpgdate;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvpayroll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
    }
}