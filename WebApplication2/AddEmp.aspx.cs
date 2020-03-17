using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication2
{
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_InsertEmployee", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEno.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Ename", txtEname.Text);
            Adp.SelectCommand.Parameters.AddWithValue("Job",txtJob.Text);
            Adp.SelectCommand.Parameters.AddWithValue("Mgr",int.Parse(txtManagerID.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Hiredate",DateTime.Parse(txtHireDate.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Sal",int.Parse(txtSal.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Comm",int.Parse(txtCommission.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Deptno",int.Parse(txtDeptno.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar,100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            msg.Text = P.Value.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}