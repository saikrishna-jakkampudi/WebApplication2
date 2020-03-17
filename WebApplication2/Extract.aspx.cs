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
    public partial class Extract : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlcon"].ToString());
            Adp = new SqlDataAdapter("sp_ExtractDept",Con);
            if (!IsPostBack)
            {
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DS = new DataSet();
                Adp.Fill(DS, "D");
                DDDEPT.DataSource = DS.Tables["D"];
                DDDEPT.DataTextField = "DNAME";
                DDDEPT.DataValueField = "DEPTNO";
                DDDEPT.DataBind();
            }
        }

        protected void DDDEPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_getDeptDetails", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("Deptno", DDDEPT.SelectedValue);
            DS = new DataSet();
            Adp.Fill(DS, "E");
            GridView1.DataSource = DS.Tables["E"];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}