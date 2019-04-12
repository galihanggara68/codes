using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItemCollection genders = new ListItemCollection {
                new ListItem{ Text="Laki-laki", Value="l" },
                new ListItem{ Text="Perempuan", Value="p" }
            };
            gender.DataSource = genders;
            gender.DataBind();
        }
    }
}