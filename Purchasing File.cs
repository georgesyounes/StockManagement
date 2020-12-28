using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    public partial class Purchasing_File : Form
    {
        Excel.Application xlApp = new Excel.Application();
        public Purchasing_File()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Purchasing_File_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            string s3 = textBox4.Text;
            string s4 = textBox5.Text;
            string s5 = textBox6.Text;
            string s6 = textBox7.Text;
            string s7 = textBox8.Text;
            string s8 = textBox9.Text;
            string s9 = textBox10.Text;
            string s10 = textBox11.Text;
            string s11 = textBox12.Text;
            string s12 = textBox13.Text;
            string s13 = textBox14.Text;



            if (s == "" | s3 == "" | s4 == "" | s5 == "" | s6 == "" | s7 == "" | s8 == "" | s9 == "" | s10 == "" | s11 == "" | s12 == "" | s13 == "")
            {
                MessageBox.Show("Cannot save Please insert all value");
            }

            else
            {

                if (xlApp == null)
                {
                    MessageBox.Show("error");
                }





                Excel.Workbook xlWorkBook;

                Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;



                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



                xlWorkSheet.Cells[1, 1] = "Invoice Number";

                xlWorkSheet.Cells[1, 2] = "Suppliers";

                xlWorkSheet.Cells[1, 3] = "Total";



                xlWorkSheet.Cells[1, 4] = "Payments";







                xlWorkSheet.Cells[2, 1] = textBox1.Text;

                xlWorkSheet.Cells[2, 2] = comboBox3.SelectedItem.ToString();
                xlWorkSheet.Cells[2, 3] = textBox16.Text;
                xlWorkSheet.Cells[2, 4] = textBox17.Text;








                xlWorkBook.SaveAs(@"C:\db\Invoice.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Quit();



                Marshal.ReleaseComObject(xlWorkSheet);

                Marshal.ReleaseComObject(xlWorkBook);

                Marshal.ReleaseComObject(xlApp);



                MessageBox.Show("Invoice Saved ");
            }

            /*
                        string s = textBox1.Text;

                        string s3 = textBox4.Text;
                        string s4 = textBox5.Text;
                        string s5 = textBox6.Text;
                        string s6 = textBox7.Text;
                        string s7 = textBox8.Text;
                        string s8 = textBox9.Text;
                        string s9 = textBox10.Text;
                        string s10 = textBox11.Text;
                        string s11 = textBox12.Text;
                        string s12 = textBox13.Text;
                        string s13 = textBox14.Text;



                        if (s == "" |   s3 == "" | s4 == "" | s5 == "" | s6 == "" | s7 == "" | s8 == "" | s9 == "" | s10 == "" | s11 == "" | s12 == "" | s13 == "")
                        {
                            MessageBox.Show("Cannot save Please insert all value");
                        }

                        else
                        {



                            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open(@"C:\db\salman.xls");
                            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                            x.Cells[2, 1] = textBox1.Text;




                            x.Cells[2, 1] = textBox1.Text;

                            x.Cells[2, 2] = textBox2.Text;
                            x.Cells[2, 3] = comboBox1.SelectedItem.ToString();
                            x.Cells[2, 4] = comboBox4.SelectedItem.ToString();


                          x.Cells[2, 6] = textBox3.Text;


                            sheet.Close(true, Type.Missing , Type.Missing);
                            excel.Quit();







                            MessageBox.Show("Save successful"); 
                        }
                        */
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            String s = textBox7.Text;

            

            
            if (s.Equals("panadol 30") | (s.Equals("123456789")))
            {
                textBox8.Text = "panadol 30 caps";
                textBox9.Text = "Panadol";
                textBox10.Text = "capsules";
                textBox11.Text = "123456789";
                textBox12.Text = "0";
                textBox2.Text = "2250";
                textBox14.Text = "3000";
                textBox15.Text = "22";
                textBox3.Text = "11";
                textBox13.Text = "22";
                maskedTextBox1.Text = "20/12/2021";
                

               

            }

            if (s.Equals("Panadol 500mg 24 Tabs") | (s.Equals("5010006100715")))
            {
                textBox8.Text = "Panadol 500mg 24 Tabs";
                textBox9.Text = "Panadol";
                textBox10.Text = "capsules";
                textBox11.Text = "5010006100715";
                textBox12.Text = "0";
                textBox2.Text = "2250";
                textBox14.Text = "3000";
                textBox15.Text = "22";
                textBox3.Text = "11";
                textBox13.Text = "22";
                maskedTextBox1.Text = "20/12/2021";




            }


            if (s.Equals("Panadol Advance 500MG 72 tabs") | (s.Equals("9502930975010")))
            {
                textBox8.Text = "Panadol Advance 500MG 72 tabs";
                textBox9.Text = "Panadol";
                textBox10.Text = "capsules";
                textBox11.Text = "9502930975010";
                textBox12.Text = "0";
                textBox2.Text = "2250";
                textBox14.Text = "10000";
                textBox15.Text = "22";
                textBox3.Text = "11";
                textBox13.Text = "22";
                maskedTextBox1.Text = "20/12/2021";




            }

            if (s.Equals("Panadol Cold & Flu day 24 Tabs") | (s.Equals("8829207")))
            {
                textBox8.Text = "Panadol Cold & Flu day 24 Tabs";
                textBox9.Text = "Panadol";
                textBox10.Text = "capsules";
                textBox11.Text = "8829207";
                textBox12.Text = "0";
                textBox2.Text = "2250";
                textBox14.Text = "3000";
                textBox15.Text = "22";
                textBox3.Text = "11";
                textBox13.Text = "22";
                maskedTextBox1.Text = "20/12/2021";




            }

                if (s.Equals("Panadol Night 24 Caps") | (s.Equals("8812605")))
                {
                    textBox8.Text = "Panadol Night 24 Caps";
                    textBox9.Text = "Panadol";
                    textBox10.Text = "capsules";
                    textBox11.Text = "123456789";
                    textBox12.Text = "0";
                    textBox2.Text = "2250";
                    textBox14.Text = "3000";
                    textBox15.Text = "22";
                    textBox3.Text = "11";
                    textBox13.Text = "22";
                    maskedTextBox1.Text = "20/12/2021";

                }
           


            

            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             

            textBox3.Clear();
            textBox2.Clear();
            textBox7.Clear();
            textBox15.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
           
            maskedTextBox1.Clear();
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barcode Printing...");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing in Process...");
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


            String name;
            int qty;
            int discount;
            String EDL;
            int BilledPrice;
            int total;
            int payments;
            int totaldiscount;

            
    

            discount = int.Parse(textBox15.Text);
            BilledPrice = int.Parse(textBox2.Text);
            name = (textBox8.Text);
            qty = int.Parse(textBox12.Text);
             EDL = (maskedTextBox1.Text);

            total = qty * BilledPrice;
            
           totaldiscount = (total * discount) / 100;


            //payments = comboBox1.SelectedItem.Equals("USD") ? (total - totaldiscount) / 1500 : total - totaldiscount;
            payments = total - discount;

            textBox17.Text = "" + payments;



            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count-1; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            
            textBox16.Text = sum.ToString();
           




            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.ColumnCount - 2;




          

            dataGridView1.Rows.Add(textBox8.Text, textBox12.Text, textBox3.Text, textBox15.Text, maskedTextBox1.Text, textBox2.Text, total);



        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox15.Text = "0";
                textBox13.Text = "100";

            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
