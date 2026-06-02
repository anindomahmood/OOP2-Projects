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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }
        private void LoadPayrollCommand(string SearchValue = "")
        {
            try
            {


                string query = "select epayroll.*, einformation.NAME from epayroll inner join einformation on einformation.ID = epayroll.ID ";
                string role = userhelper.DESIGNATION.Trim().ToLower();

                if (role != "admin" && role != "manager")
                {

                    query += " WHERE epayroll.ID = " + userhelper.ID;
                }
                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int PID;


                    if (int.TryParse(SearchValue, out PID))
                    {
                        query += " WHERE epayroll.PID = " + PID + " OR epayroll.MONTH LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE epayroll.MONTH LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvpayroll.DefaultCellStyle.BackColor = Color.White;
                dgvpayroll.DefaultCellStyle.ForeColor = Color.Black;
                dgvpayroll.AutoGenerateColumns = false;
                dgvpayroll.DataSource = result.Data;
                dgvpayroll.Refresh();
                dgvpayroll.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       
        private void Resetcommand()
        {
            cmbinfo.SelectedItem = null; ;
            txtpid.Text = "Auto Generated";
            dtpgdate.Value = DateTime.Now;
            cmbmonth.SelectedItem = null;
            cmbstatus.SelectedItem = null;
            txtsearch.Text = " ";


        }
        private void Payroll_Load(object sender, EventArgs e)
        {
            this.LoadPayrollCommand();
            this.LoadInformationCommand();
            string role = userhelper.DESIGNATION.Trim().ToLower();
            if (role != "admin" && role != "manager")
            {
                btndelete.Enabled = false;
                btnsave.Enabled = false;
                btnsearch.Enabled = false;
                cmbinfo.Enabled = false;
                txtsearch.Enabled = false;
            }
        }
        private void LoadInformationCommand()
        {
            var query = "select distinct einformation.* from einformation inner join eworkexperience on einformation.ID = eworkexperience.ID where eworkexperience.STATUS = 'Active'";

            var result = DataAccess.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            cmbinfo.DataSource = result.Data;
            cmbinfo.DisplayMember = "NAME";
            cmbinfo.ValueMember = "ID";
            cmbinfo.SelectedItem = null;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadPayrollCommand(txtsearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadPayrollCommand();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ID = cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
            string GDATE = dtpgdate.Value.ToString("yyyy-MM-dd hh:mm");
            string MONTH = cmbmonth.SelectedItem == null ? "" : cmbmonth.SelectedItem.ToString();
            string STATUS = cmbstatus.SelectedItem == null ? "" : cmbstatus.SelectedItem.ToString();



            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Error: Enter ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(GDATE))
            {
                MessageBox.Show("Error: Enter GDATE");
                return;
            }
            if (string.IsNullOrWhiteSpace(MONTH))
            {
                MessageBox.Show("Error: Enter MONTH");
                return;
            }
            if (string.IsNullOrWhiteSpace(STATUS))
            {
                MessageBox.Show("Error: Enter STATUS");
                return;
            }




            string query;
            if (txtpid.Text == "Auto Generated")
            {
                query = "insert into epayroll Values('" + ID + "','" + MONTH + "','" + GDATE + "', '" + STATUS + "')";
            }
            else
            {
                query = "Update epayroll set ID='" + ID + "', MONTH='" + MONTH + "',GDATE='" + GDATE + "', STATUS='" + STATUS + "' Where PID=" + txtpid.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadPayrollCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtpid.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }


            string query = "delete from epayroll where PID=" + txtpid.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadPayrollCommand();
        }

        private void dgvpayroll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvpayroll.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgvpayroll.Rows[e.RowIndex].Cells["dgvID"].Value;
            txtpid.Text = dgvpayroll.Rows[e.RowIndex].Cells["dgvpid"].Value.ToString();
            dtpgdate.Value = Convert.ToDateTime(dgvpayroll.Rows[e.RowIndex].Cells["dgvgdate"].Value);
            cmbstatus.Text = dgvpayroll.Rows[e.RowIndex].Cells["dgvstatus"].Value.ToString();
            cmbmonth.Text = dgvpayroll.Rows[e.RowIndex].Cells["dgvmonth"].Value.ToString();
        }
    }
}
