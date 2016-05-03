using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace SageImporterLibrary
{
    using System.Reflection;

    public class ExcelImport
    {
        private static int columnSize = 16;
        //private static bool populateSuccess;

        public static int ColumnSize()
        {
            return columnSize;
        }

        //test

        public static OpenFileDialog ExcelDialogBox(OpenFileDialog excelFileFind)
        {
            excelFileFind.Title = @"Please Select a File";
            excelFileFind.FileName = "";
            excelFileFind.ValidateNames = true;
            excelFileFind.Filter = @"Excel Worksheets|*.xls;*.xlsx";
            excelFileFind.FilterIndex = 1;

            return excelFileFind;

        }

        public static BindingSource ExcelDialogFind(OpenFileDialog excelFileFind, TextBox directoryBox, ComboBox excelSheetName, DataGridView excelGridView, BindingSource tableBindingSource)
        {


            System.IO.Stream strm = null;

            try
            {
                strm = excelFileFind.OpenFile();
            }
            catch (System.IO.IOException ioex)
            {
                MessageBox.Show($"File is being used elsewhere. Please close the file and try again. \n {ioex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: \n {ex.Message}");
            }


            directoryBox.Text = excelFileFind.FileName.ToString();
            Type officeType = Type.GetTypeFromProgID("Excel.Application");

            if (officeType == null)
            {
                MessageBox.Show(@"Excel is not installed. Please install Excel and try again.");
            }
            else
            {
                Excel.Application oXL = null;

                try
                {
                    strm?.Close();
                    try
                    {
                        oXL = new Excel.Application { Visible = false };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unable to open Excel document. \n \n + {ex.Message}", @"Error");
                        if (oXL == null)
                        {
                            oXL.Quit();
                            return null;
                        }
                        return null;
                    }

                    var oWb = oXL.Workbooks.Open(directoryBox.Text, ReadOnly: true);

                    excelSheetName.Items.Clear();
                    foreach (Excel.Worksheet oSheet in oWb.Sheets)
                    {
                        excelSheetName.Items.Add(oSheet.Name);
                    }
                    excelSheetName.SelectedIndex = 0;
                    oWb.Close(0);
                    oXL.Application.Quit();

                    
                }
                catch (ApplicationException noExcel)
                {
                    MessageBox.Show($"Unable to open Excel document. Excel may not be installed." +
                                    $"Please install Microsoft Excel Viewer or Microsoft Office and try again. \n \n {noExcel.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading Excel document. \n \n {ex.Message}");
                }

                // GetData(excelSheetName.Text, directoryBox);
            }



            excelGridView.DataSource = tableBindingSource;
            return tableBindingSource;
        }

        private static System.Data.OleDb.OleDbDataAdapter GetDataAdapter(string selectCommand, TextBox directoryBox)
        {
            string connectionString = ($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={directoryBox.Text}" +
                                       @";Extended Properties= ""Excel 8.0;HDR=Yes;IMEX=2""");

            System.Data.OleDb.OleDbConnection connectionBuilder = new System.Data.OleDb.OleDbConnection(connectionString);

            string command = ($"select * from [{selectCommand}$]");

            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(command, connectionBuilder);

            return adapter;
        }


        private static DataTable FillDataTable(System.Data.OleDb.OleDbDataAdapter adapter)
        {
            DataTable dTable = new DataTable();

            DataTable daTab = new DataTable();

            try
            {

                dTable.Rows.Clear();
                adapter.Fill(dTable);

                return dTable;
            }
            catch (InvalidOperationException ioexception)
            {
                MessageBox.Show(
                    $"64-Bit OLEDB Provider for ODBC Not Installed."
                    + @"Please go to the Resources folder in your install directory (Default C:\Program Files (x86)\Eposgroup\Jonas Ledger Management Tool\Resources) and run Ace.exe" + $"\n \n {ioexception.Message}");
            }
            catch (ArgumentException argex)
            {
                LogToText.WriteToLog($"This is an informational message. Argument Exception. {argex.Message}");
                return daTab;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. \n \n {ex.Message} \n \n {ex.InnerException}");
                return daTab;
            }
            return daTab;
        }


        private static DataTable TableValidation(DataTable dTable)
        {
            DateTime dati = new DateTime(2015, 01, 01);

            try
            {
                    var rows = (
                        from DataRow r in dTable.AsEnumerable().Cast<DataRow>()
                        where r.Field<DateTime?>(dTable.Columns[0].ColumnName) < dati
                        select r).ToArray();
                    var CountRowsExcluded = rows.Length.ToString();

                    foreach (DataRow row in rows)
                    {
                        dTable.Rows.Remove(row);
                    }

                    MessageBox.Show(
                        $"{CountRowsExcluded} were earlier than 01/01/2015 and were automatically removed.");

                    return dTable;
                }
            catch (Exception)
            {

                return dTable;
            }
        }


        private static DataTable RemoveExcessColumns(DataTable dTable)
        {
            int ColumnSize = 17;
            int originalSize = dTable.Columns.Count;


            if (originalSize > ColumnSize)
            {
                MessageBox.Show($"There were {ColumnSize} columns expected but there were actually {originalSize}." +
                                $"Extra columns will be automatically removed. \n Please ensure that you have selected " +
                                $"the correct spreadsheet.");
                while (dTable.Columns.Count > columnSize)
                {
                    dTable.Columns.RemoveAt(columnSize);
                }
            }

            return dTable;

        }


        public static DataTable GetData(string selectCommand, TextBox directoryBox)
        {
            OleDbDataAdapter dAdapter = GetDataAdapter(selectCommand, directoryBox);
            DataTable internalTable = FillDataTable(dAdapter);
            internalTable = TableValidation(internalTable);
            internalTable = RemoveExcessColumns(internalTable);

            return internalTable;
        }

    }
}
