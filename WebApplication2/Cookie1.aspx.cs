using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Cookie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // How to create a cookie variable
            if (TextBox1.Text.Length != 0)
            {
                Response.Cookies["User"].Value = TextBox1.Text; // Declaration of Cookie
                Response.Cookies["User"].Expires = DateTime.Now.AddSeconds(5);
                Response.Redirect("Cookie2.aspx");

                // Second Type of creating cookies.
                //    HttpCookie H = new HttpCookie("User1");
                //    H.Value = TextBox1.Text;
                //    Response.Cookies.Add(H);
                //
            }
        }

    }

}
