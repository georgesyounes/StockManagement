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

    public partial class Stock : Form
    {
        Excel.Application xlApp = new Excel.Application();

        private int childFormNumber = 0;

        public Stock()
        {
            InitializeComponent();
        }

        private void producsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchasing_File main = new Purchasing_File();
            main.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("French"))
            {
                producsToolStripMenuItem.Text = "Stock";
                purchaseToolStripMenuItem.Text = "Achats ";
                clientsToolStripMenuItem.Text = "Clientes";
                salesListToolStripMenuItem.Text = "Ventes";
                paymentsToolStripMenuItem.Text = "Paiements";
                languagesToolStripMenuItem.Text = "Langues";

            }

            else
            {
                producsToolStripMenuItem.Text = "Stock";
                purchaseToolStripMenuItem.Text = "Purchases ";
                clientsToolStripMenuItem.Text = "Clients";
                salesListToolStripMenuItem.Text = "Sales";
                paymentsToolStripMenuItem.Text = "Payments";
                languagesToolStripMenuItem.Text = "Languages";
            }
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers main = new Suppliers();
            main.Show();

               
        }

        private void createNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add main = new add();
            main.Show();
        }

        private void searchForAnItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1  main = new Form1();
            main.Show();
            /* Excel.Workbook xlWorkBook;

             Excel.Worksheet xlWorkSheet;

             object misValue = System.Reflection.Missing.Value;



             xlWorkBook = xlApp.Workbooks.Add(misValue);

             xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);




             //  if( xlWorkSheet.Cells.Value = TextBox.Text);
             //   xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1).displayInfo();










             xlWorkBook.Close(true, misValue, misValue);

             xlApp.Quit();



             Marshal.ReleaseComObject(xlWorkSheet);

             Marshal.ReleaseComObject(xlWorkBook);

             Marshal.ReleaseComObject(xlApp);



             MessageBox.Show("Item Created ");
 */


        }
    }
}
