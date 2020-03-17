using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class DeleteEmp : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void btDelete_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_DeleteValidate", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEno.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            msg.Text = P.Value.ToString();
        }
    }
}
