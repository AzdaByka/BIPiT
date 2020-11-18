using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class Form1 : Form
    {
        private Service1Client sessionClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sessionClient = new Service1Client();
            tabControl1_SelectedIndexChanged(null, null);
            FillTable();
        }

        public void FillTable()
        {
            dataGridView1.DataSource = sessionClient.GetOrderData();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Поставщик";
            dataGridView1.Columns[3].HeaderText = "Сумма";
            dataGridView1.Update();
            dataGridView2.DataSource = sessionClient.GetProviderData();
            dataGridView2.Columns[0].HeaderText = "Номер поставщика";
            dataGridView2.Columns[1].HeaderText = "Имя поставщика";
            dataGridView2.Update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string provider_id = comboBox1.SelectedValue.ToString();
            int cost = (int)numericUpDown1.Value;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (sessionClient.RecCheckOrder(date, provider_id, cost).Equals("1"))
            {
                MessageBox.Show("Такая запись уже существует!");
            }
            else
            {
                MessageBox.Show(sessionClient.InsertOrder(date, provider_id, cost));
                FillTable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string provider_name = textBox1.Text;
            if (provider_name == "")
            {
                MessageBox.Show("Заполните поле имя поствщика");
            }
            if (sessionClient.RecCheckProvider(provider_name).Equals("1"))
            {
                MessageBox.Show("Такая запись уже существует!");
            }
            else
            {
                MessageBox.Show(sessionClient.InsertProvider(provider_name));
                FillTable();
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = sessionClient.GetProviderData();
            comboBox1.DisplayMember = "provider_name";
            comboBox1.ValueMember = "provider_id";
        }
    }
}
