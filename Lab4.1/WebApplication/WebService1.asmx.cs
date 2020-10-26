using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace WebApplication
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
        public string InsertMethod(string id_stud, string id_dis, string date, string mark)
        {           
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"INSERT INTO Ocenki VALUES ({id_stud},{id_dis},'{date}',{mark})";
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
            if(string.IsNullOrEmpty(dateFirst) || string.IsNullOrEmpty(dateSecond))
            {
                query = "SELECT Ocenki.id_o, Ocenki.id_stud, Students.FIO, Ocenki.id_dis, Dis.name_dis, Ocenki.date, Ocenki.ocenka " +
                            "FROM Ocenki " +
                            "INNER JOIN Dis ON Dis.id_dis = Ocenki.id_dis " +
                            "INNER JOIN Students ON Students.id = Ocenki.id_stud";
            }
            else
            {
                query = "SELECT Ocenki.id_o, Ocenki.id_stud, Students.FIO, Ocenki.id_dis, Dis.name_dis, Ocenki.date, Ocenki.ocenka " +
                            "FROM Ocenki " +
                            "INNER JOIN Dis ON Dis.id_dis = Ocenki.id_dis " +
                            "INNER JOIN Students ON Students.id = Ocenki.id_stud " +
                            $"WHERE Ocenki.date > '{dateFirst}' AND Ocenki.date < '{dateSecond}'";
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
                            dt.TableName = "Ocenki";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public void DeleteRec(string id)
        {
            var connect = new SqlConnection(connectionString);
            connect.Open();
            var query = $"DELETE FROM Ocenki WHERE id_o={id};";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();            
        }

        [WebMethod]
        public DataTable GetNameStudSelectData()
        {
            string query = "SELECT * FROM Students";
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
                            dt.TableName = "Students";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }            
        }

        [WebMethod]
        public DataTable GetDisSelectData()
        {
            string query = "SELECT * FROM Dis";
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
                            dt.TableName = "Dis";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }


        [WebMethod]
        public string RecCheck(string id_dis, string id_stud, string date, string ocenka)
        {
            string query = $"SELECT COUNT(1) FROM Ocenki WHERE Ocenki.id_stud = {id_stud} AND Ocenki.id_dis = {id_dis} AND Ocenki.date = '{date}' AND Ocenki.ocenka='{ocenka}'";
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
                            dt.TableName = "Ocenki";
                            sda.Fill(dt);
                            return dt.Rows[0][0].ToString();
                        }
                    }
                }
            }           
        }
        String connectionString = "Data Source=Students.mssql.somee.com;Initial Catalog=Students;Persist Security Info=True;User ID=denissfloww_SQLLogin_1;Password=z83vqec9dp";
    }
}
