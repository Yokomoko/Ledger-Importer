using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jonas_Sage_Importer
{
    using SageImporterLibrary;

    public partial class ReportViewer : Form
    {

        Uri reportServerPath = new Uri($"{DbConnectionsCs.ReportServerUrl()}");
        string reportName = String.Empty;
        

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            this.Text = $"{this.reportName.Replace("/","")}";
           
             this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ShowCredentialPrompts = true;
            this.reportViewer1.ServerReport.ReportServerUrl = this.reportServerPath;
            this.reportViewer1.ServerReport.ReportPath = this.reportName;
            this.reportViewer1.Refresh();
        }

        public void ReportServerPathName(string reportPath)
        {
            this.reportName = reportPath;
        }


    }
}
