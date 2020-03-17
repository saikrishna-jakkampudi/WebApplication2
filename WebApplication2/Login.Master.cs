using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["Username"] ==null)
            //{
            //    Response.Redirect("Login.aspx");
            //}

            //else
            //{
            //    Label1.Text = "Welcome  " + Request.Cookies["Username"].Value;
            //}

            //string S = Path.GetFileName(Request.Path);

            //if (S != "Loginapages.aspx")
            //{

            // If and only if your master pages are sane then use this syntax


                if (Session["Username"] == null)
                {
                    Response.Redirect("Loginpages.aspx");
                }
                else
                {
                    Label1.Text = "Welcome " + Session["Username"].ToString();
                }
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    if (Request.Cookies["Username"] != null)
        //    {

        //        //HttpCookie aCookie = HttpContext.Current.Request.Cookies["Username"];
        //        //aCookie.Expires = DateTime.Now.AddSeconds(1);
        //        //aCookie.Value = "";
        //        //HttpContext.Current.Response.Cookies.Add(aCookie);
        //        //Response.Redirect("Login.aspx");

        //        if (Request.Cookies["Username"] != null)
        //        {
        //            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
        //        }
        //    }
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Loginpages.aspx");
        }
    }
}