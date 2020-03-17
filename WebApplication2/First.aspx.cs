using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txtEno.Text);
            E.ENAME = txtEname.Text;
            E.JOB = txtJob.Text;
            E.HIREDATE = DateTime.Parse(txtHireDate.Text);
            E.MGR = int.Parse(txtManagerID.Text);
            E.SAL = int.Parse(txtSal.Text);
            E.COMM = int.Parse(txtCommission.Text);
            E.DEPTNO = int.Parse(txtDeptno.Text);
            Session["E"] = E;
            Response.Redirect("Confirm.aspx");
        }
    }
}