namespace HRMS
{
    partial class RECORDS
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvrec = new System.Windows.Forms.DataGridView();
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtptill = new System.Windows.Forms.DateTimePicker();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblTill = new System.Windows.Forms.Label();
            this.lblDID = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.cmbinfo = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbdes = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDEPARTMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpinfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrec)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tlpinfo.Name = "tlpinfo";
            this.tlpinfo.RowCount = 2;
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpinfo.Size = new System.Drawing.Size(1223, 728);
            this.tlpinfo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvrec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 662);
            this.panel3.TabIndex = 2;
            // 
            // dgvrec
            // 
            this.dgvrec.AllowUserToAddRows = false;
            this.dgvrec.AllowUserToDeleteRows = false;
            this.dgvrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgvDEPARTMENT,
            this.dgvDESIGNATION,
            this.dgvRID,
            this.dgvFromDate,
            this.dgvTillDate,
            this.dgvDID,
            this.dgvDeptID});
            this.dgvrec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrec.Location = new System.Drawing.Point(0, 0);
            this.dgvrec.Name = "dgvrec";
            this.dgvrec.ReadOnly = true;
            this.dgvrec.RowHeadersWidth = 51;
            this.dgvrec.RowTemplate.Height = 24;
            this.dgvrec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrec.Size = new System.Drawing.Size(815, 660);
            this.dgvrec.TabIndex = 0;
            this.dgvrec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrec_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(826, 3);
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
            this.panel1.Size = new System.Drawing.Size(817, 54);
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
            this.tlp2.Size = new System.Drawing.Size(815, 52);
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
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtsearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(215, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(597, 46);
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
            this.txtsearch.Size = new System.Drawing.Size(595, 44);
            this.txtsearch.TabIndex = 0;
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
            // txtRID
            // 
            this.txtRID.BackColor = System.Drawing.Color.OldLace;
            this.txtRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRID.Location = new System.Drawing.Point(98, 99);
            this.txtRID.Name = "txtRID";
            this.txtRID.ReadOnly = true;
            this.txtRID.Size = new System.Drawing.Size(273, 27);
            this.txtRID.TabIndex = 17;
            this.txtRID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(98, 153);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(273, 22);
            this.dtpfrom.TabIndex = 18;
            // 
            // dtptill
            // 
            this.dtptill.Location = new System.Drawing.Point(98, 211);
            this.dtptill.Name = "dtptill";
            this.dtptill.Size = new System.Drawing.Size(273, 22);
            this.dtptill.TabIndex = 19;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRID.Location = new System.Drawing.Point(40, 97);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(50, 25);
            this.lblRID.TabIndex = 20;
            this.lblRID.Text = "RID:";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfrom.Location = new System.Drawing.Point(16, 153);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(76, 25);
            this.lblfrom.TabIndex = 21;
            this.lblfrom.Text = "FROM:";
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTill.Location = new System.Drawing.Point(32, 208);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(58, 25);
            this.lblTill.TabIndex = 22;
            this.lblTill.Text = "TILL:";
            // 
            // lblDID
            // 
            this.lblDID.AutoSize = true;
            this.lblDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDID.Location = new System.Drawing.Point(32, 263);
            this.lblDID.Name = "lblDID";
            this.lblDID.Size = new System.Drawing.Size(51, 25);
            this.lblDID.TabIndex = 25;
            this.lblDID.Text = "DID:";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldept.Location = new System.Drawing.Point(13, 315);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(90, 25);
            this.lbldept.TabIndex = 26;
            this.lbldept.Text = "DEPTID:";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbdept);
            this.panel4.Controls.Add(this.cmbdes);
            this.panel4.Controls.Add(this.cmbinfo);
            this.panel4.Controls.Add(this.lbldept);
            this.panel4.Controls.Add(this.lblDID);
            this.panel4.Controls.Add(this.lblTill);
            this.panel4.Controls.Add(this.lblfrom);
            this.panel4.Controls.Add(this.lblRID);
            this.panel4.Controls.Add(this.dtptill);
            this.panel4.Controls.Add(this.dtpfrom);
            this.panel4.Controls.Add(this.txtRID);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(826, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 662);
            this.panel4.TabIndex = 3;
            // 
            // cmbdes
            // 
            this.cmbdes.BackColor = System.Drawing.Color.OldLace;
            this.cmbdes.FormattingEnabled = true;
            this.cmbdes.Location = new System.Drawing.Point(109, 264);
            this.cmbdes.Name = "cmbdes";
            this.cmbdes.Size = new System.Drawing.Size(262, 24);
            this.cmbdes.TabIndex = 28;
            // 
            // cmbdept
            // 
            this.cmbdept.BackColor = System.Drawing.Color.OldLace;
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(109, 315);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(262, 24);
            this.cmbdept.TabIndex = 29;
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
            // dgvDEPARTMENT
            // 
            this.dgvDEPARTMENT.DataPropertyName = "Department";
            this.dgvDEPARTMENT.HeaderText = "DEPARTMENT";
            this.dgvDEPARTMENT.MinimumWidth = 6;
            this.dgvDEPARTMENT.Name = "dgvDEPARTMENT";
            this.dgvDEPARTMENT.ReadOnly = true;
            this.dgvDEPARTMENT.Width = 150;
            // 
            // dgvDESIGNATION
            // 
            this.dgvDESIGNATION.DataPropertyName = "DESIGNATION";
            this.dgvDESIGNATION.HeaderText = "DESIGNATION";
            this.dgvDESIGNATION.MinimumWidth = 6;
            this.dgvDESIGNATION.Name = "dgvDESIGNATION";
            this.dgvDESIGNATION.ReadOnly = true;
            this.dgvDESIGNATION.Width = 150;
            // 
            // dgvRID
            // 
            this.dgvRID.DataPropertyName = "RID";
            this.dgvRID.HeaderText = "RecordsID";
            this.dgvRID.MinimumWidth = 6;
            this.dgvRID.Name = "dgvRID";
            this.dgvRID.ReadOnly = true;
            this.dgvRID.Width = 125;
            // 
            // dgvFromDate
            // 
            this.dgvFromDate.DataPropertyName = "FROMDATE";
            this.dgvFromDate.HeaderText = "From Date";
            this.dgvFromDate.MinimumWidth = 6;
            this.dgvFromDate.Name = "dgvFromDate";
            this.dgvFromDate.ReadOnly = true;
            this.dgvFromDate.Width = 200;
            // 
            // dgvTillDate
            // 
            this.dgvTillDate.DataPropertyName = "TILLDATE";
            this.dgvTillDate.HeaderText = "TillDate";
            this.dgvTillDate.MinimumWidth = 6;
            this.dgvTillDate.Name = "dgvTillDate";
            this.dgvTillDate.ReadOnly = true;
            this.dgvTillDate.Width = 200;
            // 
            // dgvDID
            // 
            this.dgvDID.DataPropertyName = "DID";
            this.dgvDID.HeaderText = "DID";
            this.dgvDID.MinimumWidth = 6;
            this.dgvDID.Name = "dgvDID";
            this.dgvDID.ReadOnly = true;
            this.dgvDID.Width = 125;
            // 
            // dgvDeptID
            // 
            this.dgvDeptID.DataPropertyName = "DEPTID";
            this.dgvDeptID.HeaderText = "DEPTID";
            this.dgvDeptID.MinimumWidth = 6;
            this.dgvDeptID.Name = "dgvDeptID";
            this.dgvDeptID.ReadOnly = true;
            this.dgvDeptID.Width = 125;
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 728);
            this.Controls.Add(this.tlpinfo);
            this.Name = "RECORDS";
            this.Text = "RECORDS";
            this.Load += new System.EventHandler(this.RECORDS_Load);
            this.tlpinfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpinfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvrec;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.ComboBox cmbdes;
        private System.Windows.Forms.ComboBox cmbinfo;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblDID;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.DateTimePicker dtptill;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDEPARTMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeptID;
    }
}