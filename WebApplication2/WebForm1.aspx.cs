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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlcon"].ToString());
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from EmpData", con);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds, "E");
            DataRow R = Ds.Tables["E"].NewRow();
            R[0] = int.Parse(txtEno.Text);
            R[1] = txtEname.Text;
            R[2] = txtJob.Text;
            R[3] = txtManagerID.Text;
            R[4] = DateTime.Parse(txtHireDate.Text);

            R[5] = int.Parse(txtSal.Text);
            R[6] = int.Parse(txtCommission.Text);
            R[7] = int.Parse(txtDeptno.Text);

            Ds.Tables["E"].Rows.Add(R);
            SqlCommandBuilder cmb = new SqlCommandBuilder(Adp);
            Adp.InsertCommand = cmb.GetInsertCommand();
            Adp.Update(Ds, "E");
            Response.Write("<script LANGUAGE='JavaScript' >alert('Details Saved Successfully')</script>");


        }
    }
}