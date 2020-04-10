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
    public partial class AuthorizationForm : Form
    {
        public string connectionPath = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Desktop\Учёба\3 курс\2 семестр\Технология проектирования ИС\Лабораторная работа №7-10\mis\mis\MedicalDatabase.mdf';Integrated Security = True; Connect Timeout = 30";
        public SqlConnection sqlConnection;
        public SqlDataReader sdr;
        public AuthorizationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void AuthorizationButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM [Staff]", sqlConnection);
            bool checkLog = false;
            try
            {
                sdr = await cmdSelect.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (loginTextBox.Text == Convert.ToString(sdr["Login"]) && Convert.ToString(sdr["Status"]) == "True")
                    {
                        checkLog = true;
                        if (passwordTextBox.Text == Convert.ToString(sdr["Password"]))
                        {
                            switch (Convert.ToString(sdr["Role"]))
                            {
                                case "Администратор":
                                    AdministrationForm adminForm = new AdministrationForm
                                    {
                                        Login = loginTextBox.Text
                                    };
                                    adminForm.Show();
                                    this.Hide();
                                    break;
                                default:
                                    MedicForm medForm = new MedicForm
                                    {
                                        Login = loginTextBox.Text
                                    };
                                    medForm.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            warningLabel.Text = "Пароль неверный, попробуйте ещё раз!";
                            warningLabel.Visible = true;
                            passwordTextBox.Text = "";
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sdr != null)
                    sdr.Close();
                if (checkLog == false)
                {
                    warningLabel.Text = "Данный логин незарегистрирован!";
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                sqlConnection.Close();
            }
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) authorizationButton.PerformClick();
        }
    }
}
