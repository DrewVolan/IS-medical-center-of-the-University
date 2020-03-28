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
    public partial class AdministrationForm : StandartForm
    {
        public AdministrationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployeeForm registrationEmployeeForm = new NewEmployeeForm();
            registrationEmployeeForm.ShowDialog();
        }

        private void NewStudentButton_Click(object sender, EventArgs e)
        {
            NewStudentForm registrationStudentForm = new NewStudentForm();
            registrationStudentForm.ShowDialog();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Вы удалили пользователя!", "Удаление пользователя");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Вы отменили удаление.", "Удаление пользователя");
                    break;
            }
        }
    }
}
