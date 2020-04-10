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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicForm));
            this.newTreatmentButton = new System.Windows.Forms.Button();
            this.treatmentTextBox = new mis.TextBoxMultiline();
            this.medicTextBoxMultilineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicToolStrip = new System.Windows.Forms.ToolStrip();
            this.writeButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treatmentsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.medicTextBoxMultilineContextMenuStrip.SuspendLayout();
            this.medicToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTreatmentButton
            // 
            this.newTreatmentButton.Location = new System.Drawing.Point(12, 415);
            this.newTreatmentButton.Name = "newTreatmentButton";
            this.newTreatmentButton.Size = new System.Drawing.Size(110, 23);
            this.newTreatmentButton.TabIndex = 7;
            this.newTreatmentButton.Text = "Новая жалоба";
            this.newTreatmentButton.UseVisualStyleBackColor = true;
            this.newTreatmentButton.Click += new System.EventHandler(this.NewTreatmentButton_Click);
            // 
            // treatmentTextBox
            // 
            this.treatmentTextBox.Auto_Size = false;
            this.treatmentTextBox.Location = new System.Drawing.Point(3, 3);
            this.treatmentTextBox.Multi_Line = true;
            this.treatmentTextBox.Multiline = true;
            this.treatmentTextBox.Name = "treatmentTextBox";
            this.treatmentTextBox.Size = new System.Drawing.Size(448, 262);
            this.treatmentTextBox.TabIndex = 5;
            // 
            // medicTextBoxMultilineContextMenuStrip
            // 
            this.medicTextBoxMultilineContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.toolStripSeparator1,
            this.отменитьToolStripMenuItem});
            this.medicTextBoxMultilineContextMenuStrip.Name = "medicTextBoxMultilineContextMenuStrip";
            this.medicTextBoxMultilineContextMenuStrip.Size = new System.Drawing.Size(140, 98);
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
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cutToolStripMenuItem.Text = "Очистить";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.treatmentsListBox);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 299);
            this.panel1.TabIndex = 10;
            // 
            // treatmentsListBox
            // 
            this.treatmentsListBox.FormattingEnabled = true;
            this.treatmentsListBox.Location = new System.Drawing.Point(3, 3);
            this.treatmentsListBox.Name = "treatmentsListBox";
            this.treatmentsListBox.Size = new System.Drawing.Size(310, 290);
            this.treatmentsListBox.TabIndex = 4;
            this.treatmentsListBox.SelectedIndexChanged += new System.EventHandler(this.TreatmentsListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.typeComboBox);
            this.panel2.Controls.Add(this.typeLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.treatmentTextBox);
            this.panel2.Controls.Add(this.studentTextBox);
            this.panel2.Controls.Add(this.studentComboBox);
            this.panel2.Location = new System.Drawing.Point(334, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 358);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО студента:";
            // 
            // studentTextBox
            // 
            this.studentTextBox.Location = new System.Drawing.Point(94, 271);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.ReadOnly = true;
            this.studentTextBox.Size = new System.Drawing.Size(357, 20);
            this.studentTextBox.TabIndex = 6;
            // 
            // studentComboBox
            // 
            this.studentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(94, 271);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(357, 21);
            this.studentComboBox.TabIndex = 6;
            this.studentComboBox.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 335);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(89, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Тип обращения:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Жалоба",
            "Прививка"});
            this.typeComboBox.Location = new System.Drawing.Point(101, 332);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // MedicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medicToolStrip);
            this.Controls.Add(this.newTreatmentButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MedicForm";
            this.Text = "Медпункт";
            this.Load += new System.EventHandler(this.MedicForm_Load);
            this.Controls.SetChildIndex(this.newTreatmentButton, 0);
            this.Controls.SetChildIndex(this.medicToolStrip, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.medicTextBoxMultilineContextMenuStrip.ResumeLayout(false);
            this.medicToolStrip.ResumeLayout(false);
            this.medicToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStrip medicToolStrip;
        private System.Windows.Forms.ToolStripButton writeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox treatmentsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
    }
}