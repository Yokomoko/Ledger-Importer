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
    public partial class Loading : Form
    {

        public Loading()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Loading_Shown);
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(Loading_Shown);
        }

        void Loading_Shown(object sender, EventArgs e)
        {
            this.Update();
        }

        public void UpdateText(string TextString)
        {
            this.lblConnectionTest.Text = TextString;
        }

    }
}
