using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceOnIIS
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        String connectionString = @"Data Source=DESKTOP-TVRETF9\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True";


        public DataTable GetOrderData()
        {
            var query = "SELECT [order].Id,  [provider].provider_name, [Order].date, [Order].cost " +
                        "FROM [Order] " +
                        "INNER JOIN [provider] ON [provider].provider_id = [order].provider_FK";


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
                            dt.TableName = "order";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public DataTable GetProviderData()
        {
            string query = "SELECT * FROM provider";
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
                            dt.TableName = "provider";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public string InsertOrder(string date, string provider_id, int cost)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"INSERT INTO [order] VALUES ('{date}',{provider_id},{cost})";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
            return "Готово";
        }

        public string InsertProvider(string name)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"INSERT INTO [provider] VALUES ('{name}')";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
            return "Готово";
        }

        public string RecCheckOrder(string date, string provider_id, int cost)
        {
            string query = $"SELECT COUNT(1) FROM [order] WHERE [order].date = '{date}' AND [order].provider_fk='{provider_id}' AND [order].cost='{cost}'";
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
                            dt.TableName = "order";
                            sda.Fill(dt);
                            return dt.Rows[0][0].ToString();
                        }
                    }
                }
            }
        }

        public string RecCheckProvider(string name)
        {
            string query = $"SELECT COUNT(1) FROM [provider] WHERE [provider].provider_name = '{name}'";
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
                            dt.TableName = "provider";
                            sda.Fill(dt);
                            return dt.Rows[0][0].ToString();
                        }
                    }
                }
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
