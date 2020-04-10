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
    /// <summary>
    /// Класс родительской формы со всеми одинаковыми опциями для остальных форм.
    /// </summary>
    public partial class StandartForm : Form
    {
        /// <summary>
        /// Логин, под которым зашёл пользователь.
        /// </summary>
        public String Login = String.Empty;
        /// <summary>
        /// Путь к базе данных.
        /// </summary>
        //public string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MedicalDatabase.mdf; Integrated Security=True";
        public string connectionPath = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Desktop\Учёба\3 курс\2 семестр\Технология проектирования ИС\Лабораторная работа №7-10\mis\mis\MedicalDatabase.mdf';Integrated Security = True; Connect Timeout = 30";
        public SqlConnection sqlConnection;
        public SqlDataReader sdr;
        /// <summary>
        /// Буфер обмена.
        /// </summary>
        public string buffer;
        /// <summary>
        /// Параметр проверки опции "Только для чтения".
        /// </summary>
        public bool readOnlyParameter = true;
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

        private void StandartForm_Load(object sender, EventArgs e)
        {
            showLogin.Text += $"{Login}.";

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО разработчика: Волейко Андрей Владимирович\nГруппа: 171-371\nВариант: 7\nНаименование программы: ИС - медпункт вуза", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        public void Undo()
        {
            //throw new NotImplementedException();
            MessageBox.Show("Метод Undo");
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Метод Save");
        }
    }
}
