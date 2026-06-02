using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS
{
    public partial class RECORDS : Form
    {
        public RECORDS()
        {
            InitializeComponent();
        }
        private void LoadRecordsCommand(string SearchValue = "")
        {
            try
            {


                string query = "SELECT e.ID,e.NAME,dpt.TITLE AS Department,des.DESIGNATION,r.* FROM erecords r JOIN einformation e ON r.ID = e.ID JOIN edepartment dpt ON r.DEPTID = dpt.DEPTID JOIN edesignation des ON r.DID = des.DID";
                string role = userhelper.DESIGNATION.Trim().ToLower();
                if (role != "admin" && role != "manager")
                {

                    query += " WHERE r.ID = " + userhelper.ID;
                }
                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int RID;


                    if (int.TryParse(SearchValue, out RID))
                    {
                        query += " WHERE r.RID =" + RID;
                    }

                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvrec.DefaultCellStyle.BackColor = Color.White;
                dgvrec.DefaultCellStyle.ForeColor = Color.Black;
                dgvrec.AutoGenerateColumns = false;
                dgvrec.DataSource = result.Data;
                dgvrec.Refresh();
                dgvrec.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Resetcommand()
        {
            txtRID.Text = "Auto Generated";
            cmbinfo.SelectedItem = null;
            cmbdes.SelectedItem = null;
            cmbdept.SelectedItem = null;
            dtpfrom.Value = DateTime.Now;
            dtptill.Value = DateTime.Now;
            txtsearch.Text = "";

        }
        private void RECORDS_Load(object sender, EventArgs e)
        {
            this.LoadRecordsCommand();
            this.LoadInformationCommand();
            this.LoadDepartmentCommand();
            this.LoadDesignationCommand();
            string role = userhelper.DESIGNATION.Trim().ToLower();
            if (role != "admin" && role != "manager")
            {
                btndelete.Enabled = false;
                btnsave.Enabled = false;
                btnsearch.Enabled = false;
                cmbinfo.Enabled = false;
                txtsearch.Enabled = false;
                cmbdept.Enabled = false;
                cmbdes.Enabled = false;
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
            cmbinfo.SelectedItem=null;

        }
        private void LoadDepartmentCommand()
        {
            var query = "select * from edepartment";
            var result = DataAccess.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            cmbdept.DataSource = result.Data;
            cmbdept.DisplayMember = "TITLE";
            cmbdept.ValueMember = "DEPTID";
            cmbdept.SelectedIndex = 0;
        }

        private void LoadDesignationCommand()
        {
            var query = "select * from edesignation";
            var result = DataAccess.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            cmbdes.DataSource = result.Data;
            cmbdes.DisplayMember = "DESIGNATION";
            cmbdes.ValueMember = "DID";
            cmbdes.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadRecordsCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadRecordsCommand(txtsearch.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ID = cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
            string DID = cmbdes.SelectedValue == null ? "" : cmbdes.SelectedValue.ToString();
            string DeptID = cmbdept.SelectedValue == null ? "" : cmbdept.SelectedValue.ToString(); ;
            string FROMDATE = dtpfrom.Value.ToString("yyyy-MM-dd hh:mm");
            string TILLDATE = dtptill.Value.ToString("yyyy-MM-dd hh:mm");

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
            if (string.IsNullOrWhiteSpace(DID))
            {
                MessageBox.Show("Error: Enter DID");
                return;
            }
            if (string.IsNullOrWhiteSpace(DeptID))
            {
                MessageBox.Show("Error: Enter DeptID");
                return;
            }


            string query;
            if (txtRID.Text == "Auto Generated")
            {
                query = "insert into erecords Values('" + ID + "','" + DID + "','" + DeptID + "', '" +FROMDATE+ "', '" +TILLDATE+"')";
            }
            else
            {
                query = "Update erecords set ID='" + ID + "', DID='" + DID + "',DEPTID='" + DeptID + "', FROMDATE='" +FROMDATE + "', TILLDATE='" + TILLDATE + "' Where RID=" + txtRID.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadRecordsCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtRID.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }



            string query = "delete from erecords where RID=" + txtRID.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadRecordsCommand();
        }

        private void dgvrec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvrec.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgvrec.Rows[e.RowIndex].Cells["dgvID"].Value;
            txtRID.Text = dgvrec.Rows[e.RowIndex].Cells["dgvRID"].Value.ToString();
            cmbdes.SelectedValue = dgvrec.Rows[e.RowIndex].Cells["dgvDID"].Value;
            cmbdept.SelectedValue = dgvrec.Rows[e.RowIndex].Cells["dgvDeptID"].Value;
            dtpfrom.Value = Convert.ToDateTime(dgvrec.Rows[e.RowIndex].Cells["dgvFromDate"].Value);

            object tillValue = dgvrec.Rows[e.RowIndex].Cells["dgvTillDate"].Value;
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
