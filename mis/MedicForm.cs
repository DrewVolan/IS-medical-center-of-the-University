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
            treatments[0, 0] = "Проверочная жалоба!";
            treatments[0, 1] = "Волейко Андрей Владимирович";
            treatments[1, 1] = "Ивлев Дмитрий Сергеевич";
            treatments[1, 0] = "Проверка жалобы.";
            treatments[0, 2] = "01.09.2017";
            treatments[1, 2] = "02.09.2017";
            students[0] = "Волейко Андрей Владимирович";
            students[1] = "Ивлев Дмитрий Сергеевич";
        }

        private void NewTreatmentButton_Click(object sender, EventArgs e)
        {
            if (treatmentTextBox.Text != "" && studentComboBox.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Создать новую жалобу?", "Новая жалоба", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < treatments.Length; i++)
                        {
                            if (treatments[i, 0] == null)
                            {
                                treatments[i, 0] = treatmentTextBox.Text;
                                treatments[i, 1] = studentComboBox.Text;
                                treatments[i, 2] = DateTime.Now.ToString();
                                treatmentsListBox.Items.Add(treatments[i, 2]);
                                break;
                            }
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Новая жалоба", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public string[,] treatments = new string[10, 3];
        public string[] students = new string[10];

        private void MedicForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; treatments[i, 0] != null; i++)
            {
                treatmentsListBox.Items.Add($"{treatments[i, 2]} {treatments[i, 1]}");
                studentComboBox.Items.Add(treatments[i, 1]);
            }
            if (readOnlyParameter)
            {
                newTreatmentButton.Visible = false;
                treatmentTextBox.Enabled = false;
                treatmentTextBox.ReadOnly = true;
                studentComboBox.Visible = false;
                studentTextBox.Visible = true;
            }
            else
            {
                newTreatmentButton.Visible = true;
                treatmentTextBox.Enabled = true;
                treatmentTextBox.ReadOnly = false;
                studentComboBox.Visible = true;
                studentTextBox.Visible = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            treatmentTextBox.Clear();
            treatmentsListBox.Items.Clear();
            studentComboBox.Items.Clear();
            studentTextBox.Clear();
            treatmentsListBox.SelectedIndex = -1;
            studentComboBox.SelectedIndex = -1;
            MedicForm_Load(this, e);
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treatmentTextBox.Clear();
        }

        private void TreatmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readOnlyParameter)
            {
                treatmentTextBox.Text = treatments[treatmentsListBox.SelectedIndex, 0];
                studentTextBox.Text = treatments[treatmentsListBox.SelectedIndex, 1];
            }
        }
    }
}
