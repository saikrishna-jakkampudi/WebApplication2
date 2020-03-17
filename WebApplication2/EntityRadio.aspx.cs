using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class EntityRadio : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();

            if (!IsPostBack)
            {
                txtEnd.Enabled = false;
                txtStart.Enabled = false;
                DDDEPTN.Enabled = false;
            }
            if (!IsPostBack)
            {
                var E = from E1 in D.DEPTDATAs
                        select E1;
                DDDEPTN.DataValueField="Deptno";
                DDDEPTN.DataTextField="Dname";
                DDDEPTN.DataSource = E.ToList();
                DataBind();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                DateTime start = DateTime.Parse(txtStart.Text);
                DateTime end = DateTime.Parse(txtEnd.Text);
                var E = from E1 in D.EMPDATAs
                        where E1.HIREDATE>=start && E1.HIREDATE<=end
                        select E1;
                List<EMPDATA> lemp=E.ToList();
                GridView1.DataSource = lemp;
                GridView1.DataBind();

                if (GridView1.Rows.Count == 0)
                {
                    Label1.Text = "No Data Found";
                }

            }
            else if (rdbDeptno.Checked)
            {
                int dno = int.Parse(DDDEPTN.SelectedValue);
                var E = from E1 in D.EMPDATAs
                        where E1.DEPTNO == dno
                        select E1;


                List<EMPDATA> lemp = E.ToList();
                GridView1.DataSource = lemp;
                GridView1.DataBind();

                if (GridView1.Rows.Count == 0)
                {
                    Label1.Text = "No Data Found";
                }
            }
        }

        protected void DDDEPTN_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}