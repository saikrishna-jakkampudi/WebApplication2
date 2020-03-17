using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class QSEX5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["A"];
            string s1 = Request.QueryString["B"];

            Response.Write(s + " " + s1);
        }
    }
}