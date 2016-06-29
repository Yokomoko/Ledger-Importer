using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SageImporterLibrary;
using System.ComponentModel;

namespace Jonas_Sage_Importer
{
    class JonasImporterEnums
    {
        #region Public Enums

        //All Enums need a description

        public enum importSources
        {
            [Description("Sage")]
            Sage = 0,
            [Description("Great Plains")]
            Great_Plains = 1,
            [Description("CRM")]
            CRM = 2
        }

        public enum sageImportTypes
        {
            [Description("Invoice")]
            Invoice = 0,
            [Description("Sales Order")]
            Sales_Order = 1
        }

        public enum greatPlainsImportTypes
        {
            [Description("Invoice (EPOS AR)")]
            Invoice_EposAR = 0,
            [Description("Invoices Posted to P+L (CSS DOWNLOAD)")]
            Invoices_Posted_to_P_L = 1,
            [Description("Outstanding Invoices")]
            Outstanding_Invoices = 2
        }

        public enum crmImportTypes
        {
            [Description("Sales Order")]
            Sales_Order = 0
        }

        #endregion
    }

    class Jonas
    {
        private static string ConnectionString()
        {
            return DbConnectionsCs.ConnectionString();
        }

        /// <summary>
        /// The DbName from DbConnectionsCs class in order to reference what the database name it is importing into is.
        /// </summary>
        /// <returns></returns>
        private static string DbNameTxt()
        {
            return DbConnectionsCs.DbNameTxt();
        }

        public static void ImportInvoices(string command, DataTable tbl, string ImpName)
        {
            using (SqlConnection sqconn = new SqlConnection(ConnectionString()))
            {
                using (SqlCommand sqcomm = new SqlCommand(command, sqconn))
                {
                    LogToText.WriteToLog($"{ImpName}: Attempting to import to temporary table in the database");
                    sqcomm.Connection = sqconn;
                    sqcomm.CommandType = CommandType.StoredProcedure;
                    sqcomm.Parameters.AddWithValue("@tblLedger", tbl);
                    sqcomm.CommandText = command;
                    sqconn.Open();
                    sqcomm.ExecuteNonQuery();
                }
                string tempSuccess = $"{ImpName}: Successfully imported to temporary table in the {DbNameTxt()} database";
                LogToText.WriteToLog(tempSuccess);
            }
        }

        public static void CommitImport(string command, string impName)
        {
            try
            {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand sqcomm = new SqlCommand(command, sqconn))
                    {
                        LogToText.WriteToLog($"{impName}: Attempting to commit new data to database.");
                        sqcomm.Connection = sqconn;
                        sqcomm.CommandType = CommandType.StoredProcedure;
                        sqcomm.CommandText = command;
                        sqconn.Open();
                        sqcomm.ExecuteNonQuery();
                    }
                }
                string commitSuccess = $"{impName}: Successfully committed new data to the {DbNameTxt()} database";
                LogToText.WriteToLog(commitSuccess);
            }
            catch (System.Exception ex)
            {
                string commitFailure = $"{impName}: Error committing data to the database: \n{ex.Message}";
                LogToText.WriteToLog(commitFailure);
                MessageBox.Show(commitFailure, @"Failed");
            }
        }

        public static void DeletePreviousOrders(string ImpName)
        {
            var dialogResult = MessageBox.Show(
                @"Would you like to remove all previously entered sales orders?", @"Sales Orders", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
            {
                LogToText.WriteToLog($"{ImpName}: Previously entered sales orders were not deleted from the database.");
                return;
            }
            try
            {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand sqcomm = new SqlCommand("Sage_DeletePreviousOrders", sqconn))
                    {
                        LogToText.WriteToLog($"{ImpName}: Deleting Previous Sales Orders");
                        sqcomm.Connection = sqconn;
                        sqcomm.CommandType = CommandType.StoredProcedure;
                        sqcomm.CommandText = "Sage_DeletePreviousOrders";
                        sqconn.Open();
                        sqcomm.ExecuteNonQuery();
                    }
                }
                string deleteSuccess = $"{ImpName}: Deleted previous orders from the {DbNameTxt()} database.";
                LogToText.WriteToLog(deleteSuccess);
            }
            catch (Exception ex)
            {
                string deleteFailure = $"{ImpName}: Error deleting previous orders from database: \n {ex.Message}";
                LogToText.WriteToLog(deleteFailure);
                MessageBox.Show(deleteFailure, "Failed");
            }
        }

        public static void DeleteHistoricalCheck(ComboBox sourceComboBox, ComboBox typeComboBox, bool removeNewer, DateTime removeNewerDt)
        {
            if (sourceComboBox.SelectedIndex == 1)
            {
                if (removeNewer)
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            $"Are you sure you would like to delete {typeComboBox.SelectedText} newer than {removeNewerDt} (inclusive)?\n\nYou will not be able to recover this information.",
                            @"Confirm Delete?",
                            MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        DeleteHistoricalLedger(typeComboBox.SelectedIndex, removeNewerDt, sourceComboBox.Text);
                    }
                }
            }
            return;
        }

        public static void DeleteHistoricalLedger(int commandType, DateTime removeDateTime, string ImpName)
        {
            string command = string.Empty;
            string tableName = string.Empty;

            if (commandType == 0)
            {
                tableName = "SaleLedger";
                command = $"Delete from {tableName} where Date >= @removeDateTime and ([Type] = 'Invoice' or [Type] = 'Return') and ImportType = 'Great Plains'";
            }
            else if (commandType == 1)
            {
                tableName = "PostedInvoices";
                command = $"Delete from {tableName} where TrxDate >= @removeDateTime";
            }
            else if (commandType == 2)
            {
                tableName = "OutstandingInvoices";
                command = $"Delete from {tableName} where Date >= @removeDateTime";
            }

            try
            {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand sqcomm = new SqlCommand(command, sqconn))
                    {
                        LogToText.WriteToLog($"{ImpName}: Attempting to delete {tableName} newer than {removeDateTime}.");
                        sqcomm.Connection = sqconn;
                        sqcomm.CommandType = CommandType.Text;
                        sqcomm.CommandText = command;
                        sqcomm.Parameters.Add(new SqlParameter("@removeDateTime", removeDateTime));
                        sqconn.Open();
                        sqcomm.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
