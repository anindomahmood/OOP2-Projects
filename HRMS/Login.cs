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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.lblerror.Visible = false;
            string ID = txtid.Text.Trim();
           
            string PASSWORD = txtpassword.Text.Trim();


            var query = "SELECT e.NAME, d.DESIGNATION " +
                        "FROM einformation e " +
                        "JOIN erecords r ON e.ID = r.ID " +
                        "JOIN edesignation d ON r.DID = d.DID " +
                        "WHERE e.ID = " + ID +
                        " AND e.PASSWORD = '" + PASSWORD + "'";

            var result = DataAccess.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            if (result.Data.Rows.Count != 1)
            {
                this.lblerror.Visible = true;
                return;
            }

            userhelper.ID = ID;
            userhelper.NAME = result.Data.Rows[0]["NAME"].ToString();
            userhelper.DESIGNATION = result.Data.Rows[0]["DESIGNATION"].ToString();

         
            string role = userhelper.DESIGNATION.Trim().ToLower();
            if (role == "admin" || role == "manager")
            {
                Home home = new Home();
                home.Show(this);
                return;
            }
            else
            {
                UserInterface user = new UserInterface();
                user.Show(this);
                return;
            }


        }

        private void passview_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar)
            {
                txtpassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;

            }
        }

        
    }
}
