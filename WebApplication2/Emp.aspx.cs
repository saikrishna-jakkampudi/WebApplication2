using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace WebApplication2
{
    public partial class Emp : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtEno.Text);
                E.ENAME = txtEname.Text;
                E.JOB = txtJob.Text;
                E.MGR = int.Parse(txtManagerID.Text);
                E.HIREDATE = DateTime.Parse(txtHireDate.Text);
                E.SAL = int.Parse(txtSal.Text);
                E.COMM = int.Parse(txtCommission.Text);
                E.DEPTNO = int.Parse(txtDeptno.Text);

                D.EMPDATAs.Add(E);

                D.SaveChanges();
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                {
                    Label1.Text = "No Duplicate Empno";
                }
                else if (ex.Message.Contains("FK__EMPDATA__DEPTNO__2B0A656D"))
                {
                    Label1.Text = "No Deptno Number";
                }
                else
                {
                    Label1.Text = ex.Message;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("Result", typeof(String));

            D.sp_InsertEmployee(int.Parse(txtEno.Text), txtEname.Text, txtJob.Text, int.Parse(txtManagerID.Text), DateTime.Parse(txtHireDate.Text), int.Parse(txtSal.Text), int.Parse(txtCommission.Text), int.Parse(txtDeptno.Text),ob);

            Label1.Text = ob.Value.ToString();
        }
    }
}