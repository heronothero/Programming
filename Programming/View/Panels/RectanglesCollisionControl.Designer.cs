namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.rectanglesPanel = new System.Windows.Forms.Panel();
            this.lengthRectangleBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.widthRectangleBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.YCenterBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.XCenterBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.IDRectangleBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addPictureBox
            // 
            this.addPictureBox.Image = global::Programming.Properties.Resources.addIcon;
            this.addPictureBox.Location = new System.Drawing.Point(92, 248);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(32, 32);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 32;
            this.addPictureBox.TabStop = false;
            this.addPictureBox.Click += new System.EventHandler(this.addPictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = global::Programming.Properties.Resources.deleteIcon;
            this.deletePictureBox.Location = new System.Drawing.Point(166, 248);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(32, 32);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 33;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // rectanglesPanel
            // 
            this.rectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectanglesPanel.Location = new System.Drawing.Point(324, 18);
            this.rectanglesPanel.Name = "rectanglesPanel";
            this.rectanglesPanel.Size = new System.Drawing.Size(436, 498);
            this.rectanglesPanel.TabIndex = 31;
            this.rectanglesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rectanglesPanel_Paint);
            // 
            // lengthRectangleBox
            // 
            this.lengthRectangleBox.Location = new System.Drawing.Point(66, 496);
            this.lengthRectangleBox.Name = "lengthRectangleBox";
            this.lengthRectangleBox.Size = new System.Drawing.Size(142, 20);
            this.lengthRectangleBox.TabIndex = 30;
            this.lengthRectangleBox.TextChanged += new System.EventHandler(this.lengthRectangleBox_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 499);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "Length:";
            // 
            // widthRectangleBox
            // 
            this.widthRectangleBox.Location = new System.Drawing.Point(66, 456);
            this.widthRectangleBox.Name = "widthRectangleBox";
            this.widthRectangleBox.Size = new System.Drawing.Size(142, 20);
            this.widthRectangleBox.TabIndex = 28;
            this.widthRectangleBox.TextChanged += new System.EventHandler(this.widthRectangleBox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 459);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Width:";
            // 
            // YCenterBox
            // 
            this.YCenterBox.Location = new System.Drawing.Point(66, 416);
            this.YCenterBox.Name = "YCenterBox";
            this.YCenterBox.Size = new System.Drawing.Size(142, 20);
            this.YCenterBox.TabIndex = 26;
            this.YCenterBox.TextChanged += new System.EventHandler(this.YCenterBox_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(39, 419);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Y:";
            // 
            // XCenterBox
            // 
            this.XCenterBox.Location = new System.Drawing.Point(66, 376);
            this.XCenterBox.Name = "XCenterBox";
            this.XCenterBox.Size = new System.Drawing.Size(142, 20);
            this.XCenterBox.TabIndex = 24;
            this.XCenterBox.TextChanged += new System.EventHandler(this.XCenterBox_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 379);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "X:";
            // 
            // IDRectangleBox
            // 
            this.IDRectangleBox.Location = new System.Drawing.Point(66, 336);
            this.IDRectangleBox.Name = "IDRectangleBox";
            this.IDRectangleBox.Size = new System.Drawing.Size(142, 20);
            this.IDRectangleBox.TabIndex = 22;
            this.IDRectangleBox.TextChanged += new System.EventHandler(this.IDRectangleBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(39, 339);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 306);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Selected Rectangle:";
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(23, 34);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(280, 199);
            this.rectanglesListBox.TabIndex = 19;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.rectanglesListBox_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Rectangles:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.rectanglesPanel);
            this.Controls.Add(this.lengthRectangleBox);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.widthRectangleBox);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.YCenterBox);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.XCenterBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.IDRectangleBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.rectanglesListBox);
            this.Controls.Add(this.label22);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(776, 535);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.Panel rectanglesPanel;
        private System.Windows.Forms.TextBox lengthRectangleBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox widthRectangleBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox YCenterBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox XCenterBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox IDRectangleBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Label label22;
    }
}
