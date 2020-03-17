using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime Today = DateTime.Today;
            DateTime dob = DateTime.Parse(TextBox7.Text);

            int age = (int)(Today.Subtract(dob).TotalDays) / 365;
            
            if(age>=21 && age <= 58)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
            
         
        }
    }
}