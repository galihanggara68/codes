using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nama = Request.Form["nama"];
            string alamat = Request.Form["alamat"];
            if("Galih".Equals(nama))
            {
                Response.Redirect("~/Index.aspx");
            }
            Response.Write(nama);
            Response.Write(alamat);
        }
    }
}