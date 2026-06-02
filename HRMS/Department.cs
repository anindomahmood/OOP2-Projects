using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        private void LoadDepartmentCommand(string SearchValue = "")
        {
            try
            {


                string query = "select * from edepartment";
                if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int DEPTID;


                    if (int.TryParse(SearchValue, out DEPTID))
                    {
                        query += " WHERE DEPTID = " + DEPTID + " OR TITLE LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE TITLE LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvdepartment.DefaultCellStyle.BackColor = Color.White;
                dgvdepartment.DefaultCellStyle.ForeColor = Color.Black;
                dgvdepartment.AutoGenerateColumns = false;
                dgvdepartment.DataSource = result.Data;
                dgvdepartment.Refresh();
                dgvdepartment.ClearSelection();
                this.Resetcommand();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Resetcommand()
        {
            txtdeptid.Text = "Auto Generated";
            cmbtitle.SelectedItem = null;
         

        }

       
        
        private void Department_Load(object sender, EventArgs e)
        {
            this.LoadDepartmentCommand();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDepartmentCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadDepartmentCommand(txtsearch.Text);
        }

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            string TITLE = cmbtitle.SelectedItem == null ? "" : cmbtitle.SelectedItem.ToString();

            


            if (string.IsNullOrWhiteSpace(TITLE))
            {
                MessageBox.Show("Error: Enter TYPE");
                return;
            }

            string query;
            if (txtdeptid.Text == "Auto Generated")
            {
                query = "insert into edepartment Values('" + TITLE + "')";
            }
            else
            {
                query = "Update edepartment set TITLE='" + TITLE + "' Where DEPTID=" + txtdeptid.Text;
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show("Saved");
            this.LoadDepartmentCommand();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtdeptid.Text == "Auto Generated")
            {
                MessageBox.Show("Error:Select a row first");
                return;
            }



            string query = "delete from edepartment where DEPTID=" + txtdeptid.Text;

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Deleted");
            this.LoadDepartmentCommand();
        }

        private void dgvdepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvdepartment.ClearSelection();
                return;
            }
            txtdeptid.Text = dgvdepartment.Rows[e.RowIndex].Cells["dgvDeptid"].Value.ToString();
            cmbtitle.Text = dgvdepartment.Rows[e.RowIndex].Cells["dgvtitle"].Value.ToString();
        }

        }
    }

