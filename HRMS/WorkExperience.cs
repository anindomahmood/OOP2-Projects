using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS
{
    public partial class WorkExperience : Form
    {
        public WorkExperience()
        {
            InitializeComponent();
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
        }

        private void LoadWorkexpCommand(string SearchValue = "")
        {
            try
            {


               string query = "select eworkexperience.*, einformation.NAME from eworkexperience inner join einformation on einformation.ID = eworkexperience.ID ";
                string role = userhelper.DESIGNATION.Trim().ToLower();
                if (role != "admin" && role != "manager")
                {
                    
                    query += " WHERE eworkexperience.ID = " + userhelper.ID;
                }


                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int EXPID;


                    if (int.TryParse(SearchValue, out EXPID))
                    {
                        query += " WHERE eworkexperience.EXPID = " + EXPID +
                         " OR einformation.NAME LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " OR einformation.NAME LIKE '%" + SearchValue.Trim() + "%'";

                    }
                }

                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvwork.DefaultCellStyle.BackColor = Color.White;
                dgvwork.DefaultCellStyle.ForeColor = Color.Black;
                dgvwork.AutoGenerateColumns = false;
                dgvwork.DataSource = result.Data;
                dgvwork.Refresh();
                dgvwork.ClearSelection();
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
            txtexp.Text = "Auto Generated";
            dtpfrom.Value = DateTime.Now;
            dtptill.Value = DateTime.Now;
            cmbstatus.SelectedItem =null;
            txtsearch.Text = "";
            
        }
        private void WorkExperience_Load(object sender, EventArgs e)
        {
            this.LoadWorkexpCommand();
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
            var result= DataAccess.GetQueryData(query);
            if(result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            cmbinfo.DataSource =result.Data;
            cmbinfo.DisplayMember = "NAME";
            cmbinfo.ValueMember = "ID";
            cmbinfo.SelectedItem=null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadWorkexpCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadWorkexpCommand(txtsearch.Text);
        }

        private void dgvwork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Resetcommand();
            if (e.RowIndex < 0)
            {
                dgvwork.ClearSelection();
                return;
            }
            cmbinfo.SelectedValue = dgvwork.Rows[e.RowIndex].Cells["dgvID"].Value;
            txtexp.Text = dgvwork.Rows[e.RowIndex].Cells["dgvexp"].Value.ToString();
            dtpfrom.Value = Convert.ToDateTime(dgvwork.Rows[e.RowIndex].Cells["dgvfrom"].Value);

            object tillValue = dgvwork.Rows[e.RowIndex].Cells["dgvTill"].Value;
            cmbstatus.Text = dgvwork.Rows[e.RowIndex].Cells["dgvstatus"].Value.ToString();

            
            if (cmbstatus.Text.Trim().ToLower() == "deactivate")
            {
                dtptill.Value = DateTime.Now;
            }
            else
            {
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            
                string ID= cmbinfo.SelectedValue == null ? "" : cmbinfo.SelectedValue.ToString();
                string FROMDATE = dtpfrom.Value.ToString("yyyy-MM-dd hh:mm");
                string TILLDATE;
                string STATUS = cmbstatus.SelectedItem == null ? "" : cmbstatus.SelectedItem.ToString();

                if (STATUS.Trim().ToLower() == "deactivate")
                {
                    TILLDATE = "'" + dtptill.Value.ToString("yyyy-MM-dd hh:mm") + "'";
                }
          
                else if (dtptill.Value.Date == DateTime.Now.Date)
                {
                    TILLDATE = "NULL";

                    if (string.IsNullOrWhiteSpace(STATUS))
                    {
                        STATUS = "Active";
                        cmbstatus.SelectedItem = STATUS;
                    }
                }
                else
                {
                    TILLDATE = "'" + dtptill.Value.ToString("yyyy-MM-dd hh:mm") + "'";
                }



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
                
                if (string.IsNullOrWhiteSpace(STATUS))
                {
                    MessageBox.Show("Error: Enter STATUS");
                    return;
                }
            



                string query;
                if (txtexp.Text == "Auto Generated")
                {
                query = "insert into eworkexperience (ID, FROMDATE, TILLDATE, STATUS) values ('" + ID + "','" + FROMDATE + "'," + TILLDATE + ", '" + STATUS + "')";
                }
                else
                {
                query = "Update eworkexperience set ID='" + ID + "', FROMDATE='" + FROMDATE + "', TILLDATE=" + TILLDATE + ", STATUS='" + STATUS + "' Where EXPID=" + txtexp.Text;

                }

            var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Saved");
                this.LoadWorkexpCommand();

            }

        private void btndelete_Click(object sender, EventArgs e)
        {

                if (txtexp.Text == "Auto Generated")
                {
                    MessageBox.Show("Error:Select a row first");
                    return;
                }



                string query = "delete from eworkexperience where EXPID=" + txtexp.Text;

                var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deleted");
                this.LoadWorkexpCommand();

        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbstatus.SelectedItem != null && cmbstatus.SelectedItem.ToString().Trim().ToLower() == "deactivate")
            {
               
                dtptill.Value = DateTime.Now;
            }
        }


    }

}

