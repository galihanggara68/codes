using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm
{
    public partial class Proses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Form["buttonRegister"] != null)
            {
                literalNama.Text = Request.Form["textBoxNama"];
                literalAlamat.Text = Request.Form["textBoxAlamat"];
                literalGender.Text = Request.Form["gender"];
                literalTanggal.Text = Request.Form["textBoxTanggal"];
                literalEmail.Text = Request.Form["textBoxEmail"];
            }
            else {
                labelEmailLogin.Text = Request.Form["textBoxEmail"];
            }
        }
    }
}