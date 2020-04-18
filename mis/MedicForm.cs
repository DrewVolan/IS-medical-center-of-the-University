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
    public partial class MedicForm : StandartForm
    {
        public MedicForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            treatmentTextBox.ContextMenuStrip = medicTextBoxMultilineContextMenuStrip;
        }

        private async void NewTreatmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (treatmentTextBox.Text != "" && studentComboBox.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Создать новую жалобу?", "Новая жалоба", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlConnection = new SqlConnection(connectionPath);
                        SqlCommand insertTreatment = new SqlCommand("INSERT INTO[MedicalHistory](IdStudent, IdStaff, Date, Type, Info)VALUES(@IdStudent, @IdStaff, @Date, @Type, @Info)", sqlConnection);
                        SqlCommand idStaff = new SqlCommand("SELECT * FROM [Staff] WHERE [Login]=@Login", sqlConnection);
                        idStaff.Parameters.AddWithValue("Login", Login);
                        string staffId = null;
                        await sqlConnection.OpenAsync();
                        sdr = await idStaff.ExecuteReaderAsync();
                        while (await sdr.ReadAsync())
                        {
                            if (sdr["Login"].ToString() == Login)
                            {
                                staffId = sdr["Id"].ToString();
                                break;
                            }
                        }
                        sdr.Close();
                        insertTreatment.Parameters.AddWithValue("IdStudent", studentComboBox.SelectedItem.ToString().Split(' ')[0]);
                        insertTreatment.Parameters.AddWithValue("IdStaff", staffId);
                        insertTreatment.Parameters.AddWithValue("Date", DateTime.Now);
                        insertTreatment.Parameters.AddWithValue("Type", typeComboBox.Text);
                        insertTreatment.Parameters.AddWithValue("Info", treatmentTextBox.Text);
                        await insertTreatment.ExecuteNonQueryAsync();
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Новая жалоба", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void MedicForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();
            SqlCommand selectTreatments = new SqlCommand("SELECT * FROM [MedicalHistory]", sqlConnection);
            try
            {
                sdr = await selectTreatments.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    treatmentsListBox.Items.Add(Convert.ToString(sdr["Id"]) + " " + Convert.ToString(sdr["Date"]) + " " + Convert.ToString(sdr["Type"]) + " ID студента: " + Convert.ToString(sdr["IdStudent"]));
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DataSet DS = new DataSet();
            SqlDataAdapter sdaProduct = new SqlDataAdapter("SELECT * FROM [Students]", sqlConnection);
            sdaProduct.Fill(DS, "Students");
            studentComboBox.Items.Clear();
            for (int i = 0; i < DS.Tables["Students"].Rows.Count; i++)
            {
                if (DS.Tables["Students"].Rows[i][8].ToString() == "True")
                    studentComboBox.Items.Add(DS.Tables["Students"].Rows[i][0].ToString() + " " + DS.Tables["Students"].Rows[i][9].ToString() + " " + DS.Tables["Students"].Rows[i][1].ToString() + " " + DS.Tables["Students"].Rows[i][2].ToString() + " " + DS.Tables["Students"].Rows[i][3].ToString());
            }
            sqlConnection.Close();
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

        private async void TreatmentsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (treatmentsListBox.SelectedIndex != -1 && readOnlyParameter)
                {
                    sqlConnection = new SqlConnection(connectionPath);
                    SqlCommand selectTreatment = new SqlCommand("SELECT * FROM [MedicalHistory] WHERE [Id]=@Id", sqlConnection);
                    await sqlConnection.OpenAsync();
                    selectTreatment.Parameters.AddWithValue("Id", treatmentsListBox.SelectedItem.ToString().Split(' ')[0]);
                    sdr = await selectTreatment.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        treatmentTextBox.Text = Convert.ToString(sdr["Info"]);
                        studentTextBox.Text = Convert.ToString(sdr["IdStudent"]);
                        typeComboBox.Text = Convert.ToString(sdr["Type"]);
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
    }
}
