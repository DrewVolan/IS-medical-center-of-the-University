﻿using System;
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
        /// <summary>
        /// Логин, под которым зашёл пользователь.
        /// </summary>
        public String Login = String.Empty;
        /// <summary>
        /// Буфер обмена.
        /// </summary>
        public string buffer;
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
