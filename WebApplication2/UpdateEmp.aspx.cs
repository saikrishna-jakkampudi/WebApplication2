using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class UpdateEmp : System.Web.UI.Page
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
            Adp = new SqlDataAdapter("sp_UpdateEmpdata", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEno.Text));
        
            Adp.SelectCommand.Parameters.AddWithValue("Job", txtJob.Text);
            Adp.SelectCommand.Parameters.AddWithValue("Mgr", int.Parse(txtManagerID.Text));
           
            Adp.SelectCommand.Parameters.AddWithValue("Sal", int.Parse(txtSal.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Comm", int.Parse(txtCommission.Text));
            Adp.SelectCommand.Parameters.AddWithValue("Deptno", int.Parse(txtDeptno.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            msg.Text = P.Value.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_ViewEMPDATA", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEno.Text));
            SqlParameter message=new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            message.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(message);
            DS = new DataSet();
            Adp.Fill(DS, "EMPDATA");
            if (message.Value.ToString().Length == 0)
            {
                DataRow R = DS.Tables["EMPDATA"].Rows[0];
                txtEname.Text = R[1].ToString();
                txtJob.Text = R[2].ToString();
                txtManagerID.Text = R[3].ToString();
                txtHireDate.Text = R[4].ToString();
                txtSal.Text = R[5].ToString();
                txtCommission.Text = R[6].ToString();
                txtDeptno.Text = R[7].ToString();
            }
            else
            {
                msg.Text = message.Value.ToString();
            }
        }
    }
}