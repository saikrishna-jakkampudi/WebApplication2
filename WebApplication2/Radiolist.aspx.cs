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
    public partial class Radiolist : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlcon"].ToString());
            Adp = new SqlDataAdapter("sp_ExtractDept", Con);
            if (!IsPostBack)
            {

                txtEnd.Enabled = false;
                txtStart.Enabled = false;
                DDDEPTN.Enabled = false;

                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DS = new DataSet();
                Adp.Fill(DS, "D");
                DDDEPTN.DataSource = DS.Tables["D"];
                DDDEPTN.DataTextField = "DNAME";
                DDDEPTN.DataValueField = "DEPTNO";
                DDDEPTN.DataBind();
            }
        }

        protected void rdbHiredate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                DDDEPTN.Enabled = false;
            }        
        }

        protected void rdbDeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeptno.Checked)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                DDDEPTN.Enabled = true;
            }

        }

        protected void DDDEPTN_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                Adp = new SqlDataAdapter("sp_Hiredate", Con);
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.Parameters.AddWithValue("@StartDate",DateTime.Parse(txtStart.Text));
                Adp.SelectCommand.Parameters.AddWithValue("@enddate",DateTime.Parse(txtEnd.Text));
                DS = new DataSet();
                Adp.Fill(DS, "E");
                GridView1.DataSource = DS.Tables["E"];
                GridView1.DataBind();
            }
            else if (rdbDeptno.Checked)
            {
                Adp = new SqlDataAdapter("sp_getDeptDetails", Con);
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.Parameters.AddWithValue("Deptno", DDDEPTN.SelectedValue);
                DS = new DataSet();
                Adp.Fill(DS, "E");
                GridView1.DataSource = DS.Tables["E"];
                GridView1.DataBind();
            }
        }
    }
}