using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            var s = new ServiceReference2.WebService1SoapClient();
            GridView2.DataSource = s.GetData("","");
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var s = new ServiceReference2.WebService1SoapClient();
            foreach (GridViewRow row in GridView2.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("CheckBox2");
                if (cb != null && cb.Checked)
                {
                    String customAttr1 = cb.Attributes["data-Value"].ToString();
                    s.DeleteRec(customAttr1);
                }
            }

            Response.Redirect("/Default");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var s = new ServiceReference2.WebService1SoapClient();
            GridView2.DataSource = s.GetData(TextBox1.Text, TextBox2.Text);
            GridView2.DataBind();
        }

    }
}