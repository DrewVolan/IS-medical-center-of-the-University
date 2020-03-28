namespace mis
{
    partial class MedicForm
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
            this.components = new System.ComponentModel.Container();
            this.newTreatmentButton = new System.Windows.Forms.Button();
            this.treatmentTextBox = new mis.TextBoxMultiline();
            this.medicTextBoxMultilineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicTextBoxMultilineContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTreatmentButton
            // 
            this.newTreatmentButton.Location = new System.Drawing.Point(12, 415);
            this.newTreatmentButton.Name = "newTreatmentButton";
            this.newTreatmentButton.Size = new System.Drawing.Size(110, 23);
            this.newTreatmentButton.TabIndex = 2;
            this.newTreatmentButton.Text = "Новое обращение";
            this.newTreatmentButton.UseVisualStyleBackColor = true;
            this.newTreatmentButton.Click += new System.EventHandler(this.NewTreatmentButton_Click);
            // 
            // treatmentTextBox
            // 
            this.treatmentTextBox.Auto_Size = false;
            this.treatmentTextBox.Location = new System.Drawing.Point(12, 63);
            this.treatmentTextBox.Multi_Line = true;
            this.treatmentTextBox.Multiline = true;
            this.treatmentTextBox.Name = "treatmentTextBox";
            this.treatmentTextBox.Size = new System.Drawing.Size(641, 296);
            this.treatmentTextBox.TabIndex = 1;
            // 
            // medicTextBoxMultilineContextMenuStrip
            // 
            this.medicTextBoxMultilineContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.отменитьToolStripMenuItem});
            this.medicTextBoxMultilineContextMenuStrip.Name = "medicTextBoxMultilineContextMenuStrip";
            this.medicTextBoxMultilineContextMenuStrip.Size = new System.Drawing.Size(140, 76);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ВставитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.ОтменитьToolStripMenuItem_Click);
            // 
            // MedicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treatmentTextBox);
            this.Controls.Add(this.newTreatmentButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MedicForm";
            this.Text = "Медпункт";
            this.Controls.SetChildIndex(this.newTreatmentButton, 0);
            this.Controls.SetChildIndex(this.treatmentTextBox, 0);
            this.medicTextBoxMultilineContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTreatmentButton;
        private TextBoxMultiline treatmentTextBox;
        private System.Windows.Forms.ContextMenuStrip medicTextBoxMultilineContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
    }
}