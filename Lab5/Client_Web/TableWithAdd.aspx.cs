using Client_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_Web
{
    public partial class TableWithAdd : System.Web.UI.Page
    {
        Service1Client sessionClient = new Service1Client("BasicHttpBinding_IService1");
        static Uri address = new Uri("http://localhost:8733/Design_Time_Addresses/Service1/");
        BasicHttpBinding binding = new BasicHttpBinding();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            sessionClient.ConnectionInfo(binding.Name, address.Port.ToString(), address.LocalPath,
                address.ToString(), address.Scheme);
            GridView1.DataSource = sessionClient.GetData();
            GridView1.DataBind();
            DropDownList3.DataSource = sessionClient.GetClientSelectData();
            DropDownList3.DataTextField = "FIO";
            DropDownList3.DataValueField = "id_Client";
            DropDownList3.DataBind();
            DropDownList2.DataSource = sessionClient.GetBusSelectData();
            DropDownList2.DataTextField = "Name_car";
            DropDownList2.DataValueField = "id_Bus";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id_Client = DropDownList3.Text;
            var id_Bus = DropDownList2.Text;
            var date = this.dateXEP.Text;
            var cost = this.cost.Text;
            if (sessionClient.RecCheck(id_Client, id_Bus, date, cost) == "1")
            {
                Label2.Visible = true;
                Label1.Visible = false;
            }
            else
            {
                Label1.Text = sessionClient.InsertMethod(id_Client, id_Bus, date, cost);
                Label1.Visible = true;
                Label2.Visible = false;
                Response.Redirect("/TableWithAdd");
            }
        }
    }
}