using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mis
{
    public partial class AdministrationForm : StandartForm
    {
        string[] thisUser = new string[8];
        string[] thisStudent = new string[8];
        public AdministrationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionPath);
                if (typePostComboBox.SelectedIndex == 0)
                {
                    bool regCheck = true;
                    bool checkLogin = true;
                    char[] loginLetters = loginTextBox.Text.ToCharArray();
                    for (int i = 0; i < loginLetters.Length; i++)
                    {
                        if (loginLetters[i] >= 'А' && loginLetters[i] <= 'ё' && loginLetters.Length != 0)
                        {
                            checkLogin = false;
                            MessageBox.Show("Логин не должен содержать символы русского алфавита!");
                            break;
                        }
                    }
                    if (fullNameTextBox.Text != "" && loginTextBox.Text != "" && passwordTextBox.Text != "" && paramTextBox1.Text != "" && checkLogin == true)
                    {
                        DialogResult newUserDialogResult = MessageBox.Show($"Создать нового пользователя {loginTextBox.Text}?", "Новый пользователь", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (newUserDialogResult == DialogResult.Yes)
                        {
                            SqlCommand insertStaff = new SqlCommand("INSERT INTO [Staff] (Surname, Name, Patronymic, Role, DateOfEmployment, Login, Password)VALUES(@Surname, @Name, @Patronymic, @Role, @DateOfEmployment, @Login, @Password)", sqlConnection);
                            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM [Staff]", sqlConnection);
                            insertStaff.Parameters.AddWithValue("Surname", fullNameTextBox.Text.Split(' ')[0]);
                            insertStaff.Parameters.AddWithValue("Name", fullNameTextBox.Text.Split(' ')[1]);
                            insertStaff.Parameters.AddWithValue("Patronymic", fullNameTextBox.Text.Split(' ')[2]);
                            insertStaff.Parameters.AddWithValue("Role", paramTextBox1.Text);
                            insertStaff.Parameters.AddWithValue("DateOfEmployment", dateTimePicker.Value);
                            insertStaff.Parameters.AddWithValue("Login", loginTextBox.Text);
                            insertStaff.Parameters.AddWithValue("Password", passwordTextBox.Text);
                            await sqlConnection.OpenAsync();
                            sdr = await cmdSelect.ExecuteReaderAsync();
                            while (await sdr.ReadAsync())
                            {
                                if (loginTextBox.Text == Convert.ToString(sdr["Login"]))
                                {
                                    MessageBox.Show("Такой логин уже существует!", "Новый пользователь", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    regCheck = false;
                                    break;
                                }
                            }
                            sdr.Close();
                            if (regCheck == true)
                            {
                                await insertStaff.ExecuteNonQueryAsync();
                                sqlConnection.Close();
                                usersListBox.Items.Add(loginTextBox.Text);
                                UpdateButton_Click(this, e);
                            }
                            else
                                sqlConnection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля!", "Новый пользователь", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (typePostComboBox.SelectedIndex == 1)
                {
                    if (paramTextBox1.Text == "Бюджетная" || paramTextBox1.Text == "Платная")
                    {
                        bool learningBasis = false;
                        if (paramTextBox1.Text == "Бюджетная")
                        {
                            learningBasis = true;
                        }
                        else if (paramTextBox1.Text == "Платная")
                        {
                            learningBasis = false;
                        }
                        if (fullNameTextBox.Text != "" && loginTextBox.Text != "" && passwordTextBox.Text != "" && paramTextBox1.Text != "" && paramTextBox2.Text != "")
                        {
                            DialogResult newUserDialogResult = MessageBox.Show($"Добавить нового студента {fullNameTextBox.Text}?", "Новый студент", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (newUserDialogResult == DialogResult.Yes)
                            {
                                SqlCommand insertStudent = new SqlCommand("INSERT INTO [Students] (Surname, Name, Patronymic, Address, PreparationProgram, LearningBasis, DateOfReceipt, Grouping)VALUES(@Surname, @Name, @Patronymic, @Address, @PreparationProgram, @LearningBasis, @DateOfReceipt, @Grouping)", sqlConnection);
                                insertStudent.Parameters.AddWithValue("Surname", fullNameTextBox.Text.Split(' ')[0]);
                                insertStudent.Parameters.AddWithValue("Name", fullNameTextBox.Text.Split(' ')[1]);
                                insertStudent.Parameters.AddWithValue("Patronymic", fullNameTextBox.Text.Split(' ')[2]);
                                insertStudent.Parameters.AddWithValue("Address", paramTextBox2.Text);
                                insertStudent.Parameters.AddWithValue("PreparationProgram", loginTextBox.Text);
                                insertStudent.Parameters.AddWithValue("LearningBasis", learningBasis);
                                insertStudent.Parameters.AddWithValue("DateOfReceipt", dateTimePicker.Value);
                                insertStudent.Parameters.AddWithValue("Grouping", passwordTextBox.Text);
                                await sqlConnection.OpenAsync();
                                await insertStudent.ExecuteNonQueryAsync();
                                sqlConnection.Close();
                                UpdateButton_Click(this, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!", "Новый студент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("В параметре 'Основа обучения:' впишите 'Бюджетная' или 'Платная'!", "Новый студент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteUserButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            if (userTypeTabControl.SelectedIndex == 0 && usersListBox.SelectedIndex != -1)
            {
                sqlConnection = new SqlConnection(connectionPath);
                SqlCommand deleteStaff = new SqlCommand("UPDATE [Staff] SET [Status]=0 WHERE [Id]=@Id", sqlConnection);
                string userForDelete = loginTextBox.Text;
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить пользователя {userForDelete}?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        deleteStaff.Parameters.AddWithValue("Id", idTextBox.Text);
                        await sqlConnection.OpenAsync();
                        await deleteStaff.ExecuteNonQueryAsync();
                        sqlConnection.Close();
                        MessageBox.Show($"Вы удалили пользователя {userForDelete}!", "Удаление пользователя");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Вы отменили удаление.", "Удаление пользователя");
                        break;
                }
            }
            else if (userTypeTabControl.SelectedIndex == 1 && studentsListBox.SelectedIndex != -1)
            {
                SqlCommand deleteStudent = new SqlCommand("UPDATE [Students] SET [Status]=0 WHERE [Id]=@Id", sqlConnection);
                string studentForDelete = fullNameTextBox.Text;
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить студента {studentForDelete}?", "Удаление студента", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        deleteStudent.Parameters.AddWithValue("Id", idTextBox.Text);
                        await sqlConnection.OpenAsync();
                        await deleteStudent.ExecuteNonQueryAsync();
                        sqlConnection.Close();
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
            idTextBox.Text = "";
            paramLabel1.Visible = false;
            paramLabel2.Visible = false;
            paramTextBox1.Visible = false;
            paramTextBox2.Visible = false;
            fullNameTextBox.Text = "";
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            paramTextBox1.Text = "";
            paramTextBox2.Text = "";
            AdministrationForm_Load(this, e);
        }

        private async void AdministrationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();
            SqlCommand selectStaff = new SqlCommand("SELECT * FROM [Staff]", sqlConnection);
            SqlCommand selectStudents = new SqlCommand("SELECT * FROM [Students]", sqlConnection);
            try
            {
                sdr = await selectStaff.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        usersListBox.Items.Add(Convert.ToString(sdr["Login"]));
                }
                sdr.Close();
                sdr = await selectStudents.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        studentsListBox.Items.Add(Convert.ToString(sdr["Grouping"]) + " " + Convert.ToString(sdr["Surname"]) + " " + Convert.ToString(sdr["Name"]) + " " + Convert.ToString(sdr["Patronymic"]) + " " + Convert.ToString(sdr["Id"]));
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (readOnlyParameter)
            {
                usersListBox.Enabled = true;
                studentsListBox.Enabled = true;
                typePostLabel.Visible = false;
                typePostComboBox.Visible = false;
                deleteUserButton.Visible = true;
                idTextBox.Enabled = true;
            }
            else
            {
                usersListBox.Enabled = false;
                studentsListBox.Enabled = false;
                typePostLabel.Visible = true;
                typePostComboBox.Visible = true;
                deleteUserButton.Visible = false;
                idTextBox.Enabled = false;
            }
            sqlConnection.Close();
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
                loginLabel.Text = "Логин:";
                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                loginTextBox.ReadOnly = false;
                passwordLabel.Text = "Пароль:";
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordTextBox.ReadOnly = false;
                paramLabel1.Text = "Должность:";
                paramLabel1.Visible = true;
                paramTextBox1.Visible = true;
                paramTextBox1.ReadOnly = false;
                paramLabel2.Text = "Дата уволь-ния:";
                paramLabel2.Visible = true;
                paramTextBox2.Visible = true;
                paramTextBox2.ReadOnly = false;
            }
            else if (typePostComboBox.SelectedIndex == 1)
            {
                newEmployeeButton.Visible = true;
                fullNameLabel.Visible = true;
                fullNameTextBox.Visible = true;
                fullNameTextBox.ReadOnly = false;
                dateLabel.Visible = true;
                dateLabel.Text = "Дата поступ-я:";
                dateTimePicker.Visible = true;
                dateTimePicker.Enabled = true;
                loginLabel.Text = "Прогр. обуч-я:";
                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                loginTextBox.ReadOnly = false;
                passwordLabel.Text = "Группа:";
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordTextBox.ReadOnly = false;
                paramLabel1.Text = "Основа обуч-я:";
                paramLabel1.Visible = true;
                paramTextBox1.Visible = true;
                paramTextBox1.ReadOnly = false;
                paramLabel2.Text = "Адрес:";
                paramLabel2.Visible = true;
                paramTextBox2.Visible = true;
                paramTextBox2.ReadOnly = false;
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
                paramLabel1.Visible = false;
                paramLabel2.Visible = false;
                paramTextBox1.Visible = false;
                paramTextBox2.Visible = false;
            }
        }

        private async void UsersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            SqlCommand selectStaff = new SqlCommand("SELECT * FROM [Staff] WHERE [Login]=@Login", sqlConnection);
            try
            {
                if (usersListBox.SelectedIndex != -1)
                {
                    await sqlConnection.OpenAsync();
                    selectStaff.Parameters.AddWithValue("Login", usersListBox.SelectedItem.ToString());
                    sdr = await selectStaff.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        fullNameLabel.Visible = true;
                        fullNameTextBox.Visible = true;
                        fullNameTextBox.ReadOnly = true;
                        thisUser[0] = Convert.ToString(sdr["Id"]);
                        idTextBox.Text = thisUser[0];
                        thisUser[1] = Convert.ToString(sdr["Surname"]) + " " + Convert.ToString(sdr["Name"]) + " " + Convert.ToString(sdr["Patronymic"]);
                        fullNameTextBox.Text = thisUser[1];
                        dateLabel.Visible = true;
                        dateLabel.Text = "Дата найма:";
                        dateTimePicker.Visible = true;
                        dateTimePicker.Enabled = false;
                        thisUser[3] = Convert.ToString(sdr["DateOfEmployment"]);
                        dateTimePicker.Value = DateTime.Parse(thisUser[3]);
                        loginLabel.Text = "Логин:";
                        loginLabel.Visible = true;
                        loginTextBox.Visible = true;
                        loginTextBox.ReadOnly = true;
                        thisUser[5] = Convert.ToString(sdr["Login"]);
                        loginTextBox.Text = thisUser[5];
                        passwordLabel.Text = "Пароль:";
                        passwordLabel.Visible = true;
                        passwordTextBox.Visible = true;
                        passwordTextBox.ReadOnly = true;
                        thisUser[6] = Convert.ToString(sdr["Password"]);
                        passwordTextBox.Text = thisUser[6];
                        paramLabel1.Text = "Должность:";
                        paramLabel1.Visible = true;
                        paramTextBox1.Visible = true;
                        paramTextBox1.ReadOnly = false;
                        thisUser[2] = Convert.ToString(sdr["Role"]);
                        paramTextBox1.Text = thisUser[2];
                        paramLabel2.Text = "Дата уволь-ния:";
                        paramLabel2.Visible = true;
                        paramTextBox2.Visible = true;
                        paramTextBox2.ReadOnly = false;
                        thisUser[4] = Convert.ToString(sdr["DateOfTermination"]);
                        paramTextBox2.Text = thisUser[4];
                    }
                    sdr.Close();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void StudentsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            SqlCommand selectStudents = new SqlCommand("SELECT * FROM [Students] WHERE [Id]=@Id", sqlConnection);
            try
            {
                if (studentsListBox.SelectedIndex != -1)
                {
                    await sqlConnection.OpenAsync();
                    selectStudents.Parameters.AddWithValue("Id", studentsListBox.SelectedItem.ToString().Split(new char[] { ' ' })[4]);
                    sdr = await selectStudents.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        fullNameLabel.Visible = true;
                        fullNameTextBox.Visible = true;
                        fullNameTextBox.ReadOnly = true;
                        thisStudent[0] = Convert.ToString(sdr["Id"]);
                        idTextBox.Text = thisStudent[0];
                        thisStudent[1] = Convert.ToString(sdr["Surname"]) + " " + Convert.ToString(sdr["Name"]) + " " + Convert.ToString(sdr["Patronymic"]);
                        fullNameTextBox.Text = thisStudent[1];
                        dateLabel.Visible = true;
                        dateLabel.Text = "Дата поступ-я:";
                        dateTimePicker.Visible = true;
                        dateTimePicker.Enabled = false;
                        thisStudent[5] = Convert.ToString(sdr["DateOfReceipt"]);
                        dateTimePicker.Value = DateTime.Parse(thisStudent[5]);
                        loginLabel.Text = "Прогр. обуч-я:";
                        loginLabel.Visible = true;
                        loginTextBox.Visible = true;
                        loginTextBox.ReadOnly = true;
                        thisStudent[3] = Convert.ToString(sdr["PreparationProgram"]);
                        loginTextBox.Text = thisStudent[3];
                        passwordLabel.Text = "Группа:";
                        passwordLabel.Visible = true;
                        passwordTextBox.Visible = true;
                        passwordTextBox.ReadOnly = true;
                        thisStudent[7] = Convert.ToString(sdr["Grouping"]);
                        passwordTextBox.Text = thisStudent[7];
                        paramLabel1.Text = "Основа обуч-я:";
                        paramLabel1.Visible = true;
                        paramTextBox1.Visible = true;
                        paramTextBox1.ReadOnly = false;
                        thisStudent[4] = Convert.ToString(sdr["LearningBasis"]);
                        if (thisStudent[4] == "True")
                            thisStudent[4] = "Бюджетная";
                        else
                            thisStudent[4] = "Платная";
                        paramTextBox1.Text = thisStudent[4];
                        paramLabel2.Text = "Адрес:";
                        paramLabel2.Visible = true;
                        paramTextBox2.Visible = true;
                        paramTextBox2.ReadOnly = false;
                        thisStudent[2] = Convert.ToString(sdr["Address"]);
                        paramTextBox2.Text = thisStudent[2];
                    }
                    sdr.Close();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    idTextBox.Text = thisUser[0];
                    fullNameTextBox.Text = thisUser[1];
                    dateLabel.Visible = true;
                    dateLabel.Text = "Дата найма:";
                    dateTimePicker.Visible = true;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Parse(thisUser[3]);
                    loginLabel.Text = "Логин:";
                    loginLabel.Visible = true;
                    loginTextBox.Visible = true;
                    loginTextBox.ReadOnly = true;
                    loginTextBox.Text = thisUser[5];
                    passwordLabel.Text = "Пароль:";
                    passwordLabel.Visible = true;
                    passwordTextBox.Visible = true;
                    passwordTextBox.ReadOnly = true;
                    passwordTextBox.Text = thisUser[6];
                    paramLabel1.Text = "Должность:";
                    paramLabel1.Visible = true;
                    paramTextBox1.Visible = true;
                    paramTextBox1.ReadOnly = false;
                    paramTextBox1.Text = thisUser[2];
                    paramLabel2.Text = "Дата уволь-ния:";
                    paramLabel2.Visible = true;
                    paramTextBox2.Visible = true;
                    paramTextBox2.ReadOnly = false;
                    paramTextBox2.Text = thisUser[4];
                }
            }
            else if (userTypeTabControl.SelectedIndex == 1)
            {
                if (studentsListBox.SelectedIndex != -1)
                {
                    fullNameLabel.Visible = true;
                    fullNameTextBox.Visible = true;
                    fullNameTextBox.ReadOnly = true;
                    idTextBox.Text = thisStudent[0];
                    fullNameTextBox.Text = thisStudent[1];
                    dateLabel.Visible = true;
                    dateLabel.Text = "Дата поступ-я:";
                    dateTimePicker.Visible = true;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Parse(thisStudent[5]);
                    loginLabel.Text = "Прогр.а обуч-я:";
                    loginLabel.Visible = true;
                    loginTextBox.Visible = true;
                    loginTextBox.ReadOnly = true;
                    loginTextBox.Text = thisStudent[3];
                    passwordLabel.Text = "Группа:";
                    passwordLabel.Visible = true;
                    passwordTextBox.Visible = true;
                    passwordTextBox.ReadOnly = true;
                    passwordTextBox.Text = thisStudent[7];
                    paramLabel1.Text = "Основа обуч-я:";
                    paramLabel1.Visible = true;
                    paramTextBox1.Visible = true;
                    paramTextBox1.ReadOnly = false;
                    paramTextBox1.Text = thisStudent[4];
                    paramLabel2.Text = "Адрес:";
                    paramLabel2.Visible = true;
                    paramTextBox2.Visible = true;
                    paramTextBox2.ReadOnly = false;
                    paramTextBox2.Text = thisStudent[2];
                }
            }
        }
    }
}
