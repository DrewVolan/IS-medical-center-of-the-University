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
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы зарегистрировали пользователя {surnameTextBox.Text} {nameTextBox.Text} {patronimycTextBox.Text}.\nЛогин: {loginTextBox.Text}\nПароль: {passwordTextBox.Text}");
        }
    }
}
