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
    /// <summary>
    /// Класс родительской формы со всеми одинаковыми опциями для остальных форм.
    /// </summary>
    public partial class StandartForm : Form
    {
        public StandartForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void StandartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
