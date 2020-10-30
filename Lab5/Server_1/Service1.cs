using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server_1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public void DoWork()
        {

        }

        public DataTable GetData()
        {
            var query = "SELECT [Order].id_Order, [Order].id_Client_FK, [Client].FIO, [Order].id_Bus_Fk, [Bus].Name_car, [Order].date, [Order].cost " +
                        "FROM [Order] " +
                        "INNER JOIN [Bus] ON [Bus].id_Bus = [Order].id_Bus_FK " +
                        "INNER JOIN [Client] ON [Client].id_Client = [Order].id_Client_FK ";
            

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

        public string InsertMethod(string id_Client, string id_Bus, string date, string cost)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"INSERT INTO [Order] VALUES ({id_Client},{id_Bus},'{date}',{cost})";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
            using (var con=new SqlConnection(query))
            {
                using (var cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
            return "Готово";
        }

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
