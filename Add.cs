using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp1
{
    public partial class add : Form
    {
        Excel.Application xlApp = new Excel.Application();


        public add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            string s3 = textBox2.Text;
            string s4 = textBox3.Text;
            
            



            if (s == "" | s3 == "" | s4 == "")
            {
                MessageBox.Show("All information are required to create a new product!!!");
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



                xlWorkSheet.Cells[1, 1] = "Name";

                xlWorkSheet.Cells[1, 2] = "Barcode";

                xlWorkSheet.Cells[1, 3] = "Suppliers";



                xlWorkSheet.Cells[1, 4] = "Departments";

                xlWorkSheet.Cells[1, 5] = "Category";


                xlWorkSheet.Cells[1, 6] = "Brand";






                xlWorkSheet.Cells[2, 1] = textBox1.Text;

                xlWorkSheet.Cells[2, 2] = textBox2.Text;
                xlWorkSheet.Cells[2, 3] = comboBox1.SelectedItem.ToString();
                xlWorkSheet.Cells[2, 4] = comboBox3.SelectedItem.ToString();
                xlWorkSheet.Cells[2, 5] = comboBox2.SelectedItem.ToString();

                xlWorkSheet.Cells[2, 6] = textBox3.Text;







                xlWorkBook.SaveAs(@"C:\db\products.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Quit();



                Marshal.ReleaseComObject(xlWorkSheet);

                Marshal.ReleaseComObject(xlWorkBook);

                Marshal.ReleaseComObject(xlApp);



                MessageBox.Show("Item Created ");



                Stock main = new Stock();
                main.Show();










            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
