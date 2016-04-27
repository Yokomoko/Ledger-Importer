using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SageImporterLibrary;

namespace Jonas_Sage_Importer
{
    public partial class DatabaseConnection : Form
    {



        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.DbLocationTxtBox.Text = DbConnectionsCs.DbLocationTxt();
            this.DbNameTxtBox.Text = DbConnectionsCs.DbNameTxt();
            this.UsernameTxtBox.Text = DbConnectionsCs.UserNameTxt();
            this.PasswordTxtBox.Text = DbConnectionsCs.PasswordTxt();
            this.ConnectionStringTxtBox.Text = DbConnectionsCs.ConnectionString();
            this.txtBoxReportServerUrl.Text = @"http://192.168.15.48/reportserver";
        }

        private void ConnTestBtn_Click(object sender, EventArgs e)
        {
            bool trialTest = false;

            Loading lS = new Loading { TopMost = true };
            lS.UpdateText($"Testing Connection\n... Please Wait... This May Take up to a Minute to Complete. ");
            lS.Show();
            lS.Update();

            while (trialTest == false)
            {
                DbConnectionsCs.TestConnection(
                    this.DbLocationTxtBox.Text,
                    this.DbNameTxtBox.Text,
                    this.UsernameTxtBox.Text,
                    this.PasswordTxtBox.Text,
                     this.ConnectionStatus);
                trialTest = true;
            }
            lS.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DbConnectionsCs.UpdateConnection(
                DbLocationTxtBox.Text,
                DbNameTxtBox.Text,
                UsernameTxtBox.Text,
                PasswordTxtBox.Text);
            ConnectionStringTxtBox.Text = DbConnectionsCs.ConnectionString();
        }

        private void dbConnectionExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.ConnTestBtn.PerformClick();
            }
        }
        private void DbLocationTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.ReturnPress(sender, e);
        }

        private void UserNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.ReturnPress(sender, e);
        }

        private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.ReturnPress(sender, e);
        }

        private void DbLocationTxtBox_Validated(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateRptServerUrl_Click(object sender, EventArgs e)
        {
            DbConnectionsCs.updateReportServerUri(this.txtBoxReportServerUrl.Text);
        }
    }
}
