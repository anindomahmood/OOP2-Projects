namespace HRMS
{
    partial class Education
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
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblEXP = new System.Windows.Forms.Label();
            this.txteid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgveducation = new System.Windows.Forms.DataGridView();
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
            this.cmbinfo = new System.Windows.Forms.ComboBox();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgveid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpinfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveducation)).BeginInit();
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
            this.tlpinfo.Size = new System.Drawing.Size(1354, 678);
            this.tlpinfo.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbinfo);
            this.panel4.Controls.Add(this.cmbtype);
            this.panel4.Controls.Add(this.lbltype);
            this.panel4.Controls.Add(this.lblEXP);
            this.panel4.Controls.Add(this.txteid);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(957, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 612);
            this.panel4.TabIndex = 3;
            // 
            // cmbtype
            // 
            this.cmbtype.BackColor = System.Drawing.Color.OldLace;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "SSC",
            "HSC",
            "BA",
            "BSc",
            "BBA",
            "MA",
            "MSS",
            "MSc",
            "PhD",
            ""});
            this.cmbtype.Location = new System.Drawing.Point(98, 146);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(273, 24);
            this.cmbtype.TabIndex = 24;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltype.Location = new System.Drawing.Point(22, 146);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(70, 25);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "TYPE:";
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEXP.Location = new System.Drawing.Point(42, 93);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(50, 25);
            this.lblEXP.TabIndex = 20;
            this.lblEXP.Text = "EID:";
            // 
            // txteid
            // 
            this.txteid.BackColor = System.Drawing.Color.OldLace;
            this.txteid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txteid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteid.Location = new System.Drawing.Point(98, 92);
            this.txteid.Name = "txteid";
            this.txteid.ReadOnly = true;
            this.txteid.Size = new System.Drawing.Size(273, 27);
            this.txteid.TabIndex = 17;
            this.txteid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel3.Controls.Add(this.dgveducation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 612);
            this.panel3.TabIndex = 2;
            // 
            // dgveducation
            // 
            this.dgveducation.AllowUserToAddRows = false;
            this.dgveducation.AllowUserToDeleteRows = false;
            this.dgveducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNAME,
            this.dgveid,
            this.dgvtype});
            this.dgveducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgveducation.Location = new System.Drawing.Point(0, 0);
            this.dgveducation.Name = "dgveducation";
            this.dgveducation.ReadOnly = true;
            this.dgveducation.RowHeadersWidth = 51;
            this.dgveducation.RowTemplate.Height = 24;
            this.dgveducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgveducation.Size = new System.Drawing.Size(946, 610);
            this.dgveducation.TabIndex = 0;
            this.dgveducation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveducation_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(957, 3);
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
            this.panel1.Size = new System.Drawing.Size(948, 54);
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
            this.tlp2.Size = new System.Drawing.Size(946, 52);
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
            this.panel5.Size = new System.Drawing.Size(728, 46);
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
            this.txtsearch.Size = new System.Drawing.Size(726, 44);
            this.txtsearch.TabIndex = 0;
            // 
            // cmbinfo
            // 
            this.cmbinfo.BackColor = System.Drawing.Color.OldLace;
            this.cmbinfo.FormattingEnabled = true;
            this.cmbinfo.Location = new System.Drawing.Point(98, 41);
            this.cmbinfo.Name = "cmbinfo";
            this.cmbinfo.Size = new System.Drawing.Size(273, 24);
            this.cmbinfo.TabIndex = 26;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 200;
            // 
            // dgvNAME
            // 
            this.dgvNAME.DataPropertyName = "NAME";
            this.dgvNAME.HeaderText = "NAME";
            this.dgvNAME.MinimumWidth = 6;
            this.dgvNAME.Name = "dgvNAME";
            this.dgvNAME.ReadOnly = true;
            this.dgvNAME.Width = 300;
            // 
            // dgveid
            // 
            this.dgveid.DataPropertyName = "EID";
            this.dgveid.HeaderText = "EDUCATION ID";
            this.dgveid.MinimumWidth = 6;
            this.dgveid.Name = "dgveid";
            this.dgveid.ReadOnly = true;
            this.dgveid.Width = 200;
            // 
            // dgvtype
            // 
            this.dgvtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtype.DataPropertyName = "TYPE";
            this.dgvtype.HeaderText = "TYPE";
            this.dgvtype.MinimumWidth = 6;
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 678);
            this.Controls.Add(this.tlpinfo);
            this.Name = "Education";
            this.Text = "Education";
            this.Load += new System.EventHandler(this.Education_Load);
            this.tlpinfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgveducation)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgveducation;
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
        private System.Windows.Forms.ComboBox cmbinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgveid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtype;
    }
}