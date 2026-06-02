using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HRMS
{
    public partial class Information : Form
    {
       
        public Information()
        {
            InitializeComponent();
        }
        private void LoadUserInfoCommand(string SearchValue = "")
        {
            try
            {
                
              
                string query = "select * from einformation";
                string role=userhelper.DESIGNATION.Trim().ToLower();
                if(role != "admin" && role != "manager")
                {
                    query += " WHERE ID = " +userhelper.ID;
                }






                else if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    int ID;


                    if (int.TryParse(SearchValue, out ID))
                    {
                        query += " WHERE ID = " + ID + " OR NAME LIKE '%" + SearchValue.Trim() + "%'";
                    }
                    else
                    {
                        query += " WHERE NAME LIKE '%" + SearchValue.Trim() + "%'";
                    }
                }
                
                var result = DataAccess.GetQueryData(query);
                if(result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvInfo.DefaultCellStyle.ForeColor = Color.Black;
                dgvInfo.AutoGenerateColumns = false;
                dgvInfo.DataSource = result.Data;
                dgvInfo.Refresh();
                dgvInfo.ClearSelection();
                this.Resetcommand();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Resetcommand()
        {
            txtid.Text = "Auto Generated";
            txtaddress.Text = txtblood.Text = txtphone.Text = txtname.Text = txtemail.Text = txtpassword.Text=txtsearch.Text = " ";
            dtpdob.Value = DateTime.Now;
            rdbmale.Checked = rdbfemale.Checked = false;
        }

        private void Information_Load(object sender, EventArgs e)
        {
           this.LoadUserInfoCommand();
           string role = userhelper.DESIGNATION.Trim().ToLower();
           if (role != "admin" && role != "manager")
            {
                btndelete.Enabled = false;
                btnsave.Enabled = true;
                btnsearch.Enabled = false;
                
                txtsearch.Enabled = false;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoCommand();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.Resetcommand();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                string NAME = txtname.Text;
                string PASSWORD= txtpassword.Text;
                string PHONE= txtphone.Text;
                string ADDRESS= txtaddress.Text;
                string BLOOD= txtblood.Text;
                string EMAIL= txtemail.Text;
                string GENDER = rdbmale.Checked ? rdbmale.Text.Trim() : rdbfemale.Checked ? rdbfemale.Text.Trim() : "";
                string DOB=dtpdob.Value.ToString("yyyy-MM-dd hh:mm");
                

                if(string.IsNullOrWhiteSpace(NAME))
                {
                    MessageBox.Show("Error: Enter Name");
                    return;
                }
                if (string.IsNullOrWhiteSpace(PASSWORD))
                {
                    MessageBox.Show("Error: Enter Passsword");
                    return;
                }
                if (string.IsNullOrWhiteSpace(PHONE))
                {
                    MessageBox.Show("Error: Enter PHONE");
                    return;
                }
                if (string.IsNullOrWhiteSpace(ADDRESS))
                {
                    MessageBox.Show("Error: Enter ADDRESS");
                    return;
                }
                if (string.IsNullOrWhiteSpace(BLOOD))
                {
                    MessageBox.Show("Error: Enter BLOOD");
                    return;
                }
                if (string.IsNullOrWhiteSpace(EMAIL))
                {
                    MessageBox.Show("Error: Enter EMAIL");
                    return ;
                }
                if (string.IsNullOrWhiteSpace(GENDER))
                {
                    MessageBox.Show("Error: Enter Gender");
                    return;
                }
                if (string.IsNullOrWhiteSpace(NAME))
                {
                    MessageBox.Show("Error: Enter DOB");
                    return;
                }

                
                

                string query;
                if(txtid.Text== "Auto Generated")
                {
                    query = "insert into einformation Values('" + NAME + "','" + GENDER + "', '" + DOB + "','" + BLOOD + "','" + ADDRESS + "','" + EMAIL + "','" + PHONE + "', '" + PASSWORD + "')";
                }
                else
                {
                    query = "Update einformation set NAME='" + NAME + "',GENDER='" + GENDER + "', DOB='" + DOB + "',BLOOD='" + BLOOD + "',ADDRESS='" + ADDRESS + "',EMAIL='" + EMAIL + "',PHONE='" + PHONE + "',PASSWORD= '" + PASSWORD + "' Where ID="+txtid.Text;
                }

                var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Saved");
                this.LoadUserInfoCommand();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         try
            {
                this.Resetcommand();
                if(e.RowIndex < 0)
                {
                    dgvInfo.ClearSelection();
                    return;
                }
                int ID = int.Parse(dgvInfo.Rows[e.RowIndex].Cells["dgvID"].Value.ToString());
                
                string query = "select * from einformation where ID="+ID;
                var result = DataAccess.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                
                txtid.Text = result.Data.Rows[0]["ID"].ToString();
                txtname.Text = result.Data.Rows[0]["NAME"].ToString();
                dtpdob.Value = Convert.ToDateTime(result.Data.Rows[0]["DOB"]);
                txtpassword.Text = result.Data.Rows[0]["PASSWORD"].ToString();
                txtaddress.Text = result.Data.Rows[0]["ADDRESS"].ToString();
                txtblood.Text = result.Data.Rows[0]["BLOOD"].ToString();
                txtemail.Text = result.Data.Rows[0]["EMAIL"].ToString();
                txtphone.Text = result.Data.Rows[0]["PHONE"].ToString();
                rdbmale.Checked = result.Data.Rows[0]["GENDER"].ToString().Trim() == "MALE";
                rdbfemale.Checked= result.Data.Rows[0]["GENDER"].ToString().Trim() == "FEMALE";
                
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text=="Auto Generated")
                {
                    MessageBox.Show("Error:Select a row first");
                    return;
                }

                
             
                string query = "delete from einformation where ID="+txtid.Text;

                var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                
                MessageBox.Show("Deleted");
                this.LoadUserInfoCommand();
               

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoCommand(txtsearch.Text);
        }

        
    }
}
