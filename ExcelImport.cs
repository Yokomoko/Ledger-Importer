using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using TextBox = System.Windows.Forms.TextBox;

namespace SageImporterLibrary
{
    public class ExcelImport
    {
        private static int columnSize = 17;
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
            excelFileFind.Filter = @"Excel Worksheets|*.xls;*.xlsx;*.csv";
            excelFileFind.FilterIndex = 1;

            return excelFileFind;

        }

        public static BindingSource ExcelDialogFind(OpenFileDialog excelFileFind, TextBox directoryBox, ComboBox excelSheetName, DataGridView excelGridView, BindingSource tableBindingSource)
        {


            Stream strm = null;

            try
            {
                strm = excelFileFind.OpenFile();
            }
            catch (IOException ioex)
            {
                MessageBox.Show($"File is being used elsewhere. Please close the file and try again. \n {ioex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: \n {ex.Message}");
            }


            directoryBox.Text = excelFileFind.FileName;
            Type officeType = Type.GetTypeFromProgID("Excel.Application");

            if (officeType == null)
            {
                MessageBox.Show(@"Excel is not installed. Please install Excel and try again.");
            }
            else
            {
                Application oXL = null;
                try
                {
                    strm?.Close();
                    try
                    {
                        oXL = new Application { Visible = false };
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
                    foreach (Worksheet oSheet in oWb.Sheets)
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

        private static OleDbDataAdapter GetDataAdapter(string selectCommand, TextBox directoryBox)
        {
            string connectionString = ($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={directoryBox.Text}" +
                                       @";Extended Properties= ""Excel 8.0;HDR=Yes;IMEX=2""");

            OleDbConnection connectionBuilder = new OleDbConnection(connectionString);

            string command = ($"select * from [{selectCommand}$]");

            OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionBuilder);

            return adapter;
        }


        private static DataTable FillDataTable(DbDataAdapter adapter)
        {
            var dTable = new DataTable();

            var daTab = new DataTable();

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
                    var countRowsExcluded = rows.Length.ToString();

                    foreach (DataRow row in rows)
                    {
                        dTable.Rows.Remove(row);
                    }

                    MessageBox.Show(
                        $"{countRowsExcluded} were earlier than 01/01/2015 and were automatically removed.");

                    return dTable;
                }
            catch (Exception)
            {

                return dTable;
            }
        }


        private static DataTable RemoveExcessColumns(DataTable dTable)
        {
            int originalSize = dTable.Columns.Count;
            if (originalSize == 41)
            {
                MessageBox.Show($"The application has detected {originalSize} in this spreadsheet.\n8 Columns will automatically be trimmed from the beginning and 16 from the end in order to comply with import standards.");
                for (int i = 0; i < 8; i++)
                {
                    dTable.Columns.RemoveAt(0);
                }
                while (dTable.Columns.Count > columnSize)
                {
                    dTable.Columns.RemoveAt(columnSize);
                }

                DataTable dTableClone = dTable.Clone();
                dTableClone.Columns[4].DataType = typeof(string);
                dTableClone.Columns[6].DataType = typeof(string);
                dTableClone.Columns[7].DataType = typeof(string);
                foreach (DataRow row in dTable.Rows)
                {
                    dTableClone.ImportRow(row);
                }

                return dTableClone;

            }
            if (columnSize > originalSize)
            {
                MessageBox.Show($"There were {columnSize} columns expected but there were actually {originalSize}." +
                                $"Extra columns will be automatically removed from the end.\n Please ensure that you have selected " +
                                $"the correct spreadsheet.");
                while (dTable.Columns.Count > columnSize)
                {
                    dTable.Columns.RemoveAt(columnSize);
                }
                
            }
            return dTable;
        }

        public static string FormatDate(string input, string goalFormat, string[] formats)
        {
            var c = CultureInfo.CurrentCulture;
            var s = DateTimeStyles.None;
            var result = default(DateTime);

            if (DateTime.TryParseExact(input, formats, c, s, out result))
                return result.ToString(goalFormat);

            throw new FormatException("Unhandled input format: " + input);
        }

        public static DataTable GetData(string selectCommand, TextBox directoryBox)
        {
            OleDbDataAdapter dAdapter = GetDataAdapter(selectCommand, directoryBox);
            DataTable internalTable = FillDataTable(dAdapter);
            //internalTable = TableValidation(internalTable);
            internalTable = RemoveExcessColumns(internalTable);
            //DataTable intTestTable = internalTable;

            return internalTable;
            //return internalTable;
        }

    }
}
