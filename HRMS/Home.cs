using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
                this.lblwelcome.Text += userhelper.NAME;
            }
        }


        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void einformation_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Information form = new Information();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void eworkexperience_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            WorkExperience form = new WorkExperience();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void eeducation_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Education form = new Education();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void edepartment_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Department form = new Department();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void erecords_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            RECORDS form = new RECORDS();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void edesignation_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            DESIGNATION form = new DESIGNATION();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void esalary_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Salary form = new Salary();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void epayroll_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Payroll form = new Payroll();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
               DialogResult result = MessageBox.Show(
               "Are you sure you want to log out?",
               "Confirm Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                this.Close();


                if (this.Owner != null)
                {
                    this.Owner.Show();
                }
                else
                {
                    Login loginForm = new Login();
                    loginForm.Show();
                }
            }
        }

        private void eslip_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            PaySlip form = new PaySlip();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
