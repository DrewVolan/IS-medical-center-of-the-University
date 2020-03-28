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
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(12, 386);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(115, 52);
            this.newEmployeeButton.TabIndex = 1;
            this.newEmployeeButton.Text = "Зарегистрировать нового сотрудника";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // newStudentButton
            // 
            this.newStudentButton.Location = new System.Drawing.Point(133, 386);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(115, 52);
            this.newStudentButton.TabIndex = 2;
            this.newStudentButton.Text = "Зарегистрировать нового студента";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.NewStudentButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(673, 386);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(115, 52);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.newEmployeeButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AdministrationForm";
            this.Text = "Медпункт (Администрирование)";
            this.Controls.SetChildIndex(this.newEmployeeButton, 0);
            this.Controls.SetChildIndex(this.newStudentButton, 0);
            this.Controls.SetChildIndex(this.deleteUserButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button deleteUserButton;
    }
}