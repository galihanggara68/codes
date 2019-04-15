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

            if(!IsPostBack)
            {
                List<string> lists = new List<string>();
                ViewState.Add("nama", lists);
            }

            if(Request.QueryString["username"] != null)
            {
                if(!"admin".Equals(Request.QueryString["role"]))
                {
                    Response.Write("Unauthorized User");
                }
                else
                {
                    ViewState.Add("username", Request.QueryString["username"]);
                }
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            List<string> lists = (List<string>)ViewState["nama"];
            lists.Add(txtNama.Text);
        }

    }
}