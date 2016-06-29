using System.ComponentModel;
using System.DirectoryServices;
using System.Windows.Forms;

namespace Jonas_Sage_Importer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            // uxMainTc
            // 
            this.uxMainTc.Controls.Add(this.uxAllTb);
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
            this.uxWorksheetUpdateBtn.Click += new System.EventHandler(this.uxWorksheetUpdateBtn_Click);
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
            this.uxMainTc.ResumeLayout(false);
            this.uxAllTb.ResumeLayout(false);
            this.uxAllTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxExcelSheetViewerGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal ToolStripStatusLabel StatusStripLabel;
        private DirectoryEntry directoryEntry1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem nominalCodeEditorToolStripMenuItem;
        private ToolStripMenuItem jonasGroupEditorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem changeLogToolStripMenuItem;
        private ToolStripMenuItem connectionSettingsToolStripMenuItem;
        internal TabControl uxMainTc;
        internal OpenFileDialog gpExcelFileFind;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem customerLedgerByGroupToolStripMenuItem;
        private ToolStripMenuItem invoicesPostedToPAndLToolStripMenuItem;
        public StatusStrip StatusStrip1;
        private ToolStripMenuItem customerStatementToolStripMenuItem;
        private TabPage uxAllTb;
        internal ComboBox uxImportSourceCmbo;
        internal Label uxImportSourceLbl;
        private Label uxInclusiveLbl;
        private DateTimePicker uxRemoveNewerRecordsDt;
        private CheckBox uxRemoveNewerRecordsChk;
        internal ComboBox uxImportTypeCmbo;
        internal Label uxImportTypeLbl;
        internal Button uxWorksheetUpdateBtn;
        internal DataGridView uxExcelSheetViewerGv;
        internal Button uxImportBtn;
        internal Label uxExcelSheetLbl;
        internal TextBox uxExcelSheetTxt;
        internal Label uxWorksheetLbl;
        internal ComboBox uxExcelWorksheetCmbo;
        internal Button uxExcelBrowseBtn;
    }
}

