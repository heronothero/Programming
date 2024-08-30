namespace Programming.View.Panels
{
    partial class RingsControl
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.outerRadiusBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.innerRadiusBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ringsBox = new System.Windows.Forms.ListBox();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.areaBox);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.outerRadiusBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.innerRadiusBox);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.ringsBox);
            this.groupBox5.Location = new System.Drawing.Point(3, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 158);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rings";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(157, 117);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(167, 20);
            this.areaBox.TabIndex = 6;
            this.areaBox.TextChanged += new System.EventHandler(this.areaBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(155, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Area";
            // 
            // outerRadiusBox
            // 
            this.outerRadiusBox.Location = new System.Drawing.Point(156, 78);
            this.outerRadiusBox.Name = "outerRadiusBox";
            this.outerRadiusBox.Size = new System.Drawing.Size(168, 20);
            this.outerRadiusBox.TabIndex = 4;
            this.outerRadiusBox.TextChanged += new System.EventHandler(this.outerRadiusBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Outer Radius";
            // 
            // innerRadiusBox
            // 
            this.innerRadiusBox.Location = new System.Drawing.Point(156, 38);
            this.innerRadiusBox.Name = "innerRadiusBox";
            this.innerRadiusBox.Size = new System.Drawing.Size(168, 20);
            this.innerRadiusBox.TabIndex = 2;
            this.innerRadiusBox.TextChanged += new System.EventHandler(this.innerRadiusBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(155, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Inner Radius";
            // 
            // ringsBox
            // 
            this.ringsBox.FormattingEnabled = true;
            this.ringsBox.Location = new System.Drawing.Point(10, 19);
            this.ringsBox.Name = "ringsBox";
            this.ringsBox.Size = new System.Drawing.Size(133, 121);
            this.ringsBox.TabIndex = 0;
            this.ringsBox.SelectedIndexChanged += new System.EventHandler(this.ringsBox_SelectedIndexChanged);
            // 
            // RingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "RingsControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox outerRadiusBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox innerRadiusBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox ringsBox;
    }
}
