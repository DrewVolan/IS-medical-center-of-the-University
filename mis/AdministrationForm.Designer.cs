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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНовогоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйСотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияНовогоПользователяToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // регистрацияНовогоПользователяToolStripMenuItem
            // 
            this.регистрацияНовогоПользователяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйСотрудникToolStripMenuItem,
            this.новыйСтудентToolStripMenuItem});
            this.регистрацияНовогоПользователяToolStripMenuItem.Name = "регистрацияНовогоПользователяToolStripMenuItem";
            this.регистрацияНовогоПользователяToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.регистрацияНовогоПользователяToolStripMenuItem.Text = "Регистрация нового пользователя";
            // 
            // новыйСотрудникToolStripMenuItem
            // 
            this.новыйСотрудникToolStripMenuItem.Name = "новыйСотрудникToolStripMenuItem";
            this.новыйСотрудникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйСотрудникToolStripMenuItem.Text = "Новый сотрудник";
            this.новыйСотрудникToolStripMenuItem.Click += new System.EventHandler(this.НовыйСотрудникToolStripMenuItem_Click);
            // 
            // новыйСтудентToolStripMenuItem
            // 
            this.новыйСтудентToolStripMenuItem.Name = "новыйСтудентToolStripMenuItem";
            this.новыйСтудентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйСтудентToolStripMenuItem.Text = "Новый студент";
            this.новыйСтудентToolStripMenuItem.Click += new System.EventHandler(this.НовыйСтудентToolStripMenuItem_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.Text = "Медпункт (Администрирование)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНовогоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйСотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйСтудентToolStripMenuItem;
    }
}