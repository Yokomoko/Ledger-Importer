using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SageImporterLibrary;
using Telerik.WinControls.UI;
using System.Data.Sql;

namespace Jonas_Sage_Importer {
    class JonasImporterEnums {
        #region Public Enums

        //All Enums need a description

        public enum ImportSources {
            [Description("Great Plains")]
            Great_Plains = 1,
            [Description("OpenCRM")]
            OpenCrm = 2
        }

        public enum SageImportTypes {
            [Description("Invoice")]
            Invoice = 0,
            [Description("Sales Order")]
            Sales_Order = 1
        }

        public enum GreatPlainsImportTypes {
            [Description("Invoice (EPOS AR)")]
            Invoice_EposAR = 0,
            [Description("Invoices Posted to P+L (CSS DOWNLOAD)")]
            Invoices_Posted_to_P_L = 1,
            [Description("Outstanding Invoices")]
            Outstanding_Invoices = 2
        }

        public enum CrmImportTypes {
            [Description("Sales Order")]
            Sales_Order = 0
        }

        #endregion
    }

    class Jonas {
        private static string ConnectionString() {
            return DbConnectionsCs.ConnectionString();
        }

        /// <summary>
        /// The DbName from DbConnectionsCs class in order to reference what the database name it is importing into is.
        /// </summary>
        /// <returns></returns>
        private static string DbNameTxt() {
            return DbConnectionsCs.DbNameTxt();
        }

        public static void ImportInvoices(string command, DataTable tbl, string ImpName) {

            var comm = command;

            if (command == "CRM_Grid_ImportOrders") {
                foreach (DataRow dr in tbl.Rows) {
                    using (SqlConnection sqconn = new SqlConnection(ConnectionString())) {
                        using (SqlCommand sqcomm = new SqlCommand(command, sqconn)) {
                            LogToText.WriteToLog(
                                $"{ImpName}: Attempting to import row {tbl.Rows.IndexOf(dr)} to temporary table in the database");

                            var minicol = 14;
                            var ddcol = 20;
                            switch (dr[minicol].ToString().Trim().ToLower()) {
                                case "0":
                                    break;
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "-":
                                    dr[minicol] = 0;
                                    break;
                                case ".":
                                    dr[minicol] = 0;
                                    break;
                                case "n/a":
                                    dr[minicol] = 0;
                                    break;
                                case "no":
                                    dr[minicol] = 0;
                                    break;
                                case "pending":
                                    dr[minicol] = 1;
                                    break;
                                case "chasing":
                                    dr[minicol] = 2;
                                    break;
                                case "yes":
                                    dr[minicol] = 3;
                                    break;
                                default:
                                    dr[minicol] = 4;
                                    break;
                            }
                            //DirectDebit from text to int
                            switch (dr[ddcol].ToString().Trim().ToLower()) {
                                case "0":
                                    break;
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "-":
                                    dr[ddcol] = 0;
                                    break;
                                case ".":
                                    dr[ddcol] = 0;
                                    break;
                                case "n/a":
                                    dr[ddcol] = 0;
                                    break;
                                case "no":
                                    dr[ddcol] = 0;
                                    break;
                                case "pending":
                                    dr[ddcol] = 1;
                                    break;
                                case "chasing":
                                    dr[ddcol] = 2;
                                    break;
                                case "yes":
                                    dr[ddcol] = 3;
                                    break;
                                default:
                                    dr[ddcol] = 4;
                                    break;
                            }
                            sqcomm.CommandType = CommandType.StoredProcedure;
                            sqcomm.Parameters.AddWithValue("@Date", dr[0]);
                            sqcomm.Parameters.AddWithValue("@CustName", dr[1]);
                            sqcomm.Parameters.AddWithValue("@SiteName", dr[2]);
                            sqcomm.Parameters.AddWithValue("@CustRef", dr[3]);
                            sqcomm.Parameters.AddWithValue("@DueDate", dr[4]);
                            sqcomm.Parameters.AddWithValue("@Category", dr[5]);
                            sqcomm.Parameters.AddWithValue("@ItemDescription", dr[6]);
                            sqcomm.Parameters.AddWithValue("@Qty", dr[7]);
                            sqcomm.Parameters.AddWithValue("@Net", dr[8]);
                            sqcomm.Parameters.AddWithValue("@Tax", dr[9]);
                            sqcomm.Parameters.AddWithValue("@Gross", dr[10]);
                            sqcomm.Parameters.AddWithValue("@Profit", dr[11]);
                            sqcomm.Parameters.AddWithValue("@Currency", dr[12]);
                            sqcomm.Parameters.AddWithValue("@CustOrderNo", dr[13]);
                                if (tbl.Columns.Count >= 21) {
                                    comm = "CRM_Grid_ImportOrders_Adv";
                                    sqcomm.Parameters.AddWithValue("@MiniPack", dr[14]);
                                    sqcomm.Parameters.AddWithValue("@SiteSurveyDate", dr[15]);
                                    sqcomm.Parameters.AddWithValue("@BacklogComments", dr[16]);
                                    sqcomm.Parameters.AddWithValue("@Deposit", dr[17]);
                                    sqcomm.Parameters.AddWithValue("@AssignedTo", dr[18]);
                                    sqcomm.Parameters.AddWithValue("@MegJobNo", dr[19]);
                                    sqcomm.Parameters.AddWithValue("@DirectDebit", dr[20]);
                                }
                                if (tbl.Columns.Count == 22) {
                                    comm = "CRM_Grid_ImportOrders_Adv2";
                                    sqcomm.Parameters.AddWithValue("@Spare1", dr[21]);
                                }
                                if (tbl.Columns.Count == 23) {
                                    comm = "CRM_Grid_ImportOrders_Adv3";
                                    sqcomm.Parameters.AddWithValue("@Spare2", dr[22]);
                                }
                                sqcomm.CommandText = comm;
                                sqconn.Open();
                                sqcomm.ExecuteNonQuery();
                        }
                    }
                }
            }
            else {
                using (SqlConnection sqconnother = new SqlConnection(ConnectionString())) {
                    using (SqlCommand sqcomm = new SqlCommand(comm, sqconnother)) {
                        sqcomm.Connection = sqconnother;
                        sqcomm.CommandType = CommandType.StoredProcedure;
                        sqcomm.Parameters.AddWithValue("@tblLedger", tbl);
                        sqcomm.CommandText = command;
                        sqconnother.Open();
                        //statusStripBar.Text = "Attempting to import to temporary table.";
                        sqcomm.ExecuteNonQuery();
                    }
                    string tempSuccess =
                        $"{ImpName}: Successfully imported to temporary table in the {DbNameTxt()} database";
                    LogToText.WriteToLog(tempSuccess);
                }
            }
            //return returnMessage;
        }

