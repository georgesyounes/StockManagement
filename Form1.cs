using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String s = textBox1.Text;

    


            if (s.Equals("panadol 30") | (s.Equals("123456789")))
            {
                textBox6.Text = "panadol 30 caps";
                textBox5.Text = "Sadco";
                textBox4.Text = "panadol";
                textBox2.Text = "Medicals";
                textBox3.Text = "3000";
               



            }

            if (s.Equals("Panadol 500mg 24 Tabs") | (s.Equals("5010006100715")))
            {
                textBox6.Text = "Panadol 500mg 24 Tabs";
                textBox5.Text = "Sadco";
                textBox4.Text = "panadol";
                textBox2.Text = "Medicals";
                textBox3.Text = "4000";




            }


            if (s.Equals("Panadol Advance 500MG 72 tabs") | (s.Equals("9502930975010")))
            {
                textBox6.Text = "Panadol Advance 500MG 72 tabs";
                textBox5.Text = "Sadco";
                textBox4.Text = "panadol";
                textBox2.Text = "Medicals";
                textBox3.Text = "6200";



            }

            if (s.Equals("Panadol Cold & Flu day 24 Tabs") | (s.Equals("8829207")))
            {
                textBox6.Text = "Panadol Cold & Flu day 24 Tabs";
                textBox5.Text = "Sadco";
                textBox4.Text = "panadol";
                textBox2.Text = "Medicals";
                textBox3.Text = "5000";


            }

            if (s.Equals("Panadol Night 24 Caps") | (s.Equals("8812605")))
            {
                textBox6.Text = "Panadol Night 24 Caps";
                textBox5.Text = "Sadco";
                textBox4.Text = "panadol";
                textBox2.Text = "Medicals";
                textBox3.Text = "3000";

            }

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
