using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bepet_3_2._1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string path = @"Data Source=gggggggg.mssql.somee.com;Initial Catalog=gggggggg;User Id=good_job_Oleg_SQLLogin_1;Password=8aoh3a3zmb";
            if (Menu1.SelectedValue.Contains("Экспонаты"))
            {
                string query = "SELECT * FROM expanate ";
                DataSet dataSet = new DataSet();
                using (SqlConnection connection = new SqlConnection(path))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    sqlDataAdapter.Fill(dataSet, "expanate");
                    dataSet.Tables[0].Columns[0].ColumnName = "ID Экспоната";
                    dataSet.Tables[0].Columns[1].ColumnName = "Название";
                    dataSet.Tables[0].Columns[2].ColumnName = "Автор";
                    GridView1.DataSource = dataSet.Tables["expanate"];
                    GridView1.DataBind();
                }
            }
            if (Menu1.SelectedValue.Contains("Залы"))
            {
                string query = "SELECT * FROM hall";
                DataSet dataSet = new DataSet();
                using (SqlConnection connection = new SqlConnection(path))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    sqlDataAdapter.Fill(dataSet, "hall");
                    dataSet.Tables[0].Columns[0].ColumnName = "ID Зала";
                    dataSet.Tables[0].Columns[1].ColumnName = "Тема";
                    dataSet.Tables[0].Columns[2].ColumnName = "Площать";
                    GridView1.DataSource = dataSet.Tables["hall"];
                    GridView1.DataBind();
                }
            }
            if (Menu1.SelectedValue.Contains("Перемещения"))
            {
                string query =
                    "SELECT name_exp, name_h, transfers.date, stay FROM transfers INNER JOIN hall ON [transfers].id_h_fk = hall.id_h INNER JOIN expanate ON [transfers].id_exp_fk = expanate.id_exp";
                DataSet dataSet = new DataSet();
                using (SqlConnection connection = new SqlConnection(path))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    sqlDataAdapter.Fill(dataSet, "transfers");
                    dataSet.Tables[0].Columns[0].ColumnName = "Название экспоната";
                    dataSet.Tables[0].Columns[1].ColumnName = "Тема зала";
                    dataSet.Tables[0].Columns[2].ColumnName = "Дата перемещения";
                    dataSet.Tables[0].Columns[3].ColumnName = "Дней в зале";
                    GridView1.DataSource = dataSet.Tables["transfers"];
                    GridView1.DataBind();
                    
                }
            }
        }
    }
}