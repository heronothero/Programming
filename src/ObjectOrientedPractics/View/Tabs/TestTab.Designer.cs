namespace ObjectOrientedPractics.View.Tabs
{
    partial class TestTab
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
            this.TestOutputListBox = new System.Windows.Forms.ListBox();
            this.CloneTestButton = new System.Windows.Forms.Button();
            this.EqualsTestButton = new System.Windows.Forms.Button();
            this.CompareTestButton = new System.Windows.Forms.Button();
            this.DiscountTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestOutputListBox
            // 
            this.TestOutputListBox.FormattingEnabled = true;
            this.TestOutputListBox.ItemHeight = 16;
            this.TestOutputListBox.Location = new System.Drawing.Point(27, 31);
            this.TestOutputListBox.Name = "TestOutputListBox";
            this.TestOutputListBox.Size = new System.Drawing.Size(294, 372);
            this.TestOutputListBox.TabIndex = 0;
            this.TestOutputListBox.SelectedIndexChanged += new System.EventHandler(this.TestOutputListBox_SelectedIndexChanged);
            // 
            // CloneTestButton
            // 
            this.CloneTestButton.Location = new System.Drawing.Point(376, 34);
            this.CloneTestButton.Name = "CloneTestButton";
            this.CloneTestButton.Size = new System.Drawing.Size(133, 39);
            this.CloneTestButton.TabIndex = 1;
            this.CloneTestButton.Text = "Clone";
            this.CloneTestButton.UseVisualStyleBackColor = true;
            this.CloneTestButton.Click += new System.EventHandler(this.CloneTestButton_Click);
            // 
            // EqualsTestButton
            // 
            this.EqualsTestButton.Location = new System.Drawing.Point(376, 109);
            this.EqualsTestButton.Name = "EqualsTestButton";
            this.EqualsTestButton.Size = new System.Drawing.Size(133, 39);
            this.EqualsTestButton.TabIndex = 2;
            this.EqualsTestButton.Text = "Equals";
            this.EqualsTestButton.UseVisualStyleBackColor = true;
            this.EqualsTestButton.Click += new System.EventHandler(this.EqualsTestButton_Click);
            // 
            // CompareTestButton
            // 
            this.CompareTestButton.Location = new System.Drawing.Point(376, 192);
            this.CompareTestButton.Name = "CompareTestButton";
            this.CompareTestButton.Size = new System.Drawing.Size(133, 39);
            this.CompareTestButton.TabIndex = 3;
            this.CompareTestButton.Text = "Compare";
            this.CompareTestButton.UseVisualStyleBackColor = true;
            this.CompareTestButton.Click += new System.EventHandler(this.CompareTestButton_Click);
            // 
            // DiscountTestButton
            // 
            this.DiscountTestButton.Location = new System.Drawing.Point(376, 270);
            this.DiscountTestButton.Name = "DiscountTestButton";
            this.DiscountTestButton.Size = new System.Drawing.Size(133, 39);
            this.DiscountTestButton.TabIndex = 4;
            this.DiscountTestButton.Text = "Discount";
            this.DiscountTestButton.UseVisualStyleBackColor = true;
            this.DiscountTestButton.Click += new System.EventHandler(this.DiscountTestButton_Click);
            // 
            // TestTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountTestButton);
            this.Controls.Add(this.CompareTestButton);
            this.Controls.Add(this.EqualsTestButton);
            this.Controls.Add(this.CloneTestButton);
            this.Controls.Add(this.TestOutputListBox);
            this.Name = "TestTab";
            this.Size = new System.Drawing.Size(717, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TestOutputListBox;
        private System.Windows.Forms.Button CloneTestButton;
        private System.Windows.Forms.Button EqualsTestButton;
        private System.Windows.Forms.Button CompareTestButton;
        private System.Windows.Forms.Button DiscountTestButton;
    }
}
