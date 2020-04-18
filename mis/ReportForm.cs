using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mis
{
    public partial class ReportForm : Form
    {
        public String ReportRole = String.Empty;
        public ReportForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
