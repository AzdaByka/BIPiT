using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class AddForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var s = new ServiceReference1.WebService1SoapClient();
            var s = new ServiceReference2.WebService1SoapClient();
            DropDownList3.DataSource = s.GetNameStudSelectData();
            DropDownList3.DataTextField = "FIO";
            DropDownList3.DataValueField = "id";
            DropDownList3.DataBind();
            DropDownList2.DataSource = s.GetDisSelectData();
            DropDownList2.DataTextField = "name_dis";
            DropDownList2.DataValueField = "id_dis";
            DropDownList2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {           
            var s = new ServiceReference2.WebService1SoapClient(); 
            var id_stud = DropDownList3.Text;
            var id_dis = DropDownList2.Text;
            var date = dateEx.Text;
            var mark = markEx.Text;
            var check = s.RecCheck(id_dis, id_stud, date, mark);
            if (check == "1")
            {
                Label2.Visible = true;
            }
            else
            {
                Label1.Text = s.InsertMethod(id_stud, id_dis, date, mark);
                Label1.Visible = true;
                Response.Redirect("/Default");
            }                     
        }
    }
}