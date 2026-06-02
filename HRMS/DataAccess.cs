using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{

    public class Result
    {
        public DataTable Data { get; set; }
        public bool HasError { get; set; }  
        public string Message { get; set; }
    }

    internal class DataAccess
    {
        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-65I83DVV\\SQLEXPRESS04;Initial Catalog=humanresource;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public static Result GetQueryData(string query)

        {
            var result = new Result();

            try

            {   con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                con.Close();
                result.Data = dt;
                
                
            }

            catch (Exception e)
            {
                con.Close();
                result.HasError=true;
                result.Message=e.Message;
            }
            return result; 
        }
        public static Result ExecuteNonResultQuery(string query)
        {
            var result = new Result();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)

            {
                con.Close();
                result.HasError = true;
                result.Message=e.Message;
            }
            return result;

        }


    }
}
