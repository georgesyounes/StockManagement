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
    public partial class Suppliers : Form
    {
        Excel.Application xlApp = new Excel.Application();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            string s3 = textBox2.Text;
            string s4 = textBox5.Text;






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

                xlWorkSheet.Cells[1, 2] = "Number";

                xlWorkSheet.Cells[1, 3] = "Email";



               






                xlWorkSheet.Cells[2, 1] = textBox1.Text;

                xlWorkSheet.Cells[2, 2] = textBox2.Text;

                xlWorkSheet.Cells[2, 3] = textBox5.Text;






                xlWorkBook.SaveAs(@"C:\db\suppliers.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Quit();



                Marshal.ReleaseComObject(xlWorkSheet);

                Marshal.ReleaseComObject(xlWorkBook);

                Marshal.ReleaseComObject(xlApp);



               




                MessageBox.Show("New Suppliers Added ");


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
        }
    }
}
