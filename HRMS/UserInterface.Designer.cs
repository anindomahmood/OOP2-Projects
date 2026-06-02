namespace HRMS
{
    partial class UserInterface
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.eslip = new System.Windows.Forms.Button();
            this.epayroll = new System.Windows.Forms.Button();
            this.esalary = new System.Windows.Forms.Button();
            this.erecords = new System.Windows.Forms.Button();
            this.eeducation = new System.Windows.Forms.Button();
            this.eworkexperience = new System.Windows.Forms.Button();
            this.einformation = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlmenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmenu.Controls.Add(this.btnLogout);
            this.pnlmenu.Controls.Add(this.lblwelcome);
            this.pnlmenu.Controls.Add(this.eslip);
            this.pnlmenu.Controls.Add(this.epayroll);
            this.pnlmenu.Controls.Add(this.esalary);
            this.pnlmenu.Controls.Add(this.erecords);
            this.pnlmenu.Controls.Add(this.eeducation);
            this.pnlmenu.Controls.Add(this.eworkexperience);
            this.pnlmenu.Controls.Add(this.einformation);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmenu.Location = new System.Drawing.Point(3, 3);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(194, 553);
            this.pnlmenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Lavender;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(22, 481);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 36);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.SystemColors.Window;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblwelcome.Location = new System.Drawing.Point(19, 30);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(92, 20);
            this.lblwelcome.TabIndex = 10;
            this.lblwelcome.Text = "Welcome ";
            // 
            // eslip
            // 
            this.eslip.BackColor = System.Drawing.Color.PaleGreen;
            this.eslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eslip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eslip.Location = new System.Drawing.Point(22, 424);
            this.eslip.Name = "eslip";
            this.eslip.Size = new System.Drawing.Size(149, 36);
            this.eslip.TabIndex = 9;
            this.eslip.Text = "Slip";
            this.eslip.UseVisualStyleBackColor = false;
            this.eslip.Click += new System.EventHandler(this.eslip_Click);
            // 
            // epayroll
            // 
            this.epayroll.BackColor = System.Drawing.Color.PaleGreen;
            this.epayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.epayroll.Location = new System.Drawing.Point(22, 367);
            this.epayroll.Name = "epayroll";
            this.epayroll.Size = new System.Drawing.Size(149, 36);
            this.epayroll.TabIndex = 8;
            this.epayroll.Text = "Payroll";
            this.epayroll.UseVisualStyleBackColor = false;
            this.epayroll.Click += new System.EventHandler(this.epayroll_Click);
            // 
            // esalary
            // 
            this.esalary.BackColor = System.Drawing.Color.PaleGreen;
            this.esalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esalary.Location = new System.Drawing.Point(23, 310);
            this.esalary.Name = "esalary";
            this.esalary.Size = new System.Drawing.Size(149, 36);
            this.esalary.TabIndex = 7;
            this.esalary.Text = "Salary";
            this.esalary.UseVisualStyleBackColor = false;
            this.esalary.Click += new System.EventHandler(this.esalary_Click);
            // 
            // erecords
            // 
            this.erecords.BackColor = System.Drawing.Color.PaleGreen;
            this.erecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.erecords.Location = new System.Drawing.Point(23, 253);
            this.erecords.Name = "erecords";
            this.erecords.Size = new System.Drawing.Size(149, 36);
            this.erecords.TabIndex = 5;
            this.erecords.Text = "Records";
            this.erecords.UseVisualStyleBackColor = false;
            this.erecords.Click += new System.EventHandler(this.erecords_Click);
            // 
            // eeducation
            // 
            this.eeducation.BackColor = System.Drawing.Color.PaleGreen;
            this.eeducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eeducation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eeducation.Location = new System.Drawing.Point(22, 196);
            this.eeducation.Name = "eeducation";
            this.eeducation.Size = new System.Drawing.Size(149, 36);
            this.eeducation.TabIndex = 3;
            this.eeducation.Text = "Education";
            this.eeducation.UseVisualStyleBackColor = false;
            this.eeducation.Click += new System.EventHandler(this.eeducation_Click);
            // 
            // eworkexperience
            // 
            this.eworkexperience.BackColor = System.Drawing.Color.PaleGreen;
            this.eworkexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eworkexperience.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eworkexperience.Location = new System.Drawing.Point(23, 139);
            this.eworkexperience.Name = "eworkexperience";
            this.eworkexperience.Size = new System.Drawing.Size(149, 36);
            this.eworkexperience.TabIndex = 2;
            this.eworkexperience.Text = "Work Experience";
            this.eworkexperience.UseVisualStyleBackColor = false;
            this.eworkexperience.Click += new System.EventHandler(this.eworkexperience_Click);
            // 
            // einformation
            // 
            this.einformation.BackColor = System.Drawing.Color.PaleGreen;
            this.einformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.einformation.Location = new System.Drawing.Point(22, 82);
            this.einformation.Name = "einformation";
            this.einformation.Size = new System.Drawing.Size(149, 36);
            this.einformation.TabIndex = 1;
            this.einformation.Text = "Information";
            this.einformation.UseVisualStyleBackColor = false;
            this.einformation.Click += new System.EventHandler(this.einformation_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(203, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(860, 553);
            this.pnlMain.TabIndex = 0;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button einformation;
        private System.Windows.Forms.Button eworkexperience;
        private System.Windows.Forms.Button eeducation;
        private System.Windows.Forms.Button erecords;
        private System.Windows.Forms.Button esalary;
        private System.Windows.Forms.Button epayroll;
        private System.Windows.Forms.Button eslip;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnLogout;
    }
}