namespace Programming.View.Panels
{
    partial class RectanglesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.centerYBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.centerXBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.RectanglesBox = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.idBox);
            this.groupBox3.Controls.Add(this.centerYBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.centerXBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.findButton);
            this.groupBox3.Controls.Add(this.colorBox);
            this.groupBox3.Controls.Add(this.widthBox);
            this.groupBox3.Controls.Add(this.lengthBox);
            this.groupBox3.Controls.Add(this.RectanglesBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(345, 352);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(155, 36);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(145, 20);
            this.idBox.TabIndex = 8;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // centerYBox
            // 
            this.centerYBox.Location = new System.Drawing.Point(154, 223);
            this.centerYBox.Name = "centerYBox";
            this.centerYBox.Size = new System.Drawing.Size(146, 20);
            this.centerYBox.TabIndex = 11;
            this.centerYBox.TextChanged += new System.EventHandler(this.centerYBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(154, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "X";
            // 
            // centerXBox
            // 
            this.centerXBox.Location = new System.Drawing.Point(154, 177);
            this.centerXBox.Name = "centerXBox";
            this.centerXBox.Size = new System.Drawing.Size(146, 20);
            this.centerXBox.TabIndex = 8;
            this.centerXBox.TextChanged += new System.EventHandler(this.centerXBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Length";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(154, 309);
            this.findButton.Margin = new System.Windows.Forms.Padding(2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 26);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(154, 269);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(146, 20);
            this.colorBox.TabIndex = 3;
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(155, 130);
            this.widthBox.Margin = new System.Windows.Forms.Padding(2);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(147, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(155, 82);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(2);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(147, 20);
            this.lengthBox.TabIndex = 1;
            this.lengthBox.TextChanged += new System.EventHandler(this.lengthBox_TextChanged);
            // 
            // RectanglesBox
            // 
            this.RectanglesBox.FormattingEnabled = true;
            this.RectanglesBox.Location = new System.Drawing.Point(10, 20);
            this.RectanglesBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Size = new System.Drawing.Size(133, 316);
            this.RectanglesBox.TabIndex = 0;
            this.RectanglesBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(350, 360);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox centerYBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox centerXBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.ListBox RectanglesBox;
    }
}
