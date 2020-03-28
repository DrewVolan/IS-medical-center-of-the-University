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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                AdministrationForm administrationForm = new AdministrationForm
                {
                    Login = loginTextBox.Text,
                    //MdiParent = this
                };
                administrationForm.Show();
                this.Hide();
            }
            else if (loginTextBox.Text == "medic" && passwordTextBox.Text == "medic")
            {
                MedicForm medicForm = new MedicForm
                {
                    Login = loginTextBox.Text,
                    //MdiParent = this
                };
                medicForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Логин и/или пароль неверны!\nПопробуйте ещё раз.");
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
