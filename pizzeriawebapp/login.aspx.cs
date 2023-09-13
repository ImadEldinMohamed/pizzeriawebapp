using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pizzeriawebapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == ConfigurationManager.AppSettings["username"] && TextBox3.Text == ConfigurationManager.AppSettings["password"])
            {
                FormsAuthentication.SetAuthCookie(TextBox1.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }
    }

}