namespace mis
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.userTypeTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.medicToolStrip = new System.Windows.Forms.ToolStrip();
            this.writeButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paramTextBox2 = new System.Windows.Forms.TextBox();
            this.paramLabel2 = new System.Windows.Forms.Label();
            this.paramTextBox1 = new System.Windows.Forms.TextBox();
            this.paramLabel1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.typePostComboBox = new System.Windows.Forms.ComboBox();
            this.typePostLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.userTypeTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.medicToolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(211, 308);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(87, 39);
            this.newEmployeeButton.TabIndex = 14;
            this.newEmployeeButton.Text = "Внести новую запись";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Visible = false;
            this.newEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(377, 295);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(87, 52);
            this.deleteUserButton.TabIndex = 8;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.userTypeTabControl);
            this.panel1.Controls.Add(this.deleteUserButton);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 354);
            this.panel1.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(404, 28);
            this.idTextBox.MaxLength = 9;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(377, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "ID:";
            // 
            // userTypeTabControl
            // 
            this.userTypeTabControl.Controls.Add(this.tabPage1);
            this.userTypeTabControl.Controls.Add(this.tabPage2);
            this.userTypeTabControl.Location = new System.Drawing.Point(3, 3);
            this.userTypeTabControl.Name = "userTypeTabControl";
            this.userTypeTabControl.SelectedIndex = 0;
            this.userTypeTabControl.Size = new System.Drawing.Size(372, 348);
            this.userTypeTabControl.TabIndex = 6;
            this.userTypeTabControl.SelectedIndexChanged += new System.EventHandler(this.UserTypeTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.usersListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи системы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(6, 6);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(352, 303);
            this.usersListBox.TabIndex = 5;
            this.usersListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersListBox_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.studentsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(6, 6);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(352, 303);
            this.studentsListBox.TabIndex = 7;
            this.studentsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentsListBox_MouseClick);
            // 
            // medicToolStrip
            // 
            this.medicToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeButton,
            this.updateButton});
            this.medicToolStrip.Location = new System.Drawing.Point(0, 49);
            this.medicToolStrip.Name = "medicToolStrip";
            this.medicToolStrip.Size = new System.Drawing.Size(800, 25);
            this.medicToolStrip.TabIndex = 3;
            this.medicToolStrip.Text = "toolStrip1";
            // 
            // writeButton
            // 
            this.writeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writeButton.Image = ((System.Drawing.Image)(resources.GetObject("writeButton.Image")));
            this.writeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(23, 22);
            this.writeButton.Text = "Режим редактирования";
            this.writeButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(23, 22);
            this.updateButton.Text = "Обновить";
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.paramTextBox2);
            this.panel2.Controls.Add(this.paramLabel2);
            this.panel2.Controls.Add(this.paramTextBox1);
            this.panel2.Controls.Add(this.paramLabel1);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.loginTextBox);
            this.panel2.Controls.Add(this.loginLabel);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.fullNameTextBox);
            this.panel2.Controls.Add(this.fullNameLabel);
            this.panel2.Controls.Add(this.typePostComboBox);
            this.panel2.Controls.Add(this.typePostLabel);
            this.panel2.Controls.Add(this.newEmployeeButton);
            this.panel2.Location = new System.Drawing.Point(487, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 354);
            this.panel2.TabIndex = 11;
            // 
            // paramTextBox2
            // 
            this.paramTextBox2.Location = new System.Drawing.Point(98, 207);
            this.paramTextBox2.Name = "paramTextBox2";
            this.paramTextBox2.Size = new System.Drawing.Size(200, 20);
            this.paramTextBox2.TabIndex = 15;
            this.paramTextBox2.Visible = false;
            // 
            // paramLabel2
            // 
            this.paramLabel2.AutoSize = true;
            this.paramLabel2.Location = new System.Drawing.Point(3, 210);
            this.paramLabel2.Name = "paramLabel2";
            this.paramLabel2.Size = new System.Drawing.Size(68, 13);
            this.paramLabel2.TabIndex = 15;
            this.paramLabel2.Text = "paramLabel2";
            this.paramLabel2.Visible = false;
            // 
            // paramTextBox1
            // 
            this.paramTextBox1.Location = new System.Drawing.Point(98, 175);
            this.paramTextBox1.Name = "paramTextBox1";
            this.paramTextBox1.Size = new System.Drawing.Size(200, 20);
            this.paramTextBox1.TabIndex = 14;
            this.paramTextBox1.Visible = false;
            // 
            // paramLabel1
            // 
            this.paramLabel1.AutoSize = true;
            this.paramLabel1.Location = new System.Drawing.Point(3, 178);
            this.paramLabel1.Name = "paramLabel1";
            this.paramLabel1.Size = new System.Drawing.Size(68, 13);
            this.paramLabel1.TabIndex = 14;
            this.paramLabel1.Text = "paramLabel1";
            this.paramLabel1.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(98, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.Visible = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(98, 109);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 20);
            this.loginTextBox.TabIndex = 12;
            this.loginTextBox.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(3, 112);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(98, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            this.dateTimePicker.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 80);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Дата";
            this.dateLabel.Visible = false;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(98, 45);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 10;
            this.fullNameTextBox.Visible = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 48);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(37, 13);
            this.fullNameLabel.TabIndex = 10;
            this.fullNameLabel.Text = "ФИО:";
            this.fullNameLabel.Visible = false;
            // 
            // typePostComboBox
            // 
            this.typePostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typePostComboBox.FormattingEnabled = true;
            this.typePostComboBox.Items.AddRange(new object[] {
            "Пользователь",
            "Студент"});
            this.typePostComboBox.Location = new System.Drawing.Point(98, 13);
            this.typePostComboBox.Name = "typePostComboBox";
            this.typePostComboBox.Size = new System.Drawing.Size(200, 21);
            this.typePostComboBox.TabIndex = 9;
            this.typePostComboBox.SelectedIndexChanged += new System.EventHandler(this.TypePostComboBox_SelectedIndexChanged);
            // 
            // typePostLabel
            // 
            this.typePostLabel.AutoSize = true;
            this.typePostLabel.Location = new System.Drawing.Point(3, 16);
            this.typePostLabel.Name = "typePostLabel";
            this.typePostLabel.Size = new System.Drawing.Size(68, 13);
            this.typePostLabel.TabIndex = 9;
            this.typePostLabel.Text = "Тип записи:";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medicToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AdministrationForm";
            this.Text = "Медпункт (Администрирование)";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.medicToolStrip, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userTypeTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.medicToolStrip.ResumeLayout(false);
            this.medicToolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip medicToolStrip;
        private System.Windows.Forms.ToolStripButton writeButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.TabControl userTypeTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.ComboBox typePostComboBox;
        private System.Windows.Forms.Label typePostLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox paramTextBox2;
        private System.Windows.Forms.Label paramLabel2;
        private System.Windows.Forms.TextBox paramTextBox1;
        private System.Windows.Forms.Label paramLabel1;
    }
}