        public static void CommitImport(string command, string impName) {
            try {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString())) {
                    using (SqlCommand sqcomm = new SqlCommand(command, sqconn)) {
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
            catch (Exception ex) {
                string commitFailure = $"{impName}: Error committing data to the database: \n{ex.Message}";
                LogToText.WriteToLog(commitFailure);
                MessageBox.Show(commitFailure, @"Failed");
            }
        }

        public static void DeletePreviousOrders(string ImpName) {
            var dialogResult = MessageBox.Show(
                @"Would you like to remove all previously entered sales orders?", @"Sales Orders", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) {
                LogToText.WriteToLog($"{ImpName}: Previously entered sales orders were not deleted from the database.");
                return;
            }
            try {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString())) {
                    using (SqlCommand sqcomm = new SqlCommand("Sage_DeletePreviousOrders", sqconn)) {
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
            catch (Exception ex) {
                string deleteFailure = $"{ImpName}: Error deleting previous orders from database: \n {ex.Message}";
                LogToText.WriteToLog(deleteFailure);
                MessageBox.Show(deleteFailure, "Failed");
            }
        }

        public static void DeleteHistoricalCheck(RadDropDownList sourceComboBox, RadDropDownList typeComboBox, bool removeNewer, DateTime removeNewerDt) {
            if (sourceComboBox.SelectedIndex == 1) {
                if (removeNewer) {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            $"Are you sure you would like to delete {typeComboBox.SelectedText} newer than {removeNewerDt} (inclusive)?\n\nYou will not be able to recover this information.",
                            @"Confirm Delete?",
                            MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) {
                    }
                    else {
                        DeleteHistoricalLedger(typeComboBox.SelectedIndex, removeNewerDt, sourceComboBox.Text);
                    }
                }
            }
        }

        public static void DeleteHistoricalLedger(int commandType, DateTime removeDateTime, string ImpName) {
            string command = string.Empty;
            string tableName = string.Empty;

            if (commandType == 0) {
                tableName = "SaleLedger";
                command = $"Delete from {tableName} where Date >= @removeDateTime and ([Type] = 'Invoice' or [Type] = 'Return') and ImportType = 'Great Plains'";
            }
            else if (commandType == 1) {
                tableName = "PostedInvoices";
                command = $"Delete from {tableName} where TrxDate >= @removeDateTime";
            }
            else if (commandType == 2) {
                tableName = "OutstandingInvoices";
                command = $"Delete from {tableName} where Date >= @removeDateTime";
            }

            try {
                using (SqlConnection sqconn = new SqlConnection(ConnectionString())) {
                    using (SqlCommand sqcomm = new SqlCommand(command, sqconn)) {
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
            catch (Exception) {
                throw;
            }
        }
    }

}
