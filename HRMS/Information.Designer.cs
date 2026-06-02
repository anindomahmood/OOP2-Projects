namespace HRMS
{
    partial class Information
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtblood = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.rdbpnl = new System.Windows.Forms.Panel();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblblood = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lvlgender = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBLOOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.rdbpnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
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
            this.tlpinfo.Name = "tlpinfo";
            this.tlpinfo.RowCount = 2;
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpinfo.Size = new System.Drawing.Size(1513, 696);
            this.tlpinfo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtpassword);
            this.panel4.Controls.Add(this.txtphone);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.txtblood);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Controls.Add(this.dtpdob);
            this.panel4.Controls.Add(this.rdbpnl);
            this.panel4.Controls.Add(this.lblpassword);
            this.panel4.Controls.Add(this.lblphone);
            this.panel4.Controls.Add(this.lblemail);
            this.panel4.Controls.Add(this.lbladdress);
            this.panel4.Controls.Add(this.lblblood);
            this.panel4.Controls.Add(this.lbldob);
            this.panel4.Controls.Add(this.lvlgender);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Controls.Add(this.lblname);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1116, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 630);
            this.panel4.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.OldLace;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(144, 488);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(223, 27);
            this.txtpassword.TabIndex = 21;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.OldLace;
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(110, 438);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(257, 27);
            this.txtphone.TabIndex = 20;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.OldLace;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(110, 375);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(257, 27);
            this.txtemail.TabIndex = 19;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.OldLace;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(140, 311);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(227, 27);
            this.txtaddress.TabIndex = 18;
            // 
            // txtblood
            // 
            this.txtblood.BackColor = System.Drawing.Color.OldLace;
            this.txtblood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtblood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtblood.Location = new System.Drawing.Point(110, 253);
            this.txtblood.Name = "txtblood";
            this.txtblood.Size = new System.Drawing.Size(257, 27);
            this.txtblood.TabIndex = 17;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.OldLace;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(94, 87);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(273, 27);
            this.txtid.TabIndex = 16;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.OldLace;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(94, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(273, 27);
            this.txtname.TabIndex = 15;
            // 
            // dtpdob
            // 
            this.dtpdob.AccessibleName = "";
            this.dtpdob.CalendarForeColor = System.Drawing.Color.OldLace;
            this.dtpdob.Location = new System.Drawing.Point(98, 194);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(269, 22);
            this.dtpdob.TabIndex = 14;
            // 
            // rdbpnl
            // 
            this.rdbpnl.BackColor = System.Drawing.Color.OldLace;
            this.rdbpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdbpnl.Controls.Add(this.rdbmale);
            this.rdbpnl.Controls.Add(this.rdbfemale);
            this.rdbpnl.Location = new System.Drawing.Point(122, 131);
            this.rdbpnl.Name = "rdbpnl";
            this.rdbpnl.Size = new System.Drawing.Size(245, 38);
            this.rdbpnl.TabIndex = 13;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbmale.Location = new System.Drawing.Point(9, 5);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(76, 24);
            this.rdbmale.TabIndex = 11;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "MALE";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbfemale.Location = new System.Drawing.Point(112, 5);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(97, 24);
            this.rdbfemale.TabIndex = 12;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "FEMALE";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Location = new System.Drawing.Point(3, 490);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(136, 25);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "PASSWORD:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblphone.Location = new System.Drawing.Point(16, 438);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(88, 25);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "PHONE:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblemail.Location = new System.Drawing.Point(16, 375);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 25);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "EMAIL:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbladdress.Location = new System.Drawing.Point(16, 313);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(114, 25);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "ADDRESS:";
            // 
            // lblblood
            // 
            this.lblblood.AutoSize = true;
            this.lblblood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblblood.Location = new System.Drawing.Point(16, 255);
            this.lblblood.Name = "lblblood";
            this.lblblood.Size = new System.Drawing.Size(88, 25);
            this.lblblood.TabIndex = 4;
            this.lblblood.Text = "BLOOD:";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldob.Location = new System.Drawing.Point(31, 194);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(61, 25);
            this.lbldob.TabIndex = 3;
            this.lbldob.Text = "DOB:";
            // 
            // lvlgender
            // 
            this.lvlgender.AutoSize = true;
            this.lvlgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlgender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlgender.Location = new System.Drawing.Point(3, 137);
            this.lvlgender.Name = "lvlgender";
            this.lvlgender.Size = new System.Drawing.Size(100, 25);
            this.lvlgender.TabIndex = 2;
            this.lvlgender.Text = "GENDER:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(55, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblname.Location = new System.Drawing.Point(16, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "NAME:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 630);
            this.panel3.TabIndex = 2;
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgvDOB,
            this.dgvBLOOD,
            this.dgvGENDER,
            this.dgvADDRESS,
            this.dgvEMAIL,
            this.dgvPHONE});
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 24;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(1105, 628);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellDoubleClick);
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
            // dgvDOB
            // 
            this.dgvDOB.DataPropertyName = "DOB";
            this.dgvDOB.HeaderText = "DOB";
            this.dgvDOB.MinimumWidth = 6;
            this.dgvDOB.Name = "dgvDOB";
            this.dgvDOB.ReadOnly = true;
            this.dgvDOB.Width = 125;
            // 
            // dgvBLOOD
            // 
            this.dgvBLOOD.DataPropertyName = "BLOOD";
            this.dgvBLOOD.HeaderText = "BLOOD";
            this.dgvBLOOD.MinimumWidth = 6;
            this.dgvBLOOD.Name = "dgvBLOOD";
            this.dgvBLOOD.ReadOnly = true;
            this.dgvBLOOD.Width = 125;
            // 
            // dgvGENDER
            // 
            this.dgvGENDER.DataPropertyName = "GENDER";
            this.dgvGENDER.HeaderText = "GENDER";
            this.dgvGENDER.MinimumWidth = 6;
            this.dgvGENDER.Name = "dgvGENDER";
            this.dgvGENDER.ReadOnly = true;
            this.dgvGENDER.Width = 125;
            // 
            // dgvADDRESS
            // 
            this.dgvADDRESS.DataPropertyName = "ADDRESS";
            this.dgvADDRESS.HeaderText = "ADDRESS";
            this.dgvADDRESS.MinimumWidth = 6;
            this.dgvADDRESS.Name = "dgvADDRESS";
            this.dgvADDRESS.ReadOnly = true;
            this.dgvADDRESS.Width = 125;
            // 
            // dgvEMAIL
            // 
            this.dgvEMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEMAIL.DataPropertyName = "EMAIL";
            this.dgvEMAIL.HeaderText = "EMAIL ID";
            this.dgvEMAIL.MinimumWidth = 6;
            this.dgvEMAIL.Name = "dgvEMAIL";
            this.dgvEMAIL.ReadOnly = true;
            // 
            // dgvPHONE
            // 
            this.dgvPHONE.DataPropertyName = "PHONE";
            this.dgvPHONE.HeaderText = "PHONE";
            this.dgvPHONE.MinimumWidth = 6;
            this.dgvPHONE.Name = "dgvPHONE";
            this.dgvPHONE.ReadOnly = true;
            this.dgvPHONE.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1116, 3);
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
            this.panel1.Size = new System.Drawing.Size(1107, 54);
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
            this.tlp2.Size = new System.Drawing.Size(1105, 52);
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
            this.panel5.Size = new System.Drawing.Size(887, 46);
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
            this.txtsearch.Size = new System.Drawing.Size(885, 44);
            this.txtsearch.TabIndex = 0;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 696);
            this.Controls.Add(this.tlpinfo);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.tlpinfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rdbpnl.ResumeLayout(false);
            this.rdbpnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtblood;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Panel rdbpnl;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblblood;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lvlgender;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBLOOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPHONE;
    }
}