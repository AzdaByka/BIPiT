using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;



namespace Lab_4_CSharp
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public string InsertMethod(string id_Client, string id_Bus, string date, string cost)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"INSERT INTO [Order] VALUES ({id_Client},{id_Bus},'{date}',{cost})";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
            return "Готово";
        }

        [WebMethod]
        public DataTable GetData(string dateFirst, string dateSecond)
        {
            var query = "";
            if (string.IsNullOrEmpty(dateFirst) || string.IsNullOrEmpty(dateSecond))
            {
                query = "SELECT [Order].id_Order, [Order].id_Client_FK, [Client].FIO, [Order].id_Bus_Fk, [Bus].Name_car, [Order].date, [Order].cost " +
                            "FROM [Order] " +
                            "INNER JOIN [Bus] ON [Bus].id_Bus = [Order].id_Bus_FK " +
                            "INNER JOIN [Client] ON [Client].id_Client = [Order].id_Client_FK ";
            }
            else
            {
                query = "SELECT [Order].id_Order, [Order].id_Client_FK, [Client].FIO, [Order].id_Bus_Fk, [Bus].Name_car, [Order].date, [Order].cost " +
                            "FROM [Order] " +
                            "INNER JOIN [Bus] ON [Bus].id_Bus = [Order].id_Bus_FK " +
                            "INNER JOIN [Client] ON [Client].id_Client = [Order].id_Client_FK " +
                            $"WHERE [Order].date > '{dateFirst}' AND [Order].date < '{dateSecond}'";
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Order";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public string DeleteRec(string id)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"DELETE FROM [Order] WHERE id_Order={id};";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
            return "Ok";
        }

        [WebMethod]
        public DataTable GetClientSelectData()
        {
            string query = "SELECT * FROM Client";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Client";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetBusSelectData()
        {
            string query = "SELECT * FROM Bus";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Bus";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }


        [WebMethod]
        public string RecCheck(string id_Client, string id_Bus, string date, string cost)
        {
            string query = $"SELECT COUNT(1) FROM [Order] WHERE [Order].id_Client_FK = {id_Client} AND [Order].id_BUS_FK = {id_Bus} AND [Order].date = '{date}' AND [Order].cost='{cost}'";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Order";
                            sda.Fill(dt);
                            return dt.Rows[0][0].ToString();
                        }
                    }
                }
            }
        }

        String connectionString = "Data Source=RentBus.mssql.somee.com;Initial Catalog=RentBus;Persist Security Info=True;User ID=XxX_OLEG_XxX_SQLLogin_1;Password=i7yteijxu1";
    }
}
