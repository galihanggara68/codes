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
            DataTable dataTable = new DataTable("orang");
            dataTable.Columns.Add(new DataColumn("nama"));
            dataTable.Columns.Add(new DataColumn("alamat"));
            dataTable.Columns.Add(new DataColumn("selesai"));

            dataTable.Rows.Add("Galih", "Tangerang", true);
            dataTable.Rows.Add("Ujang", "Bandung", false);

            gridView.DataSource = dataTable;
            gridView.DataBind();
        }
    }
}