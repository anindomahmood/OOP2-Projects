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
    public partial class DESIGNATION : Form
    {
        public DESIGNATION()
        {
            InitializeComponent();
        }

        private void LoadDesignationCommand(string SearchValue = "")
        {
            try
            {


                string query = "select * from edesignation";
                if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int DID;


                    if (int.TryParse(SearchValue, out DID))
                    {
                        query += " WHERE DID = " + DID + " OR DESIGNATION LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE DESIGNATION LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvdes.DefaultCellStyle.BackColor = Color.White;
                dgvdes.DefaultCellStyle.ForeColor = Color.Black;
                dgvdes.AutoGenerateColumns = false;
                dgvdes.DataSource = result.Data;
                dgvdes.Refresh();
                dgvdes.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Resetcommand()
        {
            txtdid.Text = "Auto Generated";
            cmbdesignation.SelectedItem = null;


        }

        private void DESIGNATION_Load(object sender, EventArgs e)
        {
            this.LoadDesignationCommand();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDesignationCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadDesignationCommand(txtsearch.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string DESIGNATION = cmbdesignation.SelectedItem == null ? "" : cmbdesignation.SelectedItem.ToString();




            if (string.IsNullOrWhiteSpace(DESIGNATION))
            {
                MessageBox.Show("Error: Enter DESIGNATION");
                return;
            }

            string query;
            if (txtdid.Text == "Auto Generated")
            {
                query = "insert into edesignation Values('" +DESIGNATION+ "')";
            }
            else
            {
                query = "Update edesignation set DESIGNATION='" + DESIGNATION + "' Where DID=" + txtdid.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadDesignationCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (txtdid.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }



            string query = "delete from edesignation where DID=" + txtdid.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadDesignationCommand();
        }

        private void dgvdes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvdes.ClearSelection();
                return;
            }
            txtdid.Text = dgvdes.Rows[e.RowIndex].Cells["dgvdid"].Value.ToString();
            cmbdesignation.Text = dgvdes.Rows[e.RowIndex].Cells["dgvdesig"].Value.ToString();
        }
    }
}
