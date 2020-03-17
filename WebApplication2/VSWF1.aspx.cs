using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class VSWF1 : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["V"] == null)
                ViewState["V"] = 10;

            else

                ViewState["V"] = (int)ViewState["V"] + 1;
            if (i != 10)
                i = 10;
            else i++;
            i = 10;


            TextBox1.Text = (++i).ToString();
            //  int k         = (int)ViewState["V"];

            TextBox2.Text = ((int)ViewState["V"] + 1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VSWF2.aspx");
        }
    }
}