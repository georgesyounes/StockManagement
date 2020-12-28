using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=8080;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runQuery();
           
            if ((textBox1.Text == "georges") &(textBox2.Text == "younes"))
            {
                this.Hide();
                Stock main = new Stock();
                main.Show();
            }
            
            else
            {
                MessageBox.Show("Wrong username or password!!");
            }
        }
        private void runQuery()
        {
            string query = textBox1.Text;
            if (query =="")
            {
                MessageBox.Show("please insert username");
            }
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
