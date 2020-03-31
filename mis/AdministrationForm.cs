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
        public string[,] users = new string[10, 4];
        string[,] students = new string[10, 2];
        public AdministrationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            if(typePostComboBox.SelectedIndex == 0)
            {
                if (fullNameTextBox.Text != "" && loginTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    DialogResult newUserDialogResult = MessageBox.Show($"Создать нового пользователя {loginTextBox.Text}?", "Новый пользователь", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (newUserDialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i, 0] == null)
                            {
                                users[i, 0] = fullNameTextBox.Text;
                                users[i, 1] = dateTimePicker.Value.ToString();
                                users[i, 2] = loginTextBox.Text;
                                users[i, 3] = passwordTextBox.Text;
                                usersListBox.Items.Add(users[i, 2]);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Новый пользователь", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typePostComboBox.SelectedIndex == 1)
            {
                if (fullNameTextBox.Text != "")
                {
                    DialogResult newUserDialogResult = MessageBox.Show($"Добавить нового студента {fullNameTextBox.Text}?", "Новый студент", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (newUserDialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i, 0] == null)
                            {
                                students[i, 0] = fullNameTextBox.Text;
                                students[i, 1] = dateTimePicker.Value.ToString();
                                studentsListBox.Items.Add(students[i, 0]);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Новый студент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (userTypeTabControl.SelectedIndex == 0 && usersListBox.SelectedIndex != -1)
            {
                string userForDelete = loginTextBox.Text;
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить пользователя {userForDelete}?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i, 2] == userForDelete)
                            {
                                users[i, 0] = null;
                                users[i, 1] = null;
                                users[i, 2] = null;
                                users[i, 3] = null;
                                usersListBox.Items.RemoveAt(usersListBox.SelectedIndex);
                                break;
                            }
                        }
                        MessageBox.Show($"Вы удалили пользователя {userForDelete}!", "Удаление пользователя");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Вы отменили удаление.", "Удаление пользователя");
                        break;
                }
            }
            else if (userTypeTabControl.SelectedIndex == 1 && studentsListBox.SelectedIndex != -1)
            {
                string studentForDelete = fullNameTextBox.Text;
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить студента {studentForDelete}?", "Удаление студента", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i, 0] == studentForDelete)
                            {
                                students[i, 0] = null;
                                students[i, 1] = null;
                                studentsListBox.Items.RemoveAt(studentsListBox.SelectedIndex);
                                break;
                            }
                        }
                        MessageBox.Show($"Вы удалили студента {studentForDelete}!", "Удаление студента");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Вы отменили удаление.", "Удаление студента");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            readOnlyParameter = !readOnlyParameter;
            if (!readOnlyParameter)
            {
                writeButton.BackColor = Color.DarkBlue;
            }
            else
            {
                writeButton.BackColor = Color.White;
            }
            UpdateButton_Click(this, e);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            typePostComboBox.SelectedIndex = -1;
            usersListBox.SelectedIndex = -1;
            usersListBox.Items.Clear();
            studentsListBox.SelectedIndex = -1;
            studentsListBox.Items.Clear();
            fullNameLabel.Visible = false;
            fullNameTextBox.Visible = false;
            dateLabel.Visible = false;
            dateTimePicker.Visible = false;
            loginLabel.Visible = false;
            loginTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            AdministrationForm_Load(this, e);
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; users[i, 0] != null; i++)
            {
                usersListBox.Items.Add(users[i, 2]);
            }
            for (int i = 0; students[i, 0] != null; i++)
            {
                studentsListBox.Items.Add(students[i, 0]);
            }
            if (readOnlyParameter)
            {
                usersListBox.Enabled = true;
                studentsListBox.Enabled = true;
                typePostLabel.Visible = false;
                typePostComboBox.Visible = false;
                deleteUserButton.Visible = true;
            }
            else
            {
                usersListBox.Enabled = false;
                studentsListBox.Enabled = false;
                typePostLabel.Visible = true;
                typePostComboBox.Visible = true;
                deleteUserButton.Visible = false;
            }
        }

        private void TypePostComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typePostComboBox.SelectedIndex == 0)
            {
                newEmployeeButton.Visible = true;
                fullNameLabel.Visible = true;
                fullNameTextBox.Visible = true;
                fullNameTextBox.ReadOnly = false;
                dateLabel.Visible = true;
                dateLabel.Text = "Дата найма:";
                dateTimePicker.Visible = true;
                dateTimePicker.Enabled = true;
                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                loginTextBox.ReadOnly = false;
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordTextBox.ReadOnly = false;
            }
            else if (typePostComboBox.SelectedIndex == 1)
            {
                newEmployeeButton.Visible = true;
                fullNameLabel.Visible = true;
                fullNameTextBox.Visible = true;
                fullNameTextBox.ReadOnly = false;
                dateLabel.Visible = true;
                dateLabel.Text = "Дата пост-я:";
                dateTimePicker.Visible = true;
                dateTimePicker.Enabled = true;
                loginLabel.Visible = false;
                loginTextBox.Visible = false;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
            }
            else
            {
                newEmployeeButton.Visible = false;
                fullNameLabel.Visible = false;
                fullNameTextBox.Visible = false;
                dateLabel.Visible = false;
                dateTimePicker.Visible = false;
                loginLabel.Visible = false;
                loginTextBox.Visible = false;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
            }
        }

        private void UsersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usersListBox.SelectedIndex != -1)
            {
                fullNameLabel.Visible = true;
                fullNameTextBox.Visible = true;
                fullNameTextBox.ReadOnly = true;
                fullNameTextBox.Text = users[usersListBox.SelectedIndex, 0];
                dateLabel.Visible = true;
                dateLabel.Text = "Дата найма:";
                dateTimePicker.Visible = true;
                dateTimePicker.Enabled = false;
                dateTimePicker.Value = DateTime.Parse(users[usersListBox.SelectedIndex, 1]);
                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                loginTextBox.ReadOnly = true;
                loginTextBox.Text = users[usersListBox.SelectedIndex, 2];
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordTextBox.ReadOnly = true;
                passwordTextBox.Text = users[usersListBox.SelectedIndex, 3];
            }
        }

        private void StudentsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (studentsListBox.SelectedIndex != -1)
            {
                fullNameLabel.Visible = true;
                fullNameTextBox.Visible = true;
                fullNameTextBox.ReadOnly = true;
                fullNameTextBox.Text = students[studentsListBox.SelectedIndex, 0];
                dateLabel.Visible = true;
                dateLabel.Text = "Дата пост-я:";
                dateTimePicker.Visible = true;
                dateTimePicker.Enabled = false;
                dateTimePicker.Value = DateTime.Parse(students[studentsListBox.SelectedIndex, 1]);
                loginLabel.Visible = false;
                loginTextBox.Visible = false;
                loginTextBox.ReadOnly = true;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
                passwordTextBox.ReadOnly = true;
            }
        }

        private void UserTypeTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userTypeTabControl.SelectedIndex == 0)
            {
                if (usersListBox.SelectedIndex != -1)
                {
                    fullNameLabel.Visible = true;
                    fullNameTextBox.Visible = true;
                    fullNameTextBox.ReadOnly = true;
                    fullNameTextBox.Text = users[usersListBox.SelectedIndex, 0];
                    dateLabel.Visible = true;
                    dateLabel.Text = "Дата найма:";
                    dateTimePicker.Visible = true;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Parse(users[usersListBox.SelectedIndex, 1]);
                    loginLabel.Visible = true;
                    loginTextBox.Visible = true;
                    loginTextBox.ReadOnly = true;
                    loginTextBox.Text = users[usersListBox.SelectedIndex, 2];
                    passwordLabel.Visible = true;
                    passwordTextBox.Visible = true;
                    passwordTextBox.ReadOnly = true;
                    passwordTextBox.Text = users[usersListBox.SelectedIndex, 3];
                }
            }
            else if (userTypeTabControl.SelectedIndex == 1)
            {
                if (studentsListBox.SelectedIndex != -1)
                {
                    fullNameLabel.Visible = true;
                    fullNameTextBox.Visible = true;
                    fullNameTextBox.ReadOnly = true;
                    fullNameTextBox.Text = students[studentsListBox.SelectedIndex, 0];
                    dateLabel.Visible = true;
                    dateLabel.Text = "Дата пост-я:";
                    dateTimePicker.Visible = true;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Parse(students[studentsListBox.SelectedIndex, 1]);
                    loginLabel.Visible = false;
                    loginTextBox.Visible = false;
                    loginTextBox.ReadOnly = true;
                    passwordLabel.Visible = false;
                    passwordTextBox.Visible = false;
                    passwordTextBox.ReadOnly = true;
                }
            }
        }
    }
}
