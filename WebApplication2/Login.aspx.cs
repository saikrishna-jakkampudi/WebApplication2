using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2
{
    public partial class Login1 : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
 
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_ValidateLogin",Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@U", txtUsername.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@P", txtPassword.Text);
            SqlParameter P = new SqlParameter("@C", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);


            if (P.Value.ToString() == "1")
            {

               Response.Cookies["Username"].Value = txtUsername.Text;

               Response.Redirect("AddEmp.aspx");
               
            }

               

            else

                lblMessage.Text = "Invalid Credentials";
            txtUsername.Focus();
      
          }
    }
}