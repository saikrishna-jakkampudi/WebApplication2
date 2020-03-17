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
    public partial class Confirm1 : System.Web.UI.Page
    {
        SqlDataAdapter adp = null;
        SqlConnection con = null;
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["E"] != null)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());

                EMPDATA E = (EMPDATA)Session["E"];

                Eno.Text = E.EMPNO.ToString();
                Ename.Text = E.ENAME.ToString();
                Job.Text = E.JOB.ToString();
                HD.Text = E.HIREDATE.ToString();
                Mgr.Text = E.MGR.ToString();
                Sal.Text = E.SAL.ToString();
                Com.Text = E.COMM.ToString();
                Dptno.Text = E.DEPTNO.ToString();
     
            }
            else
            {
                Response.Redirect("Login.aspx");
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("SP_InsertEmployee", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(Eno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Ename", Ename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Job", Job.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Mgr", int.Parse(Mgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Hiredate", DateTime.Parse(HD.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Sal", int.Parse(Sal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Comm", int.Parse(Com.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(Dptno.Text));
            SqlParameter message = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            message.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(message);
            ds = new DataSet();
            adp.Fill(ds);
            Label1.Text = message.Value.ToString();
            //Session.Remove("E");
            //Session["E"] = null;
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Loginpages.aspx");
        }
    }
}