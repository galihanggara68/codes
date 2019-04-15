using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.Form["btnLogin"] != null)
            {
                string username = Request.Form["txtUsername"];
                string password = Request.Form["txtPassword"];
                if("galihanggara".Equals(username))
                {
                    if("admin123".Equals(password))
                    {
                        ViewState.Add("username", username);
                    }
                    else
                    {
                        Response.Redirect("~/Index.aspx?error=2");
                    }
                }
                else
                {
                    Response.Redirect("~/Index.aspx?error=1");
                }
            }

            if(Request.QueryString["error"] != null)
            {
                int errors = int.Parse(Request.QueryString["error"].ToString());
                switch(errors)
                {
                    case 1:
                        Response.Write("Username Salah");
                        break;
                    case 2:
                        Response.Write("Password Salah");
                        break;
                }
            }
        }
    }
}