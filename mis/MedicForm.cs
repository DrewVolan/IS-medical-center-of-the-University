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
    public partial class MedicForm : StandartForm
    {
        public MedicForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            treatmentTextBox.ContextMenuStrip = medicTextBoxMultilineContextMenuStrip;
        }

        private void NewTreatmentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treatmentTextBox.Text);
        }

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = treatmentTextBox.SelectedText;
        }

        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treatmentTextBox.Paste(buffer);
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
