
namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.seasonButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.dayInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enumerationsBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RectanglesBox = new System.Windows.Forms.ListBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.enumerationsBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.groupBox2);
            this.Enums.Controls.Add(this.groupBox1);
            this.Enums.Controls.Add(this.enumerationsBox);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(874, 624);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seasonComboBox);
            this.groupBox2.Controls.Add(this.seasonButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(481, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Season handle";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(18, 63);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(245, 24);
            this.seasonComboBox.TabIndex = 3;
            this.seasonComboBox.SelectedIndexChanged += new System.EventHandler(this.seasonComboBox_SelectedIndexChanged);
            // 
            // seasonButton
            // 
            this.seasonButton.Location = new System.Drawing.Point(281, 62);
            this.seasonButton.Name = "seasonButton";
            this.seasonButton.Size = new System.Drawing.Size(98, 23);
            this.seasonButton.TabIndex = 2;
            this.seasonButton.Text = "Go!";
            this.seasonButton.UseVisualStyleBackColor = true;
            this.seasonButton.Click += new System.EventHandler(this.seasonButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose a season:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.resultButton);
            this.groupBox1.Controls.Add(this.dayInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekday parsing";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 108);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(326, 63);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(120, 23);
            this.resultButton.TabIndex = 2;
            this.resultButton.Text = "Parse";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // dayInput
            // 
            this.dayInput.Location = new System.Drawing.Point(17, 63);
            this.dayInput.Name = "dayInput";
            this.dayInput.Size = new System.Drawing.Size(297, 22);
            this.dayInput.TabIndex = 1;
            this.dayInput.TextChanged += new System.EventHandler(this.dayInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // enumerationsBox
            // 
            this.enumerationsBox.Controls.Add(this.label3);
            this.enumerationsBox.Controls.Add(this.label2);
            this.enumerationsBox.Controls.Add(this.label1);
            this.enumerationsBox.Controls.Add(this.ValueTextBox);
            this.enumerationsBox.Controls.Add(this.ValueListBox);
            this.enumerationsBox.Controls.Add(this.EnumsListBox);
            this.enumerationsBox.Location = new System.Drawing.Point(8, 8);
            this.enumerationsBox.Name = "enumerationsBox";
            this.enumerationsBox.Size = new System.Drawing.Size(858, 341);
            this.enumerationsBox.TabIndex = 0;
            this.enumerationsBox.TabStop = false;
            this.enumerationsBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(441, 59);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(172, 22);
            this.ValueTextBox.TabIndex = 1;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 16;
            this.ValueListBox.Location = new System.Drawing.Point(232, 59);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(169, 260);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(17, 59);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(169, 260);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(874, 624);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.findButton);
            this.groupBox3.Controls.Add(this.colorBox);
            this.groupBox3.Controls.Add(this.widthBox);
            this.groupBox3.Controls.Add(this.lengthBox);
            this.groupBox3.Controls.Add(this.RectanglesBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 302);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            // 
            // RectanglesBox
            // 
            this.RectanglesBox.FormattingEnabled = true;
            this.RectanglesBox.ItemHeight = 16;
            this.RectanglesBox.Location = new System.Drawing.Point(14, 24);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Size = new System.Drawing.Size(176, 260);
            this.RectanglesBox.TabIndex = 0;
            this.RectanglesBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesBox_SelectedIndexChanged);
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(211, 46);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(133, 22);
            this.lengthBox.TabIndex = 1;
            this.lengthBox.TextChanged += new System.EventHandler(this.lengthBox_TextChanged);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(211, 109);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(133, 22);
            this.widthBox.TabIndex = 2;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(211, 171);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(133, 22);
            this.colorBox.TabIndex = 3;
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(211, 252);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(133, 32);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Color";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.enumerationsBox.ResumeLayout(false);
            this.enumerationsBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.GroupBox enumerationsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.TextBox dayInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button seasonButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox RectanglesBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
    }
}

