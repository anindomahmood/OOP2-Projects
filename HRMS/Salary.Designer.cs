namespace HRMS
{
    partial class Salary
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
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
            this.dgvsalary = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvslrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmedical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgveft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgveftill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpinfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblmedical = new System.Windows.Forms.Label();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.txthouse = new System.Windows.Forms.TextBox();
            this.lblhouse = new System.Windows.Forms.Label();
            this.txtbasic = new System.Windows.Forms.TextBox();
            this.lblbasicsal = new System.Windows.Forms.Label();
            this.cmbinfo = new System.Windows.Forms.ComboBox();
            this.lblTill = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblSLRID = new System.Windows.Forms.Label();
            this.dtptill = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.txtslrid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).BeginInit();
            this.tlpinfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtsearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(215, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(678, 46);
            this.panel5.TabIndex = 3;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.OldLace;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(676, 44);
            this.txtsearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(907, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 54);
            this.panel2.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(213, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 46);
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
            this.btnsave.Location = new System.Drawing.Point(108, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 46);
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
            this.btnreset.Location = new System.Drawing.Point(3, 3);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(98, 46);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 54);
            this.panel1.TabIndex = 0;
            // 
            // tlp2
            // 
            this.tlp2.BackColor = System.Drawing.SystemColors.Control;
            this.tlp2.ColumnCount = 3;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.panel7, 1, 0);
            this.tlp2.Controls.Add(this.panel6, 0, 0);
            this.tlp2.Controls.Add(this.panel5, 2, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(896, 52);
            this.tlp2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnsearch);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(109, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 46);
            this.panel7.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(0, 0);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 46);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 46);
            this.panel6.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 46);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvsalary
            // 
            this.dgvsalary.AllowUserToAddRows = false;
            this.dgvsalary.AllowUserToDeleteRows = false;
            this.dgvsalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgvslrID,
            this.dgvbasic,
            this.dgvhouse,
            this.dgvmedical,
            this.dgveft,
            this.dgveftill});
            this.dgvsalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsalary.Location = new System.Drawing.Point(0, 0);
            this.dgvsalary.Name = "dgvsalary";
            this.dgvsalary.ReadOnly = true;
            this.dgvsalary.RowHeadersWidth = 51;
            this.dgvsalary.RowTemplate.Height = 24;
            this.dgvsalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalary.Size = new System.Drawing.Size(896, 621);
            this.dgvsalary.TabIndex = 0;
            this.dgvsalary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalary_CellDoubleClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 125;
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
            // dgvslrID
            // 
            this.dgvslrID.DataPropertyName = "SLRID";
            this.dgvslrID.HeaderText = "SaL ID";
            this.dgvslrID.MinimumWidth = 6;
            this.dgvslrID.Name = "dgvslrID";
            this.dgvslrID.ReadOnly = true;
            this.dgvslrID.Width = 125;
            // 
            // dgvbasic
            // 
            this.dgvbasic.DataPropertyName = "BASICSAL";
            this.dgvbasic.HeaderText = "B SALARY";
            this.dgvbasic.MinimumWidth = 6;
            this.dgvbasic.Name = "dgvbasic";
            this.dgvbasic.ReadOnly = true;
            this.dgvbasic.Width = 125;
            // 
            // dgvhouse
            // 
            this.dgvhouse.DataPropertyName = "HOUSE";
            this.dgvhouse.HeaderText = "HOUSE";
            this.dgvhouse.MinimumWidth = 6;
            this.dgvhouse.Name = "dgvhouse";
            this.dgvhouse.ReadOnly = true;
            this.dgvhouse.Width = 125;
            // 
            // dgvmedical
            // 
            this.dgvmedical.DataPropertyName = "MEDICAL";
            this.dgvmedical.HeaderText = "MEDICAL";
            this.dgvmedical.MinimumWidth = 6;
            this.dgvmedical.Name = "dgvmedical";
            this.dgvmedical.ReadOnly = true;
            this.dgvmedical.Width = 125;
            // 
            // dgveft
            // 
            this.dgveft.DataPropertyName = "EFTFROM";
            this.dgveft.HeaderText = "FROM";
            this.dgveft.MinimumWidth = 6;
            this.dgveft.Name = "dgveft";
            this.dgveft.ReadOnly = true;
            this.dgveft.Width = 125;
            // 
            // dgveftill
            // 
            this.dgveftill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgveftill.DataPropertyName = "EFTILL";
            this.dgveftill.HeaderText = "TILL";
            this.dgveftill.MinimumWidth = 6;
            this.dgveftill.Name = "dgveftill";
            this.dgveftill.ReadOnly = true;
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
            this.tlpinfo.Name = "tlpinfo";
            this.tlpinfo.RowCount = 2;
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpinfo.Size = new System.Drawing.Size(1304, 689);
            this.tlpinfo.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblmedical);
            this.panel4.Controls.Add(this.txtmed);
            this.panel4.Controls.Add(this.txthouse);
            this.panel4.Controls.Add(this.lblhouse);
            this.panel4.Controls.Add(this.txtbasic);
            this.panel4.Controls.Add(this.lblbasicsal);
            this.panel4.Controls.Add(this.cmbinfo);
            this.panel4.Controls.Add(this.lblTill);
            this.panel4.Controls.Add(this.lblfrom);
            this.panel4.Controls.Add(this.lblSLRID);
            this.panel4.Controls.Add(this.dtptill);
            this.panel4.Controls.Add(this.dtpfrom);
            this.panel4.Controls.Add(this.txtslrid);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(907, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 623);
            this.panel4.TabIndex = 3;
            // 
            // lblmedical
            // 
            this.lblmedical.AutoSize = true;
            this.lblmedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedical.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmedical.Location = new System.Drawing.Point(12, 218);
            this.lblmedical.Name = "lblmedical";
            this.lblmedical.Size = new System.Drawing.Size(107, 25);
            this.lblmedical.TabIndex = 33;
            this.lblmedical.Text = "MEDICAL:";
            // 
            // txtmed
            // 
            this.txtmed.BackColor = System.Drawing.Color.OldLace;
            this.txtmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmed.Location = new System.Drawing.Point(134, 216);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(237, 27);
            this.txtmed.TabIndex = 32;
            this.txtmed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthouse
            // 
            this.txthouse.BackColor = System.Drawing.Color.OldLace;
            this.txthouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthouse.Location = new System.Drawing.Point(134, 157);
            this.txthouse.Name = "txthouse";
            this.txthouse.Size = new System.Drawing.Size(237, 27);
            this.txthouse.TabIndex = 31;
            this.txthouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblhouse
            // 
            this.lblhouse.AutoSize = true;
            this.lblhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblhouse.Location = new System.Drawing.Point(30, 159);
            this.lblhouse.Name = "lblhouse";
            this.lblhouse.Size = new System.Drawing.Size(89, 25);
            this.lblhouse.TabIndex = 30;
            this.lblhouse.Text = "HOUSE:";
            // 
            // txtbasic
            // 
            this.txtbasic.BackColor = System.Drawing.Color.OldLace;
            this.txtbasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasic.Location = new System.Drawing.Point(134, 99);
            this.txtbasic.Name = "txtbasic";
            this.txtbasic.Size = new System.Drawing.Size(237, 27);
            this.txtbasic.TabIndex = 29;
            this.txtbasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblbasicsal
            // 
            this.lblbasicsal.AutoSize = true;
            this.lblbasicsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasicsal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbasicsal.Location = new System.Drawing.Point(5, 101);
            this.lblbasicsal.Name = "lblbasicsal";
            this.lblbasicsal.Size = new System.Drawing.Size(123, 25);
            this.lblbasicsal.TabIndex = 28;
            this.lblbasicsal.Text = "BASIC SAL:";
            // 
            // cmbinfo
            // 
            this.cmbinfo.BackColor = System.Drawing.Color.OldLace;
            this.cmbinfo.FormattingEnabled = true;
            this.cmbinfo.Location = new System.Drawing.Point(98, 41);
            this.cmbinfo.Name = "cmbinfo";
            this.cmbinfo.Size = new System.Drawing.Size(273, 24);
            this.cmbinfo.TabIndex = 27;
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTill.Location = new System.Drawing.Point(30, 387);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(58, 25);
            this.lblTill.TabIndex = 22;
            this.lblTill.Text = "TILL:";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfrom.Location = new System.Drawing.Point(13, 335);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(76, 25);
            this.lblfrom.TabIndex = 21;
            this.lblfrom.Text = "FROM:";
            // 
            // lblSLRID
            // 
            this.lblSLRID.AutoSize = true;
            this.lblSLRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLRID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSLRID.Location = new System.Drawing.Point(13, 275);
            this.lblSLRID.Name = "lblSLRID";
            this.lblSLRID.Size = new System.Drawing.Size(75, 25);
            this.lblSLRID.TabIndex = 20;
            this.lblSLRID.Text = "SLRID:";
            // 
            // dtptill
            // 
            this.dtptill.Location = new System.Drawing.Point(98, 389);
            this.dtptill.Name = "dtptill";
            this.dtptill.Size = new System.Drawing.Size(273, 22);
            this.dtptill.TabIndex = 19;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(98, 338);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(273, 22);
            this.dtpfrom.TabIndex = 18;
            // 
            // txtslrid
            // 
            this.txtslrid.BackColor = System.Drawing.Color.OldLace;
            this.txtslrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtslrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslrid.Location = new System.Drawing.Point(98, 273);
            this.txtslrid.Name = "txtslrid";
            this.txtslrid.ReadOnly = true;
            this.txtslrid.Size = new System.Drawing.Size(273, 27);
            this.txtslrid.TabIndex = 17;
            this.txtslrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel3.Controls.Add(this.dgvsalary);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 623);
            this.panel3.TabIndex = 2;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 689);
            this.Controls.Add(this.tlpinfo);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).EndInit();
            this.tlpinfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtsearch;
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
        private System.Windows.Forms.DataGridView dgvsalary;
        private System.Windows.Forms.TableLayoutPanel tlpinfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbasicsal;
        private System.Windows.Forms.ComboBox cmbinfo;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblSLRID;
        private System.Windows.Forms.DateTimePicker dtptill;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.TextBox txtslrid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblmedical;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.TextBox txthouse;
        private System.Windows.Forms.Label lblhouse;
        private System.Windows.Forms.TextBox txtbasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvslrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmedical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgveft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgveftill;
    }
}