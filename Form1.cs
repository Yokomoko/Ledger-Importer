namespace Jonas_Sage_Importer
{
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.DirectoryServices.ActiveDirectory;
    using System.Reflection;

    using SageImporterLibrary;

    using System.Threading;
    using System.Windows.Forms;
    using System.Drawing.Text;
    using System.IO;
    using System.Runtime.Remoting.Channels;
    using System.Windows.Forms.VisualStyles;

    using Microsoft.Office.Interop.Excel;
    //using Microsoft.SqlServer.Types;
    using Microsoft.Win32;

    using Application = System.Windows.Forms.Application;
    using DataTable = System.Data.DataTable;
    using Rectangle = System.Drawing.Rectangle;

    public partial class Form1 : Form
    {
        protected OleDbDataAdapter DataAdapter = new OleDbDataAdapter();
        protected BindingSource TableBindingSource = new BindingSource();
        protected DataTable Table = new DataTable();

        public static Form1 _form1 = new Form1();

        public Form1()
        {
            InitializeComponent();
            _form1 = this;
        }


        private void Form1Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            this.Top = (screen.Height / 2) - (this.Height / 2);
            this.Left = (screen.Width / 2) - (this.Width / 2);
            this.Text = Application.ProductName;
            this.dTRemoveNewerThan.Value = DateTime.Today;

            this.StatusStripLabel.Text = @"OK";
            this.TopMost = true;
            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

        }


        /*
        public void UpdateStatusStripLabel(string labelText)
        {
            this.StatusStripLabel.Text = labelText;
        }
        */
        private void DirectorySelectionClick(object sender, EventArgs e)
        {
            /*
            else
            {
                if (ExcelImport.ExcelDialogBox(this.gpExcelFileFind).ShowDialog()
                    != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                try
                {
                    this.Table = ExcelImport.GetData(this.gpWorksheetCombo.Text, this.gpExcelSheetName);
                }
                catch (ArgumentException iaex)
                {
                    LogToText.WriteToLog($"Invalid Argument (Might have pressed close on the directory box - {iaex}");
                    return;
                }
                this.TableBindingSource.DataSource = this.Table;
            }
            */
            if (this.ImportTypeCombo.SelectedIndex == -1)
            {
                MessageBox.Show(@"Please select an import type first.");
            }
            else
            {
                if (ExcelImport.ExcelDialogBox(this.ExcelFileFind).ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                try
                {
                    this.Table = ExcelImport.GetData(this.ExcelSheetName.Text, this.DirectoryBox);
                }
                catch (ArgumentException iaex)
                {
                    LogToText.WriteToLog($"Invalid Argument (Might have pressed close on the directory box - {iaex}");
                    return;
                }
                this.TableBindingSource.DataSource = this.Table;
            }
        }

        private void ExcelFileFindFileOk(object sender, CancelEventArgs e)
        {
            this.TableBindingSource = ExcelImport.ExcelDialogFind(
                this.ExcelFileFind,
                this.DirectoryBox,
                this.ExcelSheetName,
                this.ExcelGridView,
                this.TableBindingSource);
        }

        private void ImportFileClick(object sender, EventArgs e)
        {
            string attempting = "Attempting to Import";
            string failed = "Failed to Import";


            if (this.DirectoryBox.Text == "")
            {
                MessageBox.Show(@"Please select an Excel sheet.", @"Error");
            }
            else
            {
                if (this.ImportTypeCombo.SelectedIndex == 0)
                {
                    //Import to Temporary Table
                    try
                    {

                        this.StatusStripLabel.Text = $"{attempting} Invoices from Application.";
                        Sage.ImportInvoices("Sage_Grid_ImportInvoices", this.Table);
                        this.StatusStripLabel.Text = "";
                    }
                    catch (Exception ex)
                    {
                        string failedToImport = $"{failed} Invoices from Application.";
                        this.StatusStripLabel.Text = $"{failedToImport}";
                        MessageBox.Show($"{failedToImport} \n \n {ex.Message}", @"Failed");
                        return;
                    }
                    //Import to Main Database Table
                    try
                    {
                        this.StatusStripLabel.Text = $"{attempting} Invoices from Temporary Table.";
                        Sage.CommitImport("Sage_Temp_ImportInvoices");
                        this.StatusStripLabel.Text = @"Successfully imported invoices.";
                    }
                    catch (Exception ex)
                    {
                        string failedToImport = $"{failed} Invoices from Temporary Table.";
                        this.StatusStripLabel.Text = $"{failedToImport}";
                        MessageBox.Show($"{failedToImport} \n \n {ex.Message}");
                        return;
                    }
                }
                else if (this.ImportTypeCombo.SelectedIndex == 1)
                {
                    this.StatusStripLabel.Text = $"{attempting} Sales Orders from Application.";
                    try
                    {
                        Sage.ImportInvoices("Sage_Grid_ImportOrders", this.Table);
                        this.StatusStripLabel.Text = "";
                    }
                    catch (Exception ex)
                    {
                        string failedToImport = $"{failed} Sales Orders from Application.";
                        this.StatusStripLabel.Text = $"{failedToImport}";
                        MessageBox.Show($"{failedToImport} \n \n {ex.Message}", @"Failed");
                        return;
                    }
                    Sage.DeletePreviousOrders();

                    try
                    {
                        this.StatusStripLabel.Text = $"{attempting} Sales Orders from Temporary Table";
                        Sage.CommitImport("Sage_Temp_ImportOrders");
                        this.StatusStripLabel.Text = @"Successfully imported Sales Orders.";
                    }
                    catch (Exception ex)
                    {
                        string failedToImport = $"{failed} Sales Orders from Temporary Table.";
                        this.StatusStripLabel.Text = $"{failedToImport} \n \n {ex.Message}";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(@"Please Select an Import Type.", @"Error");
                }
                DbConnectionsCs.LogImport(DirectoryBox.Text, this.ImportTypeCombo.Text, this.ExcelGridView.RowCount);
            }
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            
        }

 private void UpdateBtnClick(object sender, EventArgs e)
        {
            if (this.ExcelSheetName.Text != "" || ExcelSheetName.Text != null)
            {
                try
                {
                    this.ExcelGridView.DataSource = this.TableBindingSource;
                    this.Table = ExcelImport.GetData(ExcelSheetName.Text, DirectoryBox);
                    this.TableBindingSource.DataSource = this.Table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating. \n \n {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(@"Sheet name can not be blank.");
            }
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox { TopMost = true };
            box.ShowDialog();
        }

        private void ConnectionSettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection
                                                  {
                                                      TopMost = true,
                                                      StartPosition = FormStartPosition.CenterScreen
                                                  };
            dbConnection.Activate();
            dbConnection.ShowDialog();
        }

        private void DbLocationTxtBoxTextChanged(object sender, EventArgs e)
        {

        }

        private void NominalCodeEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            NominalCodeEditor codeEditor = new NominalCodeEditor
                                               {
                                                   TopMost = true,
                                                   StartPosition = FormStartPosition.CenterScreen
                                               };    
            codeEditor.Show();
        }

        private void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GpImportFileBtnClick(object sender, EventArgs e)
        {
            GreatPlains.ImportInvoices(this.gpImportTypeCombo,this.chkBoxRemoveNewerThan.Checked, this.dTRemoveNewerThan.Value, this.Table);
            
            
        DbConnectionsCs.LogImport(this.gpExcelSheetName.Text, this.gpImportTypeCombo.Text, this.gpExcelGridView.RowCount);
            //MessageBox.Show(@"Not currently implemented.",@"Error");
        }

        private void GpBrowseForSheetBtnClick(object sender, EventArgs e)
        {
        
            if (this.gpImportTypeCombo.SelectedIndex == -1)
            {
                MessageBox.Show(@"Please select an import type first.");
            }
            else
            {
                if (ExcelImport.ExcelDialogBox(this.gpExcelFileFind).ShowDialog()
                    != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                try
                {
                    this.Table = ExcelImport.GetData(this.gpWorksheetCombo.Text, this.gpExcelSheetName);
                }
                catch (ArgumentException iaex)
                {
                    LogToText.WriteToLog($"Invalid Argument (Might have pressed close on the directory box - {iaex}");
                    return;
                }
                this.TableBindingSource.DataSource = this.Table;
            }
        }

        private void GpExcelFileFindFileOk(object sender, CancelEventArgs e)
        {
            this.TableBindingSource = ExcelImport.ExcelDialogFind(
                this.gpExcelFileFind,
                this.gpExcelSheetName,
                this.gpWorksheetCombo,
                this.gpExcelGridView,
                this.TableBindingSource);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBoxRemoveNewerThan.Checked)
            {
                this.dTRemoveNewerThan.Enabled = true;
            }
            else
            {
                this.dTRemoveNewerThan.Enabled = false;
            }
        }



        private void customerLedgerByGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportViewer rViewer = new ReportViewer {TopMost = true};

            this.CreateNewReportWindow(@"/Sales Backlog and Raised Invoices");
        }


        private void invoicesPostedToPAndLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateNewReportWindow(@"/Invoices Posted to P and L");
        }

        private void customerStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateNewReportWindow(@"/Customer Statement");
        }

        private void CreateNewReportWindow(string path)
        {
            bool stopTimer = false;

            Loading lS = new Loading { TopMost = true };
            lS.UpdateText($"Loading Report, please wait...\nThis may take up to a minute the first time the report is generated.");

            if (this.IsSqlClrTypesInstalled() == true)
            {
                if (this.IsReportViewerInstalled() == true)
                {
                    try
                    {
                        while (stopTimer == false)
                        {
                            lS.Show();
                            lS.Update();
                            ReportViewer rViewer = new ReportViewer
                                                       {
                                                           TopMost = true,
                                                           StartPosition = FormStartPosition.CenterScreen
                                                       };
                            rViewer.ReportServerPathName(path);
                            rViewer.Show();
                            stopTimer = true;
                        }
                    }
                catch (FileNotFoundException fex)
                {
                    MessageBox.Show(
                        $"Pre-requisite files are not found. Please ensure Report Viewer 2012 is installed\n\n{fex.Message}");
                }
                catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading reports.\n\n{ex.Message}");
                    }
                }
                else
                {
                    if (MessageBox.Show(
                            $"Microsoft Report Viewer is not installed.\n\n"
                           + @"Do you want to install this now?", @"Report Viewer is not installed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show(@"This application will now be minimised.");
                        this.WindowState = FormWindowState.Minimized;
                        Process.Start($@"{System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Resources\ReportViewer2012.msi");
                    }
                    else
                    {
                        return;
                    }

                }
            }
            else
            {
                if (MessageBox.Show(
                    $"Microsoft CLR Types are not installed.\n\n" + @"Do you want to install this now?",
                    @"Microsoft CLR Types are not installed",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(@"This application will now be minimised");
                    this.WindowState = FormWindowState.Minimized;
                    Process.Start(
                        $@"{System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Resources\SQLSysClrTypes2012.msi");
                }
                else
                {
                    return;
                }
            }
            lS.Hide();

            if (lS.Visible == true)
            {
                lS.Hide();
            }
        }
        /// <summary>
        /// returns true if ReportViewer OR ReportViewer Language Pack is installed
        /// </summary>
        /// <returns></returns>
        public bool IsReportViewerInstalled()
        {
                RegistryKey registryBase = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, string.Empty);
                if (registryBase != null)
                {
                    // check the two possible reportviewer v10 registry keys
                    return registryBase.OpenSubKey(@"Software\Microsoft\ReportViewer\v2.0.50727") != null
                        || registryBase.OpenSubKey(@"Software\Microsoft\ReportViewer\v9.0") != null
                        || registryBase.OpenSubKey(@"Software\Wow6432Node\Microsoft\.NETFramework\v2.0.50727\AssemblyFoldersEx\ReportViewer v10") != null
                        || registryBase.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\ReportViewer\v10.0") != null
                        || registryBase.OpenSubKey(@"SOFTWARE\Classes\Installer\Products\2443504FAD987B24B9C51B984CC4CB42") !=null
                        ;
                }
        else 
            return false;
        }
        public bool IsSqlClrTypesInstalled()
        {
            RegistryKey registryBase = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, string.Empty);
            if (registryBase != null)
            {
                return registryBase.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\RefCount\SQLSysClrTypes") != null
                    || registryBase.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\RefCount\SQLSysClrTypes11") != null
                    || registryBase.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server 2014 Redist\SQL Server System CLR Types") != null;
            }
            else
            {
                return false;
            }
        }
        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void UpdateStripText(string message)
        {
            this.StatusStripLabel.Text = message;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void gpUpdateDataGridBtn_Click(object sender, EventArgs e)
        {

        }



    }
}