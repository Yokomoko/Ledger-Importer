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
    using System.Data.SqlClient;

    using SageImporterLibrary;

    public partial class NominalCodeEditor : Form
    {
        private readonly string connectionString = DbConnectionsCs.ConnectionString();

        private DataSet ds = new DataSet();

        private DataSet changes;

        DbConnectionsCs dbConnections = new DbConnectionsCs();

        /*
        DataTable dt = new DataTable();
        BindingSource bindingSource = new BindingSource();
        SqlDataAdapter da = new SqlDataAdapter();
        DbConnectionsCs dbConnectionsCs = new DbConnectionsCs();
        */

        private string nCode = string.Empty;

        private string nDesc = string.Empty;



        public NominalCodeEditor()
        {
            this.InitializeComponent();
        }

        private void NominalCodeEditor_Load(object sender, EventArgs e)
        {
            /*this.sql = "Select GLNo as NominalCode, GLDescription as NominalDescription from GlTypes";
            using (SqlConnection sqlconn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand sqlcomm = new SqlCommand(this.sql, sqlconn))
                {
                    sqlconn.Open();
                    this.adapter = new SqlDataAdapter(this.sql, sqlconn);
                    this.adapter.Fill(this.ds);
                    this.nominalCodesGridView.DataSource = this.ds.Tables[0];
                }
            }
            */
            this.dbConnections.GetNominalCodeAdapter().Fill(this.ds);
            this.nominalCodesGridView.DataSource = this.ds.Tables[0];
            

            this.nominalCodesGridView.Columns[1].Width = this.nominalCodesGridView.Width
                                                       - this.nominalCodesGridView.Columns[0].Width
                                                     - 21;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // this.bindingSource.Filter = $"convert(NominalCode,'System.String') like '%{this.textBox1.Text.ToString()}%' OR convert(Description,'System.String') like '%{this.textBox1.Text.ToString()}%'";
            string rowFilter = string.Format("Convert([{0}],'System.String') like '%{1}%'", "NominalCode", this.textBox1.Text);
            rowFilter += string.Format("OR [{0}] like '%{1}%'", "Description", this.textBox1.Text);

            (this.nominalCodesGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

        }

         private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNominalCodeBtn_Click(object sender, EventArgs e)
        {
            this.nCode = this.nominalCodeTxtBox.Text;
            this.nDesc = this.nominalDescriptionTxtBox.Text;


            int nominalCode = this.nCode !=string.Empty ? int.Parse(this.nCode) : 0;

            string nominalDescription = this.nDesc;

            if (nominalCode != 0 && nominalDescription !=string.Empty)
            {


                try
                {
                    DataRow newRow = this.ds.Tables[0].NewRow();
                    newRow["NominalCode"] = Int32.Parse(this.nCode);
                    newRow["Description"] = this.nDesc;

                    ds.Tables[0].Rows.Add(newRow);
                    this.nominalCodeTxtBox.Text = "";
                    this.nominalDescriptionTxtBox.Text = "";

                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Unable to complete Update Command: \n \n {sqlex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to complete Update Command: \n \n {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(@"Please Enter Nominal Code and Description. The Nominal Code can not be blank.");
            }


        }

        private void nominalCodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nominalDescriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.nominalCodesGridView.SelectedRows.Count > 0)
            {
                DialogResult dResult = MessageBox.Show(
                $"Are you sure you want to delete this nominal code? \nOnce it is removed you will not be able to recover this.",
                @"Are you sure?",
                MessageBoxButtons.YesNo);

                if (dResult == DialogResult.Yes)
                {
                    this.dbConnections.GetNominalCodeAdapter().AcceptChangesDuringUpdate = true;
                    this.nominalCodesGridView.Rows.RemoveAt(this.nominalCodesGridView.SelectedRows[0].Index);
                }
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqConn = new SqlConnection(this.connectionString);

            try
            {
                this.changes = this.ds.GetChanges();

                if (this.changes != null)
                {

                    this.ds.AcceptChanges();
                    this.dbConnections.GetNominalCodeAdapter().AcceptChangesDuringUpdate = true;
                    this.dbConnections.GetNominalCodeAdapter().Update(this.changes);
                    

                    MessageBox.Show(@"The Nominal Codes have been Updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Nominal Codes \n \n {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.nominalCodesGridView.Refresh();
        }

        private void nominalCodeTxtBox_KeyPress(object sender, KeyEventArgs e)
        {
            
        }

        private void nominalCodesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
