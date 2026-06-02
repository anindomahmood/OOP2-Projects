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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        private void LoadsalCommand(string SearchValue = "")
        {
            try
            {


                string query = "select esalary.*, einformation.NAME from esalary inner join einformation on einformation.ID = esalary.ID ";
                string role = userhelper.DESIGNATION.Trim().ToLower();

                if (role != "admin" && role != "manager")
                {

                    query += " WHERE esalary.ID = " + userhelper.ID;
                }
                if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int SLRID;


                    if (int.TryParse(SearchValue, out SLRID))
                    {
                        query += " WHERE esalary.SLRID = " + SLRID + " OR einformation.NAME LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE einformation.NAME LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvsalary.DefaultCellStyle.BackColor = Color.White;
                dgvsalary.DefaultCellStyle.ForeColor = Color.Black;
                dgvsalary.AutoGenerateColumns = false;
                dgvsalary.DataSource = result.Data;
                dgvsalary.Refresh();
                dgvsalary.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void Salary_Load(object sender, EventArgs e)
        {
            this.LoadsalCommand();
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
            var query = "select * from einformation";
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
        private void Resetcommand()
        {
            cmbinfo.SelectedItem = null;
            txtslrid.Text = "Auto Generated";
            dtpfrom.Value = DateTime.Now;
            dtptill.Value = DateTime.Now;
            txtmed.Text = " ";
            txtbasic.Text = " ";
            txthouse.Text = " ";
            txtsearch.Text = " ";


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadsalCommand(txtsearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadsalCommand();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ID = cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
            string FROMDATE = dtpfrom.Value.ToString("yyyy-MM-dd hh:mm");
            string TILLDATE = dtptill.Value.ToString("yyyy-MM-dd hh:mm");
            string BASICSAL = txtbasic.Text.ToString();
            string HOUSE = txthouse.Text.ToString();
            string MEDICAL = txtmed.Text.ToString();


            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Error: Enter ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(FROMDATE))
            {
                MessageBox.Show("Error: Enter FROMDATE");
                return;
            }
            if (string.IsNullOrWhiteSpace(TILLDATE))
            {
                MessageBox.Show("Error: Enter TILLDATE");
                return;
            }
            if (string.IsNullOrWhiteSpace(BASICSAL))
            {
                MessageBox.Show("Error: Enter BASICSAL");
                return;
            }
            if (string.IsNullOrWhiteSpace(HOUSE))
            {
                MessageBox.Show("Error: Enter HOUSE");
                return;
            }
            if (string.IsNullOrWhiteSpace(MEDICAL))
            {
                MessageBox.Show("Error: Enter MEDICAL");
                return;
            }



            string query;
            if (txtslrid.Text == "Auto Generated")
            {
                query = "insert into esalary Values('" + ID + "','" + BASICSAL + "','" + HOUSE + "', '" + MEDICAL + "','" + FROMDATE + "','" + TILLDATE + "')";
            }
            else
            {
                query = "Update esalary set ID='" + ID + "', BASICSAL='" + BASICSAL + "',HOUSE='" + HOUSE + "', MEDICAL='" + MEDICAL + "', EFTFROM='" + FROMDATE + "',EFTILL='" + TILLDATE + "' Where SLRID=" + txtslrid.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadsalCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtslrid.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }


            string query = "delete from esalary where SLRID=" + txtslrid.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadsalCommand();
        }

        private void dgvsalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvsalary.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgvsalary.Rows[e.RowIndex].Cells["dgvID"].Value;
            txtslrid.Text = dgvsalary.Rows[e.RowIndex].Cells["dgvslrID"].Value.ToString();
            dtpfrom.Value = Convert.ToDateTime(dgvsalary.Rows[e.RowIndex].Cells["dgveft"].Value);
            txthouse.Text = dgvsalary.Rows[e.RowIndex].Cells["dgvhouse"].Value.ToString();
            txtmed.Text = dgvsalary.Rows[e.RowIndex].Cells["dgvmedical"].Value.ToString();
            txtbasic.Text = dgvsalary.Rows[e.RowIndex].Cells["dgvbasic"].Value.ToString();


            object tillValue = dgvsalary.Rows[e.RowIndex].Cells["dgveftill"].Value;
            if (tillValue == DBNull.Value || tillValue == null)
            {
                dtptill.Value = DateTime.Now;
            }
            else
            {
                dtptill.Value = Convert.ToDateTime(tillValue);
            }
        }
    }
}
