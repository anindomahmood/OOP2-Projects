namespace HRMS
{
    partial class DESIGNATION
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
            this.cmbdesignation = new System.Windows.Forms.ComboBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.lbldid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvdes = new System.Windows.Forms.DataGridView();
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
            this.dgvdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdesig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpinfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdes)).BeginInit();
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
            this.tlpinfo.Size = new System.Drawing.Size(1146, 710);
            this.tlpinfo.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbdesignation);
            this.panel4.Controls.Add(this.lbltitle);
            this.panel4.Controls.Add(this.txtdid);
            this.panel4.Controls.Add(this.lbldid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(749, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 644);
            this.panel4.TabIndex = 3;
            // 
            // cmbdesignation
            // 
            this.cmbdesignation.BackColor = System.Drawing.Color.OldLace;
            this.cmbdesignation.FormattingEnabled = true;
            this.cmbdesignation.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "EMPLOYEE"});
            this.cmbdesignation.Location = new System.Drawing.Point(180, 94);
            this.cmbdesignation.Name = "cmbdesignation";
            this.cmbdesignation.Size = new System.Drawing.Size(191, 24);
            this.cmbdesignation.TabIndex = 24;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitle.Location = new System.Drawing.Point(19, 94);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(155, 25);
            this.lbltitle.TabIndex = 20;
            this.lbltitle.Text = "DESIGNATION:";
            // 
            // txtdid
            // 
            this.txtdid.BackColor = System.Drawing.Color.OldLace;
            this.txtdid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdid.Location = new System.Drawing.Point(98, 39);
            this.txtdid.Name = "txtdid";
            this.txtdid.ReadOnly = true;
            this.txtdid.Size = new System.Drawing.Size(273, 27);
            this.txtdid.TabIndex = 16;
            this.txtdid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbldid
            // 
            this.lbldid.AutoSize = true;
            this.lbldid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldid.Location = new System.Drawing.Point(41, 39);
            this.lbldid.Name = "lbldid";
            this.lbldid.Size = new System.Drawing.Size(51, 25);
            this.lbldid.TabIndex = 1;
            this.lbldid.Text = "DID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvdes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 644);
            this.panel3.TabIndex = 2;
            // 
            // dgvdes
            // 
            this.dgvdes.AllowUserToAddRows = false;
            this.dgvdes.AllowUserToDeleteRows = false;
            this.dgvdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvdid,
            this.dgvdesig});
            this.dgvdes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdes.Location = new System.Drawing.Point(0, 0);
            this.dgvdes.Name = "dgvdes";
            this.dgvdes.ReadOnly = true;
            this.dgvdes.RowHeadersWidth = 51;
            this.dgvdes.RowTemplate.Height = 24;
            this.dgvdes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdes.Size = new System.Drawing.Size(738, 642);
            this.dgvdes.TabIndex = 0;
            this.dgvdes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdes_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(749, 3);
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
            this.panel1.Size = new System.Drawing.Size(740, 54);
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
            this.tlp2.Size = new System.Drawing.Size(738, 52);
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
            this.panel5.Size = new System.Drawing.Size(520, 46);
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
            this.txtsearch.Size = new System.Drawing.Size(518, 44);
            this.txtsearch.TabIndex = 0;
            // 
            // dgvdid
            // 
            this.dgvdid.DataPropertyName = "DID";
            this.dgvdid.HeaderText = "DID";
            this.dgvdid.MinimumWidth = 6;
            this.dgvdid.Name = "dgvdid";
            this.dgvdid.ReadOnly = true;
            this.dgvdid.Width = 400;
            // 
            // dgvdesig
            // 
            this.dgvdesig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvdesig.DataPropertyName = "DESIGNATION";
            this.dgvdesig.HeaderText = "DESIGNATION";
            this.dgvdesig.MinimumWidth = 6;
            this.dgvdesig.Name = "dgvdesig";
            this.dgvdesig.ReadOnly = true;
            // 
            // DESIGNATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 710);
            this.Controls.Add(this.tlpinfo);
            this.Name = "DESIGNATION";
            this.Text = "DESIGNATION";
            this.Load += new System.EventHandler(this.DESIGNATION_Load);
            this.tlpinfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdes)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbdesignation;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.Label lbldid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvdes;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdesig;
    }
}