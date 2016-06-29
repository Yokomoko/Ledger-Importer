namespace Jonas_Sage_Importer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExcelFileFind = new System.Windows.Forms.OpenFileDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerLedgerByGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesPostedToPAndLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominalCodeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jonasGroupEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabSage = new System.Windows.Forms.TabPage();
            this.ImportTypeCombo = new System.Windows.Forms.ComboBox();
            this.ImportTypeOldLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExcelGridView = new System.Windows.Forms.DataGridView();
            this.debuglbl = new System.Windows.Forms.Label();
            this.ImportFile = new System.Windows.Forms.Button();
            this.LblExcelSheetSelect = new System.Windows.Forms.Label();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ExcelSheetName = new System.Windows.Forms.ComboBox();
            this.DirectorySelection = new System.Windows.Forms.Button();
            this.TabDynamicsGP = new System.Windows.Forms.TabPage();
            this.lblRemoveWarning = new System.Windows.Forms.Label();
            this.dTRemoveNewerThan = new System.Windows.Forms.DateTimePicker();
            this.chkBoxRemoveNewerThan = new System.Windows.Forms.CheckBox();
            this.gpImportTypeCombo = new System.Windows.Forms.ComboBox();
            this.gpImportTypeLbl = new System.Windows.Forms.Label();
            this.gpUpdateDataGridBtn = new System.Windows.Forms.Button();
            this.gpExcelGridView = new System.Windows.Forms.DataGridView();
            this.gpImportFileBtn = new System.Windows.Forms.Button();
            this.gpExcelSheet = new System.Windows.Forms.Label();
            this.gpExcelSheetName = new System.Windows.Forms.TextBox();
            this.dpSelectWorksheetlbl = new System.Windows.Forms.Label();
            this.gpWorksheetCombo = new System.Windows.Forms.ComboBox();
            this.gpBrowseForSheetBtn = new System.Windows.Forms.Button();
            this.uxMainTc = new System.Windows.Forms.TabControl();
            this.uxAllTb = new System.Windows.Forms.TabPage();
            this.uxImportSourceCmbo = new System.Windows.Forms.ComboBox();
            this.uxImportSourceLbl = new System.Windows.Forms.Label();
            this.uxInclusiveLbl = new System.Windows.Forms.Label();
            this.uxRemoveNewerRecordsDt = new System.Windows.Forms.DateTimePicker();
            this.uxRemoveNewerRecordsChk = new System.Windows.Forms.CheckBox();
            this.uxImportTypeCmbo = new System.Windows.Forms.ComboBox();
            this.uxImportTypeLbl = new System.Windows.Forms.Label();
            this.uxWorksheetUpdateBtn = new System.Windows.Forms.Button();
            this.uxExcelSheetViewerGv = new System.Windows.Forms.DataGridView();
            this.uxImportBtn = new System.Windows.Forms.Button();
            this.uxExcelSheetLbl = new System.Windows.Forms.Label();
            this.uxExcelSheetTxt = new System.Windows.Forms.TextBox();
            this.uxWorksheetLbl = new System.Windows.Forms.Label();
            this.uxExcelWorksheetCmbo = new System.Windows.Forms.ComboBox();
            this.uxExcelBrowseBtn = new System.Windows.Forms.Button();
            this.gpExcelFileFind = new System.Windows.Forms.OpenFileDialog();
            this.StatusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TabSage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).BeginInit();
            this.TabDynamicsGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpExcelGridView)).BeginInit();
            this.uxMainTc.SuspendLayout();
            this.uxAllTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxExcelSheetViewerGv)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 504);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip1.Size = new System.Drawing.Size(694, 22);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 28;
            this.StatusStrip1.Text = "StatusStrip1";
            this.StatusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1_ItemClicked);
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.StatusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ExcelFileFind
            // 
            this.ExcelFileFind.FileName = "OpenFileDialog1";
            this.ExcelFileFind.FileOk += new System.ComponentModel.CancelEventHandler(this.ExcelFileFindFileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerLedgerByGroupToolStripMenuItem,
            this.invoicesPostedToPAndLToolStripMenuItem,
            this.customerStatementToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customerLedgerByGroupToolStripMenuItem
            // 
            this.customerLedgerByGroupToolStripMenuItem.Name = "customerLedgerByGroupToolStripMenuItem";
            this.customerLedgerByGroupToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.customerLedgerByGroupToolStripMenuItem.Text = "Sales Backlog and Raised Invoices";
            this.customerLedgerByGroupToolStripMenuItem.Click += new System.EventHandler(this.customerLedgerByGroupToolStripMenuItem_Click);
            // 
            // invoicesPostedToPAndLToolStripMenuItem
            // 
            this.invoicesPostedToPAndLToolStripMenuItem.Name = "invoicesPostedToPAndLToolStripMenuItem";
            this.invoicesPostedToPAndLToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.invoicesPostedToPAndLToolStripMenuItem.Text = "Invoices Posted to P and L";
            this.invoicesPostedToPAndLToolStripMenuItem.Click += new System.EventHandler(this.invoicesPostedToPAndLToolStripMenuItem_Click);
            // 
            // customerStatementToolStripMenuItem
            // 
            this.customerStatementToolStripMenuItem.Name = "customerStatementToolStripMenuItem";
            this.customerStatementToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.customerStatementToolStripMenuItem.Text = "Customer Statement";
            this.customerStatementToolStripMenuItem.Click += new System.EventHandler(this.customerStatementToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominalCodeEditorToolStripMenuItem,
            this.jonasGroupEditorToolStripMenuItem,
            this.connectionSettingsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // nominalCodeEditorToolStripMenuItem
            // 
            this.nominalCodeEditorToolStripMenuItem.Name = "nominalCodeEditorToolStripMenuItem";
            this.nominalCodeEditorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nominalCodeEditorToolStripMenuItem.Text = "Nominal Code Editor";
            this.nominalCodeEditorToolStripMenuItem.Click += new System.EventHandler(this.NominalCodeEditorToolStripMenuItemClick);
            // 
            // jonasGroupEditorToolStripMenuItem
            // 
            this.jonasGroupEditorToolStripMenuItem.Enabled = false;
            this.jonasGroupEditorToolStripMenuItem.Name = "jonasGroupEditorToolStripMenuItem";
            this.jonasGroupEditorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.jonasGroupEditorToolStripMenuItem.Text = "Jonas Group Editor";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Connection Settings";
            this.connectionSettingsToolStripMenuItem.Click += new System.EventHandler(this.ConnectionSettingsToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Enabled = false;
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // TabSage
            // 
            this.TabSage.Controls.Add(this.ImportTypeCombo);
            this.TabSage.Controls.Add(this.ImportTypeOldLbl);
            this.TabSage.Controls.Add(this.UpdateBtn);
            this.TabSage.Controls.Add(this.ExcelGridView);
            this.TabSage.Controls.Add(this.debuglbl);
            this.TabSage.Controls.Add(this.ImportFile);
            this.TabSage.Controls.Add(this.LblExcelSheetSelect);
            this.TabSage.Controls.Add(this.DirectoryBox);
            this.TabSage.Controls.Add(this.Label2);
            this.TabSage.Controls.Add(this.ExcelSheetName);
            this.TabSage.Controls.Add(this.DirectorySelection);
            this.TabSage.Location = new System.Drawing.Point(4, 22);
            this.TabSage.Name = "TabSage";
            this.TabSage.Padding = new System.Windows.Forms.Padding(3);
            this.TabSage.Size = new System.Drawing.Size(690, 450);
            this.TabSage.TabIndex = 0;
            this.TabSage.Text = "Sage";
            this.TabSage.UseVisualStyleBackColor = true;
            // 
            // ImportTypeCombo
            // 
            this.ImportTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImportTypeCombo.FormattingEnabled = true;
            this.ImportTypeCombo.Items.AddRange(new object[] {
            "Invoice",
            "Sales Order"});
            this.ImportTypeCombo.Location = new System.Drawing.Point(132, 11);
            this.ImportTypeCombo.Name = "ImportTypeCombo";
            this.ImportTypeCombo.Size = new System.Drawing.Size(240, 21);
            this.ImportTypeCombo.TabIndex = 14;
            // 
            // ImportTypeOldLbl
            // 
            this.ImportTypeOldLbl.AutoSize = true;
            this.ImportTypeOldLbl.Location = new System.Drawing.Point(61, 15);
            this.ImportTypeOldLbl.Name = "ImportTypeOldLbl";
            this.ImportTypeOldLbl.Size = new System.Drawing.Size(63, 13);
            this.ImportTypeOldLbl.TabIndex = 13;
            this.ImportTypeOldLbl.Text = "Import Type";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(392, 72);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(112, 23);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ExcelGridView
            // 
            this.ExcelGridView.AllowUserToAddRows = false;
            this.ExcelGridView.AllowUserToDeleteRows = false;
            this.ExcelGridView.AllowUserToResizeRows = false;
            this.ExcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ExcelGridView.Location = new System.Drawing.Point(4, 143);
            this.ExcelGridView.Name = "ExcelGridView";
            this.ExcelGridView.ReadOnly = true;
            this.ExcelGridView.RowHeadersVisible = false;
            this.ExcelGridView.Size = new System.Drawing.Size(682, 219);
            this.ExcelGridView.TabIndex = 11;
            // 
            // debuglbl
            // 
            this.debuglbl.AutoSize = true;
            this.debuglbl.Location = new System.Drawing.Point(17, 171);
            this.debuglbl.Name = "debuglbl";
            this.debuglbl.Size = new System.Drawing.Size(0, 13);
            this.debuglbl.TabIndex = 10;
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(294, 370);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(93, 40);
            this.ImportFile.TabIndex = 0;
            this.ImportFile.Text = "Import File";
            this.ImportFile.UseVisualStyleBackColor = true;
            this.ImportFile.Click += new System.EventHandler(this.ImportFileClick);
            // 
            // LblExcelSheetSelect
            // 
            this.LblExcelSheetSelect.AutoSize = true;
            this.LblExcelSheetSelect.Location = new System.Drawing.Point(16, 46);
            this.LblExcelSheetSelect.Name = "LblExcelSheetSelect";
            this.LblExcelSheetSelect.Size = new System.Drawing.Size(112, 13);
            this.LblExcelSheetSelect.TabIndex = 6;
            this.LblExcelSheetSelect.Text = "Select an Excel Sheet";
            // 
            // DirectoryBox
            // 
            this.DirectoryBox.Location = new System.Drawing.Point(132, 42);
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.ReadOnly = true;
            this.DirectoryBox.Size = new System.Drawing.Size(240, 20);
            this.DirectoryBox.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 76);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Select a Worksheet";
            // 
            // ExcelSheetName
            // 
            this.ExcelSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExcelSheetName.FormattingEnabled = true;
            this.ExcelSheetName.Location = new System.Drawing.Point(132, 72);
            this.ExcelSheetName.Name = "ExcelSheetName";
            this.ExcelSheetName.Size = new System.Drawing.Size(240, 21);
            this.ExcelSheetName.TabIndex = 5;
            // 
            // DirectorySelection
            // 
            this.DirectorySelection.Location = new System.Drawing.Point(392, 42);
            this.DirectorySelection.Name = "DirectorySelection";
            this.DirectorySelection.Size = new System.Drawing.Size(112, 23);
            this.DirectorySelection.TabIndex = 3;
            this.DirectorySelection.Text = "Browse";
            this.DirectorySelection.UseVisualStyleBackColor = true;
            this.DirectorySelection.Click += new System.EventHandler(this.DirectorySelectionClick);
            // 
            // TabDynamicsGP
            // 
            this.TabDynamicsGP.Controls.Add(this.lblRemoveWarning);
            this.TabDynamicsGP.Controls.Add(this.dTRemoveNewerThan);
            this.TabDynamicsGP.Controls.Add(this.chkBoxRemoveNewerThan);
            this.TabDynamicsGP.Controls.Add(this.gpImportTypeCombo);
            this.TabDynamicsGP.Controls.Add(this.gpImportTypeLbl);
            this.TabDynamicsGP.Controls.Add(this.gpUpdateDataGridBtn);
            this.TabDynamicsGP.Controls.Add(this.gpExcelGridView);
            this.TabDynamicsGP.Controls.Add(this.gpImportFileBtn);
            this.TabDynamicsGP.Controls.Add(this.gpExcelSheet);
            this.TabDynamicsGP.Controls.Add(this.gpExcelSheetName);
            this.TabDynamicsGP.Controls.Add(this.dpSelectWorksheetlbl);
            this.TabDynamicsGP.Controls.Add(this.gpWorksheetCombo);
            this.TabDynamicsGP.Controls.Add(this.gpBrowseForSheetBtn);
            this.TabDynamicsGP.Location = new System.Drawing.Point(4, 22);
            this.TabDynamicsGP.Margin = new System.Windows.Forms.Padding(2);
            this.TabDynamicsGP.Name = "TabDynamicsGP";
            this.TabDynamicsGP.Size = new System.Drawing.Size(690, 450);
            this.TabDynamicsGP.TabIndex = 3;
            this.TabDynamicsGP.Text = "Microsoft Dynamics GP";
            this.TabDynamicsGP.UseVisualStyleBackColor = true;
            // 
            // lblRemoveWarning
            // 
            this.lblRemoveWarning.AutoSize = true;
            this.lblRemoveWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRemoveWarning.Location = new System.Drawing.Point(377, 110);
            this.lblRemoveWarning.Name = "lblRemoveWarning";
            this.lblRemoveWarning.Size = new System.Drawing.Size(137, 13);
            this.lblRemoveWarning.TabIndex = 28;
            this.lblRemoveWarning.Text = "Note: This date is inclusive.";
            // 
            // dTRemoveNewerThan
            // 
            this.dTRemoveNewerThan.Enabled = false;
            this.dTRemoveNewerThan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTRemoveNewerThan.Location = new System.Drawing.Point(132, 106);
            this.dTRemoveNewerThan.Name = "dTRemoveNewerThan";
            this.dTRemoveNewerThan.Size = new System.Drawing.Size(239, 20);
            this.dTRemoveNewerThan.TabIndex = 26;
            this.dTRemoveNewerThan.Value = new System.DateTime(2016, 4, 21, 0, 0, 0, 0);
            // 
            // chkBoxRemoveNewerThan
            // 
            this.chkBoxRemoveNewerThan.AutoSize = true;
            this.chkBoxRemoveNewerThan.Location = new System.Drawing.Point(7, 108);
            this.chkBoxRemoveNewerThan.Name = "chkBoxRemoveNewerThan";
            this.chkBoxRemoveNewerThan.Size = new System.Drawing.Size(128, 17);
            this.chkBoxRemoveNewerThan.TabIndex = 27;
            this.chkBoxRemoveNewerThan.Text = "Remove Newer Than";
            this.chkBoxRemoveNewerThan.UseVisualStyleBackColor = true;
            this.chkBoxRemoveNewerThan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gpImportTypeCombo
            // 
            this.gpImportTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gpImportTypeCombo.FormattingEnabled = true;
            this.gpImportTypeCombo.Items.AddRange(new object[] {
            "Invoice (EPOS AR)",
            "Invoices Posted to P+L (CSS DOWNLOAD)",
            "Outstanding Invoices"});
            this.gpImportTypeCombo.Location = new System.Drawing.Point(132, 11);
            this.gpImportTypeCombo.MaxLength = 6;
            this.gpImportTypeCombo.Name = "gpImportTypeCombo";
            this.gpImportTypeCombo.Size = new System.Drawing.Size(240, 21);
            this.gpImportTypeCombo.TabIndex = 24;
            // 
            // gpImportTypeLbl
            // 
            this.gpImportTypeLbl.AutoSize = true;
            this.gpImportTypeLbl.Location = new System.Drawing.Point(61, 15);
            this.gpImportTypeLbl.Name = "gpImportTypeLbl";
            this.gpImportTypeLbl.Size = new System.Drawing.Size(63, 13);
            this.gpImportTypeLbl.TabIndex = 23;
            this.gpImportTypeLbl.Text = "Import Type";
            // 
            // gpUpdateDataGridBtn
            // 
            this.gpUpdateDataGridBtn.Location = new System.Drawing.Point(392, 72);
            this.gpUpdateDataGridBtn.Name = "gpUpdateDataGridBtn";
            this.gpUpdateDataGridBtn.Size = new System.Drawing.Size(112, 23);
            this.gpUpdateDataGridBtn.TabIndex = 22;
            this.gpUpdateDataGridBtn.Text = "Update";
            this.gpUpdateDataGridBtn.UseVisualStyleBackColor = true;
            // 
            // gpExcelGridView
            // 
            this.gpExcelGridView.AllowUserToAddRows = false;
            this.gpExcelGridView.AllowUserToDeleteRows = false;
            this.gpExcelGridView.AllowUserToResizeRows = false;
            this.gpExcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gpExcelGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gpExcelGridView.Location = new System.Drawing.Point(4, 143);
            this.gpExcelGridView.Name = "gpExcelGridView";
            this.gpExcelGridView.ReadOnly = true;
            this.gpExcelGridView.RowHeadersVisible = false;
            this.gpExcelGridView.Size = new System.Drawing.Size(682, 219);
            this.gpExcelGridView.TabIndex = 21;
            // 
            // gpImportFileBtn
            // 
            this.gpImportFileBtn.Location = new System.Drawing.Point(294, 370);
            this.gpImportFileBtn.Name = "gpImportFileBtn";
            this.gpImportFileBtn.Size = new System.Drawing.Size(93, 40);
            this.gpImportFileBtn.TabIndex = 15;
            this.gpImportFileBtn.Text = "Import File";
            this.gpImportFileBtn.UseVisualStyleBackColor = true;
            this.gpImportFileBtn.Click += new System.EventHandler(this.GpImportFileBtnClick);
            // 
            // gpExcelSheet
            // 
            this.gpExcelSheet.AutoSize = true;
            this.gpExcelSheet.Location = new System.Drawing.Point(16, 46);
            this.gpExcelSheet.Name = "gpExcelSheet";
            this.gpExcelSheet.Size = new System.Drawing.Size(112, 13);
            this.gpExcelSheet.TabIndex = 19;
            this.gpExcelSheet.Text = "Select an Excel Sheet";
            // 
            // gpExcelSheetName
            // 
            this.gpExcelSheetName.Location = new System.Drawing.Point(132, 42);
            this.gpExcelSheetName.Name = "gpExcelSheetName";
            this.gpExcelSheetName.ReadOnly = true;
            this.gpExcelSheetName.Size = new System.Drawing.Size(240, 20);
            this.gpExcelSheetName.TabIndex = 17;
            // 
            // dpSelectWorksheetlbl
            // 
            this.dpSelectWorksheetlbl.AutoSize = true;
            this.dpSelectWorksheetlbl.Location = new System.Drawing.Point(26, 76);
            this.dpSelectWorksheetlbl.Name = "dpSelectWorksheetlbl";
            this.dpSelectWorksheetlbl.Size = new System.Drawing.Size(101, 13);
            this.dpSelectWorksheetlbl.TabIndex = 20;
            this.dpSelectWorksheetlbl.Text = "Select a Worksheet";
            // 
            // gpWorksheetCombo
            // 
            this.gpWorksheetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gpWorksheetCombo.FormattingEnabled = true;
            this.gpWorksheetCombo.Location = new System.Drawing.Point(132, 72);
            this.gpWorksheetCombo.Name = "gpWorksheetCombo";
            this.gpWorksheetCombo.Size = new System.Drawing.Size(240, 21);
            this.gpWorksheetCombo.TabIndex = 18;
            // 
            // gpBrowseForSheetBtn
            // 
            this.gpBrowseForSheetBtn.Location = new System.Drawing.Point(392, 42);
            this.gpBrowseForSheetBtn.Name = "gpBrowseForSheetBtn";
            this.gpBrowseForSheetBtn.Size = new System.Drawing.Size(112, 23);
            this.gpBrowseForSheetBtn.TabIndex = 16;
            this.gpBrowseForSheetBtn.Text = "Browse";
            this.gpBrowseForSheetBtn.UseVisualStyleBackColor = true;
            this.gpBrowseForSheetBtn.Click += new System.EventHandler(this.GpBrowseForSheetBtnClick);
            // 
            // uxMainTc
            // 
            this.uxMainTc.Controls.Add(this.uxAllTb);
            this.uxMainTc.Controls.Add(this.TabDynamicsGP);
            this.uxMainTc.Controls.Add(this.TabSage);
            this.uxMainTc.Location = new System.Drawing.Point(-2, 32);
            this.uxMainTc.Name = "uxMainTc";
            this.uxMainTc.SelectedIndex = 0;
            this.uxMainTc.Size = new System.Drawing.Size(698, 476);
            this.uxMainTc.TabIndex = 27;
            this.uxMainTc.SelectedIndexChanged += new System.EventHandler(this.uxMainTb_SelectedIndexChanged);
            // 
            // uxAllTb
            // 
            this.uxAllTb.Controls.Add(this.uxImportSourceCmbo);
            this.uxAllTb.Controls.Add(this.uxImportSourceLbl);
            this.uxAllTb.Controls.Add(this.uxInclusiveLbl);
            this.uxAllTb.Controls.Add(this.uxRemoveNewerRecordsDt);
            this.uxAllTb.Controls.Add(this.uxRemoveNewerRecordsChk);
            this.uxAllTb.Controls.Add(this.uxImportTypeCmbo);
            this.uxAllTb.Controls.Add(this.uxImportTypeLbl);
            this.uxAllTb.Controls.Add(this.uxWorksheetUpdateBtn);
            this.uxAllTb.Controls.Add(this.uxExcelSheetViewerGv);
            this.uxAllTb.Controls.Add(this.uxImportBtn);
            this.uxAllTb.Controls.Add(this.uxExcelSheetLbl);
            this.uxAllTb.Controls.Add(this.uxExcelSheetTxt);
            this.uxAllTb.Controls.Add(this.uxWorksheetLbl);
            this.uxAllTb.Controls.Add(this.uxExcelWorksheetCmbo);
            this.uxAllTb.Controls.Add(this.uxExcelBrowseBtn);
            this.uxAllTb.Location = new System.Drawing.Point(4, 22);
            this.uxAllTb.Name = "uxAllTb";
            this.uxAllTb.Size = new System.Drawing.Size(690, 450);
            this.uxAllTb.TabIndex = 4;
            this.uxAllTb.Text = "All";
            this.uxAllTb.UseVisualStyleBackColor = true;
            // 
            // uxImportSourceCmbo
            // 
            this.uxImportSourceCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxImportSourceCmbo.FormattingEnabled = true;
            this.uxImportSourceCmbo.Items.AddRange(new object[] {
            "Invoice (EPOS AR)",
            "Invoices Posted to P+L (CSS DOWNLOAD)",
            "Outstanding Invoices"});
            this.uxImportSourceCmbo.Location = new System.Drawing.Point(132, 12);
            this.uxImportSourceCmbo.MaxLength = 6;
            this.uxImportSourceCmbo.Name = "uxImportSourceCmbo";
            this.uxImportSourceCmbo.Size = new System.Drawing.Size(240, 21);
            this.uxImportSourceCmbo.TabIndex = 43;
            this.uxImportSourceCmbo.SelectedIndexChanged += new System.EventHandler(this.uxImportSourceCmbo_SelectedIndexChanged);
            // 
            // uxImportSourceLbl
            // 
            this.uxImportSourceLbl.AutoSize = true;
            this.uxImportSourceLbl.Location = new System.Drawing.Point(55, 15);
            this.uxImportSourceLbl.Name = "uxImportSourceLbl";
            this.uxImportSourceLbl.Size = new System.Drawing.Size(73, 13);
            this.uxImportSourceLbl.TabIndex = 42;
            this.uxImportSourceLbl.Text = "Import Source";
            // 
            // uxInclusiveLbl
            // 
            this.uxInclusiveLbl.AutoSize = true;
            this.uxInclusiveLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uxInclusiveLbl.Location = new System.Drawing.Point(377, 140);
            this.uxInclusiveLbl.Name = "uxInclusiveLbl";
            this.uxInclusiveLbl.Size = new System.Drawing.Size(137, 13);
            this.uxInclusiveLbl.TabIndex = 41;
            this.uxInclusiveLbl.Text = "Note: This date is inclusive.";
            // 
            // uxRemoveNewerRecordsDt
            // 
            this.uxRemoveNewerRecordsDt.Enabled = false;
            this.uxRemoveNewerRecordsDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxRemoveNewerRecordsDt.Location = new System.Drawing.Point(132, 136);
            this.uxRemoveNewerRecordsDt.Name = "uxRemoveNewerRecordsDt";
            this.uxRemoveNewerRecordsDt.Size = new System.Drawing.Size(239, 20);
            this.uxRemoveNewerRecordsDt.TabIndex = 39;
            this.uxRemoveNewerRecordsDt.Value = new System.DateTime(2016, 4, 21, 0, 0, 0, 0);
            // 
            // uxRemoveNewerRecordsChk
            // 
            this.uxRemoveNewerRecordsChk.AutoSize = true;
            this.uxRemoveNewerRecordsChk.Location = new System.Drawing.Point(7, 138);
            this.uxRemoveNewerRecordsChk.Name = "uxRemoveNewerRecordsChk";
            this.uxRemoveNewerRecordsChk.Size = new System.Drawing.Size(128, 17);
            this.uxRemoveNewerRecordsChk.TabIndex = 40;
            this.uxRemoveNewerRecordsChk.Text = "Remove Newer Than";
            this.uxRemoveNewerRecordsChk.UseVisualStyleBackColor = true;
            // 
            // uxImportTypeCmbo
            // 
            this.uxImportTypeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxImportTypeCmbo.FormattingEnabled = true;
            this.uxImportTypeCmbo.Items.AddRange(new object[] {
            "Invoice (EPOS AR)",
            "Invoices Posted to P+L (CSS DOWNLOAD)",
            "Outstanding Invoices"});
            this.uxImportTypeCmbo.Location = new System.Drawing.Point(132, 41);
            this.uxImportTypeCmbo.MaxLength = 6;
            this.uxImportTypeCmbo.Name = "uxImportTypeCmbo";
            this.uxImportTypeCmbo.Size = new System.Drawing.Size(240, 21);
            this.uxImportTypeCmbo.TabIndex = 38;
            // 
            // uxImportTypeLbl
            // 
            this.uxImportTypeLbl.AutoSize = true;
            this.uxImportTypeLbl.Location = new System.Drawing.Point(65, 44);
            this.uxImportTypeLbl.Name = "uxImportTypeLbl";
            this.uxImportTypeLbl.Size = new System.Drawing.Size(63, 13);
            this.uxImportTypeLbl.TabIndex = 37;
            this.uxImportTypeLbl.Text = "Import Type";
            // 
            // uxWorksheetUpdateBtn
            // 
            this.uxWorksheetUpdateBtn.Location = new System.Drawing.Point(392, 102);
            this.uxWorksheetUpdateBtn.Name = "uxWorksheetUpdateBtn";
            this.uxWorksheetUpdateBtn.Size = new System.Drawing.Size(112, 23);
            this.uxWorksheetUpdateBtn.TabIndex = 36;
            this.uxWorksheetUpdateBtn.Text = "Update";
            this.uxWorksheetUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // uxExcelSheetViewerGv
            // 
            this.uxExcelSheetViewerGv.AllowUserToAddRows = false;
            this.uxExcelSheetViewerGv.AllowUserToDeleteRows = false;
            this.uxExcelSheetViewerGv.AllowUserToResizeRows = false;
            this.uxExcelSheetViewerGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxExcelSheetViewerGv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.uxExcelSheetViewerGv.Location = new System.Drawing.Point(4, 173);
            this.uxExcelSheetViewerGv.Name = "uxExcelSheetViewerGv";
            this.uxExcelSheetViewerGv.ReadOnly = true;
            this.uxExcelSheetViewerGv.RowHeadersVisible = false;
            this.uxExcelSheetViewerGv.Size = new System.Drawing.Size(682, 219);
            this.uxExcelSheetViewerGv.TabIndex = 35;
            // 
            // uxImportBtn
            // 
            this.uxImportBtn.Location = new System.Drawing.Point(294, 400);
            this.uxImportBtn.Name = "uxImportBtn";
            this.uxImportBtn.Size = new System.Drawing.Size(93, 40);
            this.uxImportBtn.TabIndex = 29;
            this.uxImportBtn.Text = "Import File";
            this.uxImportBtn.UseVisualStyleBackColor = true;
            this.uxImportBtn.Click += new System.EventHandler(this.uxImportBtn_Click);
            // 
            // uxExcelSheetLbl
            // 
            this.uxExcelSheetLbl.AutoSize = true;
            this.uxExcelSheetLbl.Location = new System.Drawing.Point(16, 76);
            this.uxExcelSheetLbl.Name = "uxExcelSheetLbl";
            this.uxExcelSheetLbl.Size = new System.Drawing.Size(112, 13);
            this.uxExcelSheetLbl.TabIndex = 33;
            this.uxExcelSheetLbl.Text = "Select an Excel Sheet";
            // 
            // uxExcelSheetTxt
            // 
            this.uxExcelSheetTxt.Location = new System.Drawing.Point(132, 72);
            this.uxExcelSheetTxt.Name = "uxExcelSheetTxt";
            this.uxExcelSheetTxt.ReadOnly = true;
            this.uxExcelSheetTxt.Size = new System.Drawing.Size(240, 20);
            this.uxExcelSheetTxt.TabIndex = 31;
            // 
            // uxWorksheetLbl
            // 
            this.uxWorksheetLbl.AutoSize = true;
            this.uxWorksheetLbl.Location = new System.Drawing.Point(26, 106);
            this.uxWorksheetLbl.Name = "uxWorksheetLbl";
            this.uxWorksheetLbl.Size = new System.Drawing.Size(101, 13);
            this.uxWorksheetLbl.TabIndex = 34;
            this.uxWorksheetLbl.Text = "Select a Worksheet";
            // 
            // uxExcelWorksheetCmbo
            // 
            this.uxExcelWorksheetCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxExcelWorksheetCmbo.FormattingEnabled = true;
            this.uxExcelWorksheetCmbo.Location = new System.Drawing.Point(132, 102);
            this.uxExcelWorksheetCmbo.Name = "uxExcelWorksheetCmbo";
            this.uxExcelWorksheetCmbo.Size = new System.Drawing.Size(240, 21);
            this.uxExcelWorksheetCmbo.TabIndex = 32;
            // 
            // uxExcelBrowseBtn
            // 
            this.uxExcelBrowseBtn.Location = new System.Drawing.Point(392, 72);
            this.uxExcelBrowseBtn.Name = "uxExcelBrowseBtn";
            this.uxExcelBrowseBtn.Size = new System.Drawing.Size(112, 23);
            this.uxExcelBrowseBtn.TabIndex = 30;
            this.uxExcelBrowseBtn.Text = "Browse";
            this.uxExcelBrowseBtn.UseVisualStyleBackColor = true;
            this.uxExcelBrowseBtn.Click += new System.EventHandler(this.uxExcelBrowseBtn_Click);
            // 
            // gpExcelFileFind
            // 
            this.gpExcelFileFind.FileName = "OpenFileDialog1";
            this.gpExcelFileFind.FileOk += new System.ComponentModel.CancelEventHandler(this.GpExcelFileFindFileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 526);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uxMainTc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Jonas Importer Tool";
            this.Load += new System.EventHandler(this.Form1Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabSage.ResumeLayout(false);
            this.TabSage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).EndInit();
            this.TabDynamicsGP.ResumeLayout(false);
            this.TabDynamicsGP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpExcelGridView)).EndInit();
            this.uxMainTc.ResumeLayout(false);
            this.uxAllTb.ResumeLayout(false);
            this.uxAllTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxExcelSheetViewerGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
        internal System.Windows.Forms.OpenFileDialog ExcelFileFind;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominalCodeEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jonasGroupEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        internal System.Windows.Forms.TabPage TabSage;
        internal System.Windows.Forms.ComboBox ImportTypeCombo;
        internal System.Windows.Forms.Label ImportTypeOldLbl;
        internal System.Windows.Forms.Button UpdateBtn;
        internal System.Windows.Forms.DataGridView ExcelGridView;
        internal System.Windows.Forms.Label debuglbl;
        internal System.Windows.Forms.Button ImportFile;
        internal System.Windows.Forms.Label LblExcelSheetSelect;
        internal System.Windows.Forms.TextBox DirectoryBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ExcelSheetName;
        internal System.Windows.Forms.Button DirectorySelection;
        private System.Windows.Forms.TabPage TabDynamicsGP;
        internal System.Windows.Forms.ComboBox gpImportTypeCombo;
        internal System.Windows.Forms.Label gpImportTypeLbl;
        internal System.Windows.Forms.Button gpUpdateDataGridBtn;
        internal System.Windows.Forms.DataGridView gpExcelGridView;
        internal System.Windows.Forms.Button gpImportFileBtn;
        internal System.Windows.Forms.Label gpExcelSheet;
        internal System.Windows.Forms.TextBox gpExcelSheetName;
        internal System.Windows.Forms.Label dpSelectWorksheetlbl;
        internal System.Windows.Forms.ComboBox gpWorksheetCombo;
        internal System.Windows.Forms.Button gpBrowseForSheetBtn;
        internal System.Windows.Forms.TabControl uxMainTc;
        internal System.Windows.Forms.OpenFileDialog gpExcelFileFind;
        private System.Windows.Forms.CheckBox chkBoxRemoveNewerThan;
        private System.Windows.Forms.DateTimePicker dTRemoveNewerThan;
        private System.Windows.Forms.Label lblRemoveWarning;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerLedgerByGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesPostedToPAndLToolStripMenuItem;
        public System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerStatementToolStripMenuItem;
        private System.Windows.Forms.TabPage uxAllTb;
        internal System.Windows.Forms.ComboBox uxImportSourceCmbo;
        internal System.Windows.Forms.Label uxImportSourceLbl;
        private System.Windows.Forms.Label uxInclusiveLbl;
        private System.Windows.Forms.DateTimePicker uxRemoveNewerRecordsDt;
        private System.Windows.Forms.CheckBox uxRemoveNewerRecordsChk;
        internal System.Windows.Forms.ComboBox uxImportTypeCmbo;
        internal System.Windows.Forms.Label uxImportTypeLbl;
        internal System.Windows.Forms.Button uxWorksheetUpdateBtn;
        internal System.Windows.Forms.DataGridView uxExcelSheetViewerGv;
        internal System.Windows.Forms.Button uxImportBtn;
        internal System.Windows.Forms.Label uxExcelSheetLbl;
        internal System.Windows.Forms.TextBox uxExcelSheetTxt;
        internal System.Windows.Forms.Label uxWorksheetLbl;
        internal System.Windows.Forms.ComboBox uxExcelWorksheetCmbo;
        internal System.Windows.Forms.Button uxExcelBrowseBtn;
    }
}

