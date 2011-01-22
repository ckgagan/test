using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Demo
{
    public partial class voucher : Form
    {
        public voucher(Journal parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void getParent(){

        }

        private void codeNumberTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void voucher_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void debitCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            int cnt = -1;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            OleDbConnection thisConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AyumiDB1.mdb");
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT CodeNumber, Particular, LF, DebitCredit, Amount FROM JournalVoucher";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            //cnt = 1;
            //while (thisReader.Read())
            //{
            //    cnt++;
            //    excel.Cells[cnt, 1] = thisReader["CodeNumber"];
            //    excel.Cells[cnt, 2] = thisReader["Particular"];
            //    excel.Cells[cnt, 3] = thisReader["LF"];
            //    excel.Cells[cnt, 4] = thisReader["DebitCredit"];
            //    excel.Cells[cnt, 5] = thisReader["Amount"];
            //}
            //thisReader.Close();
            //thisConnection.Close();
            //// Global missing reference for objects we are not defining...
            //object missing = System.Reflection.Missing.Value;
            //// If wanting to Save the workbook...
            //workbook.SaveAs("MyExcelWorkBook.xls",Excel.XlFileFormat.xlXMLSpreadsheet, missing, missing,false, false, Excel.XlSaveAsAccessMode.xlNoChange,missing, missing, missing, missing, missing);
            //// If wanting to make Excel visible and activate the worksheet...
            //excel.Visible = true;
            //Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;
            //((Excel._Worksheet)worksheet).Activate();
            //// If wanting excel to shutdown...
            //((Excel._Application)excel).Quit();

            //MessageBox.Show("Excel file created , you can find the file c:\\csharp-Excel.xls");

            while (thisReader.Read())
            {
                cnt++;
                MessageBox.Show(thisReader["CodeNumber"].GetType().ToString());
                xlWorkSheet.Cells[cnt, 1] = thisReader["CodeNumber"].ToString();
                xlWorkSheet.Cells[cnt, 2] = thisReader["Particular"].ToString();
                xlWorkSheet.Cells[cnt, 3] = thisReader["LF"].ToString();
                xlWorkSheet.Cells[cnt, 4] = thisReader["DebitCredit"].ToString();
                xlWorkSheet.Cells[cnt, 5] = thisReader["Amount"].ToString();
            }
            thisReader.Close();
            thisConnection.Close();
            xlWorkBook.SaveAs("csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void voucher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayumiDB1DataSet1.CodeName' table. You can move, or remove it, as needed.
            this.codeNameTableAdapter.Fill(this.ayumiDB1DataSet1.CodeName);

        }
    }
}