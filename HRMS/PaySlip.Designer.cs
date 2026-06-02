namespace HRMS
{
    partial class PaySlip
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndecline = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.dgvslip = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvslipid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnetsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvissue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbinfo = new System.Windows.Forms.ComboBox();
            this.lblissue = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.dtpissue = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblslip = new System.Windows.Forms.Label();
            this.txtslip = new System.Windows.Forms.TextBox();
            this.cmbpid = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tlpinfo = new System.Windows.Forms.TableLayoutPanel();
            this.btngenerate = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvslip)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tlpinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(614, 48);
            this.txtsearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lavender;
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
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Lavender;
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
            this.tlp2.Size = new System.Drawing.Size(836, 54);
            this.tlp2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtsearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(217, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(616, 50);
            this.panel5.TabIndex = 3;
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
            this.panel1.Size = new System.Drawing.Size(838, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndecline);
            this.panel2.Controls.Add(this.btnApproved);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(847, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 56);
            this.panel2.TabIndex = 1;
            // 
            // btndecline
            // 
            this.btndecline.BackColor = System.Drawing.Color.Maroon;
            this.btndecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndecline.Location = new System.Drawing.Point(201, 3);
            this.btndecline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndecline.Name = "btndecline";
            this.btndecline.Size = new System.Drawing.Size(171, 46);
            this.btndecline.TabIndex = 3;
            this.btndecline.Text = "Decline";
            this.btndecline.UseVisualStyleBackColor = false;
            this.btndecline.Click += new System.EventHandler(this.btndecline_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.Color.PaleGreen;
            this.btnApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproved.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApproved.Location = new System.Drawing.Point(21, 3);
            this.btnApproved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(171, 46);
            this.btnApproved.TabIndex = 2;
            this.btnApproved.Text = "Approved";
            this.btnApproved.UseVisualStyleBackColor = false;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // dgvslip
            // 
            this.dgvslip.AllowUserToAddRows = false;
            this.dgvslip.AllowUserToDeleteRows = false;
            this.dgvslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvslip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvslipid,
            this.dgvpid,
            this.dgvname,
            this.dgvnetsal,
            this.dgvissue,
            this.dgvstatus});
            this.dgvslip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvslip.Location = new System.Drawing.Point(0, 0);
            this.dgvslip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvslip.Name = "dgvslip";
            this.dgvslip.ReadOnly = true;
            this.dgvslip.RowHeadersWidth = 51;
            this.dgvslip.RowTemplate.Height = 24;
            this.dgvslip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvslip.Size = new System.Drawing.Size(836, 602);
            this.dgvslip.TabIndex = 0;
            this.dgvslip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvslip_CellDoubleClick);
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
            // dgvslipid
            // 
            this.dgvslipid.DataPropertyName = "SID";
            this.dgvslipid.HeaderText = "SLIP NO";
            this.dgvslipid.MinimumWidth = 6;
            this.dgvslipid.Name = "dgvslipid";
            this.dgvslipid.ReadOnly = true;
            this.dgvslipid.Width = 125;
            // 
            // dgvpid
            // 
            this.dgvpid.DataPropertyName = "PID";
            this.dgvpid.HeaderText = "PAYROLL";
            this.dgvpid.MinimumWidth = 6;
            this.dgvpid.Name = "dgvpid";
            this.dgvpid.ReadOnly = true;
            this.dgvpid.Width = 125;
            // 
            // dgvname
            // 
            this.dgvname.DataPropertyName = "NAME";
            this.dgvname.HeaderText = "NAME";
            this.dgvname.MinimumWidth = 6;
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            this.dgvname.Width = 141;
            // 
            // dgvnetsal
            // 
            this.dgvnetsal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvnetsal.DataPropertyName = "NET SALARY";
            this.dgvnetsal.HeaderText = "SALARY";
            this.dgvnetsal.MinimumWidth = 6;
            this.dgvnetsal.Name = "dgvnetsal";
            this.dgvnetsal.ReadOnly = true;
            // 
            // dgvissue
            // 
            this.dgvissue.DataPropertyName = "ISSUE";
            this.dgvissue.HeaderText = "ISSUE DATE";
            this.dgvissue.MinimumWidth = 6;
            this.dgvissue.Name = "dgvissue";
            this.dgvissue.ReadOnly = true;
            this.dgvissue.Width = 125;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "STATUS";
            this.dgvstatus.HeaderText = "STATUS";
            this.dgvstatus.MinimumWidth = 6;
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            this.dgvstatus.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvslip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 604);
            this.panel3.TabIndex = 2;
            // 
            // cmbinfo
            // 
            this.cmbinfo.BackColor = System.Drawing.Color.Lavender;
            this.cmbinfo.FormattingEnabled = true;
            this.cmbinfo.Location = new System.Drawing.Point(99, 41);
            this.cmbinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbinfo.Name = "cmbinfo";
            this.cmbinfo.Size = new System.Drawing.Size(273, 24);
            this.cmbinfo.TabIndex = 25;
            // 
            // lblissue
            // 
            this.lblissue.AutoSize = true;
            this.lblissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblissue.Location = new System.Drawing.Point(16, 204);
            this.lblissue.Name = "lblissue";
            this.lblissue.Size = new System.Drawing.Size(78, 25);
            this.lblissue.TabIndex = 21;
            this.lblissue.Text = "ISSUE:";
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
            // dtpissue
            // 
            this.dtpissue.Location = new System.Drawing.Point(114, 206);
            this.dtpissue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpissue.Name = "dtpissue";
            this.dtpissue.Size = new System.Drawing.Size(258, 22);
            this.dtpissue.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btngenerate);
            this.panel4.Controls.Add(this.lblslip);
            this.panel4.Controls.Add(this.txtslip);
            this.panel4.Controls.Add(this.cmbpid);
            this.panel4.Controls.Add(this.cmbinfo);
            this.panel4.Controls.Add(this.lblissue);
            this.panel4.Controls.Add(this.lblPID);
            this.panel4.Controls.Add(this.dtpissue);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(847, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 604);
            this.panel4.TabIndex = 3;
            // 
            // lblslip
            // 
            this.lblslip.AutoSize = true;
            this.lblslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblslip.Location = new System.Drawing.Point(29, 145);
            this.lblslip.Name = "lblslip";
            this.lblslip.Size = new System.Drawing.Size(61, 25);
            this.lblslip.TabIndex = 30;
            this.lblslip.Text = "SLIP:";
            // 
            // txtslip
            // 
            this.txtslip.BackColor = System.Drawing.Color.Lavender;
            this.txtslip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslip.Location = new System.Drawing.Point(99, 145);
            this.txtslip.Name = "txtslip";
            this.txtslip.ReadOnly = true;
            this.txtslip.Size = new System.Drawing.Size(273, 27);
            this.txtslip.TabIndex = 29;
            this.txtslip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbpid
            // 
            this.cmbpid.BackColor = System.Drawing.Color.Lavender;
            this.cmbpid.FormattingEnabled = true;
            this.cmbpid.Location = new System.Drawing.Point(99, 94);
            this.cmbpid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbpid.Name = "cmbpid";
            this.cmbpid.Size = new System.Drawing.Size(273, 24);
            this.cmbpid.TabIndex = 28;
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
            this.tlpinfo.Size = new System.Drawing.Size(1244, 668);
            this.tlpinfo.TabIndex = 3;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btngenerate.Location = new System.Drawing.Point(287, 242);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(85, 27);
            this.btngenerate.TabIndex = 31;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // PaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 668);
            this.Controls.Add(this.tlpinfo);
            this.Name = "PaySlip";
            this.Text = "PaySlip";
            this.Load += new System.EventHandler(this.PaySlip_Load);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvslip)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tlpinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvslip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbinfo;
        private System.Windows.Forms.Label lblissue;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DateTimePicker dtpissue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbpid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TableLayoutPanel tlpinfo;
        private System.Windows.Forms.Label lblslip;
        private System.Windows.Forms.TextBox txtslip;
        private System.Windows.Forms.Button btndecline;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvslipid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnetsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvissue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
        private System.Windows.Forms.Button btngenerate;
    }
}