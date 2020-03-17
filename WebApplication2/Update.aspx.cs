using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Update : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
        }

        protected void txtEno_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEno.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            // assign it to a single class object if it returns single record
            //List<EMPDATA> Lemp=E.ToList(); If we have to receive mulitple records


                    EMPDATA emp = E.First();
                    string hd = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
                    txtEname.Text = emp.ENAME;
                    txtJob.Text = emp.JOB;
                    txtManagerID.Text = emp.MGR.ToString();
            //txtHireDate.Text = emp.HIREDATE.ToString();
                    txtHireDate.Text = hd;
                    txtSal.Text = emp.SAL.ToString();
                    txtCommission.Text = emp.COMM.ToString();
                    txtDeptno.Text = emp.DEPTNO.ToString();
            
                    

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEno.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;


            
            EMPDATA ED = E.First();
            int c = 0;
            bool b= int.TryParse(txtCommission.Text, out c);
            ED.JOB = txtJob.Text;
            ED.MGR = int.Parse(txtManagerID.Text);
            ED.HIREDATE = DateTime.Parse(txtHireDate.Text);
            ED.SAL = int.Parse(txtSal.Text);
            if(c!=0)
            ED.COMM = c;
            ED.DEPTNO = int.Parse(txtDeptno.Text);

            

            D.SaveChanges();
        }
    }
}