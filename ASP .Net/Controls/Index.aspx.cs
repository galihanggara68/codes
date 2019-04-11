using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace ASPWebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItemCollection operators = new ListItemCollection {
                new ListItem("+", "+"),
                new ListItem("-", "-"),
                new ListItem("/", "/"),
                new ListItem("*", "*"),
                new ListItem("%", "%")
            };

            dropDownOperator.DataSource = operators;
            dropDownOperator.DataBind();

            radioButtons.DataSource = operators;
            radioButtons.DataBind();
        }

        protected void hitung_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);
            int sum = num1 + num2;
            result.Text = sum.ToString();
            result.ForeColor = (sum < 0 ? Color.Red : Color.Green);
        }
    }
}