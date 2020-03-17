using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UsageofViews : System.Web.UI.Page
    {
        orderEntities o = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            o = new orderEntities();

            
            var V =from O in o.ViewReports
                   select O;

            //GridView1.DataSource = V.ToList();
            //GridView1.DataBind();

            //DetailsView1.DataSource = V.ToList();
            //DetailsView1.DataBind();

             FormView1.DataSource = V.ToList();
             FormView1.DataBind();


        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            FormView1.DataBind();
        }
    }
}