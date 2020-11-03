using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Client.ServiceReference1;


namespace Client
{
    public partial class Form1 : Form
    {
        Service1Client sessionClient = new Service1Client("NetTcpBinding_IService1");
        static Uri address = new Uri("net.tcp://localhost:9733/Design_Time_Addresses/Service1/");
        NetTcpBinding binding = new NetTcpBinding();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                sessionClient.ConnectionInfo(binding.Name, address.Port.ToString(), address.LocalPath,
                    address.ToString(), address.Scheme);
                string id_stud = comboBox1.SelectedValue.ToString();
                string id_dis = comboBox1.SelectedValue.ToString();
                string cost = numericUpDown1.Value.ToString();
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                if (sessionClient.RecCheck(id_dis, id_stud, date, cost).Equals("1"))
                {
                    MessageBox.Show("Такая запись уже существует!");
                }
                else
                {                    
                    MessageBox.Show(sessionClient.InsertMethod(id_stud, id_dis, date, cost));
                    sessionClient.CountOfDBRows(dataGridView1.Rows.Count.ToString());
                    this.FillTable();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//"Нет связи с сервером, получается".ToString());
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sessionClient.ConnectionInfo(binding.Name, address.Port.ToString(), address.LocalPath,
                    address.ToString(), address.Scheme);
                comboBox2.DataSource = sessionClient.GetBusSelectData();
                comboBox2.DisplayMember = "Name_car";
                comboBox2.ValueMember = "id_Bus";
                comboBox1.DataSource = sessionClient.GetClientSelectData();
                comboBox1.DisplayMember = "FIO";
                comboBox1.ValueMember = "id_Client";
                FillTable();
            }
            catch
            {
                MessageBox.Show("Нет связи с сервером, получается".ToString());
                Close();
            }
        }

        public void FillTable()
        {
            dataGridView1.DataSource = sessionClient.GetData();
            dataGridView1.Columns[0].HeaderText = "Код записи";
            dataGridView1.Columns[1].HeaderText = "Код Клиента";
            dataGridView1.Columns[2].HeaderText = "ФИО Клиента";
            dataGridView1.Columns[3].HeaderText = "Код Автобуса";
            dataGridView1.Columns[4].HeaderText = "Название автобуса";
            dataGridView1.Columns[5].HeaderText = "Стоимость";
            dataGridView1.Columns[6].HeaderText = "Дата";
            dataGridView1.Update();

        }
    }
}
