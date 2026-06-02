using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRMS
{
    public partial class PaySlip : Form
    {
        public PaySlip()
        {
            InitializeComponent();
        }

        private void LoadPaySlipCommand(string SearchValue = "")
        {
            try
            {


                string query = "select eslip.*, einformation.NAME , epayroll.STATUS, (esalary.BASICSAL + esalary.HOUSE + esalary.MEDICAL )as 'NET SALARY' from einformation,epayroll,eslip,esalary where eslip.ID=einformation.ID and eslip.Id=epayroll.ID and eslip.ID=esalary.ID ";
                string role = userhelper.DESIGNATION.Trim().ToLower();

                if (role != "admin" && role != "manager")
                {

                    query += " AND eslip.ID = " + userhelper.ID;
                }
                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int SID;


                    if (int.TryParse(SearchValue, out SID))
                    {
                        query += " AND eslip.SID =" + SID;
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvslip.DefaultCellStyle.BackColor = Color.White;
                dgvslip.DefaultCellStyle.ForeColor = Color.Black;
                dgvslip.AutoGenerateColumns = false;
                dgvslip.DataSource = result.Data;
                dgvslip.Refresh();
                dgvslip.ClearSelection();
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
            cmbpid.SelectedItem = null ;
            txtslip.Text = "Auto Generated";
            dtpissue.Value = DateTime.Now;
            txtsearch.Text = " ";


        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            this.LoadPaySlipCommand();
            this.LoadInformationCommand();
            this.LoadPayrollCommand();
            btngenerate.Enabled= false;
            
            string role = userhelper.DESIGNATION.Trim().ToLower();
            if (role != "admin" && role != "manager")
            {
                btngenerate.Enabled= true;
                btndecline.Enabled = false;
                btnApproved.Enabled = false;
                btnsearch.Enabled = false;
                cmbinfo.Enabled = false;
                txtsearch.Enabled = false;
                cmbpid.Enabled = false;
            }
        }
        private void LoadInformationCommand()
        {
            var query = "select distinct einformation.* from einformation inner join epayroll on einformation.ID = epayroll.ID where epayroll.STATUS = 'Approved'";

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

        private void LoadPayrollCommand()
        {

            var query = "select * from epayroll";

            var result = DataAccess.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            cmbpid.DataSource = result.Data;
            cmbpid.DisplayMember = "PID";
            cmbpid.ValueMember = "PID";
            cmbpid.SelectedItem = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
            this.LoadPaySlipCommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadPaySlipCommand(txtsearch.Text);
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            string ID = cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
            string PID = cmbpid.SelectedValue == null ? "" : cmbpid.SelectedValue.ToString();
            string ISSUE = dtpissue.Value.ToString("yyyy-MM-dd hh:mm");

            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Error: Enter ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(PID))
            {
                MessageBox.Show("Error: Enter PInfo");
                return;
            }
            if (string.IsNullOrWhiteSpace(ISSUE))
            {
                MessageBox.Show("Error: Enter ISSUE DATE");
                return;
            }

            string query;
            if (txtslip.Text == "Auto Generated")
            {
                query = "insert into eslip Values('" + ID + "','" + PID + "','" + ISSUE + "')";
            }
            else
            {
                query = "Update eslip set ID='" + ID + "', PID='" + PID + "',ISSUE='" + ISSUE + "' Where SID=" + txtslip.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Approved Slip");
            this.LoadPaySlipCommand();
        }

        private void btndecline_Click(object sender, EventArgs e)
        {
            if (txtslip.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }


            string query = "delete from eslip where SID=" + txtslip.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Decline Success");
            this.LoadPaySlipCommand();
        }

        private void dgvslip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvslip.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgvslip.Rows[e.RowIndex].Cells["dgvID"].Value;
            txtslip.Text = dgvslip.Rows[e.RowIndex].Cells["dgvslipid"].Value.ToString();
            cmbpid.SelectedValue = dgvslip.Rows[e.RowIndex].Cells["dgvpid"].Value;
            dtpissue.Value = Convert.ToDateTime(dgvslip.Rows[e.RowIndex].Cells["dgvissue"].Value);

           
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            if (dgvslip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            var row = dgvslip.SelectedRows[0];

            string name = row.Cells["dgvname"].Value.ToString();
            string salary = row.Cells["dgvnetsal"].Value.ToString();
            string issue = row.Cells["dgvissue"].Value.ToString();

            MessageBox.Show($"Invoice Generated Successfully!\n\nName: {name}\nSalary: {salary}\nIssue Date: {issue}",
                      "Invoice",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }
    }
}
