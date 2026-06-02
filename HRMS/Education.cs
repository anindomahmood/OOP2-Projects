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
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }
        private void LoadEducationCommand(string SearchValue = "")
        {
            try
            {


                string query ="select eeducation.*, einformation.NAME from eeducation inner join einformation on einformation.ID = eeducation.ID ";
                string role = userhelper.DESIGNATION.Trim().ToLower();

                if (role != "admin" && role != "manager")
                {

                    query += " WHERE eeducation.ID = " + userhelper.ID;
                }
                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int ID;


                    if (int.TryParse(SearchValue, out ID))
                    {
                        query += " WHERE einformation.ID = " + ID + " OR eeducation.TYPE LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE eeducation.TYPE LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgveducation.DefaultCellStyle.BackColor = Color.White;
                dgveducation.DefaultCellStyle.ForeColor = Color.Black;
                dgveducation.AutoGenerateColumns = false;
                dgveducation.DataSource = result.Data;
                dgveducation.Refresh();
                dgveducation.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Resetcommand()
        {
            cmbinfo.SelectedItem = null;
            txteid.Text = "Auto Generated";
            cmbtype.SelectedItem = null;
            txtsearch.Text = "";

        }

        private void Education_Load(object sender, EventArgs e)
        {
            this.LoadEducationCommand();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadEducationCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadEducationCommand(txtsearch.Text);
        }

        private void dgveducation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgveducation.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgveducation.Rows[e.RowIndex].Cells["dgvID"].Value;
            txteid.Text = dgveducation.Rows[e.RowIndex].Cells["dgveid"].Value.ToString();
            cmbtype.Text = dgveducation.Rows[e.RowIndex].Cells["dgvtype"].Value.ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ID = cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
            string TYPE = cmbtype.SelectedItem == null ? "" : cmbtype.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Error: Enter ID");
                return;
            }


            if (string.IsNullOrWhiteSpace(TYPE))
            {
                MessageBox.Show("Error: Enter TYPE");
                return;
            }
            
            string query;
            if (txteid.Text == "Auto Generated")
            {
                query = "insert into eeducation Values( '"+ID+"','" + TYPE + "')";
            }
            else
            {
                query = "Update eeducation set ID='"+ID+"',TYPE='" + TYPE + "' Where EID=" + txteid.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadEducationCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txteid.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }

            

            string query = "delete from eeducation where EID=" + txteid.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadEducationCommand();
        }
    }
}
