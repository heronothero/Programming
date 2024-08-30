
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
            this.seasonHandleControl1 = new Programming.View.Panels.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.enumerationControl = new Programming.View.Panels.EnumerationControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.collisionRingsBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.collisionRectanglesBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.outerRadiusBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.innerRadiusBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ringsBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.seasonHandleControl1);
            this.Enums.Controls.Add(this.weekdayParsingControl1);
            this.Enums.Controls.Add(this.enumerationControl);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Margin = new System.Windows.Forms.Padding(2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(2);
            this.Enums.Size = new System.Drawing.Size(776, 535);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(359, 3);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(397, 135);
            this.seasonHandleControl1.TabIndex = 7;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(359, 195);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(397, 165);
            this.weekdayParsingControl1.TabIndex = 6;
            // 
            // enumerationControl
            // 
            this.enumerationControl.Location = new System.Drawing.Point(8, 0);
            this.enumerationControl.Name = "enumerationControl";
            this.enumerationControl.Size = new System.Drawing.Size(330, 360);
            this.enumerationControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moviesControl1);
            this.tabPage1.Controls.Add(this.rectanglesControl1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(8, 8);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(350, 360);
            this.rectanglesControl1.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.collisionRingsBox);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.collisionRectanglesBox);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(374, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 158);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Collision";
            // 
            // collisionRingsBox
            // 
            this.collisionRingsBox.Location = new System.Drawing.Point(37, 101);
            this.collisionRingsBox.Name = "collisionRingsBox";
            this.collisionRingsBox.Size = new System.Drawing.Size(324, 20);
            this.collisionRingsBox.TabIndex = 3;
            this.collisionRingsBox.TextChanged += new System.EventHandler(this.collisionRingsBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Rings collision";
            // 
            // collisionRectanglesBox
            // 
            this.collisionRectanglesBox.Location = new System.Drawing.Point(37, 55);
            this.collisionRectanglesBox.Name = "collisionRectanglesBox";
            this.collisionRectanglesBox.Size = new System.Drawing.Size(324, 20);
            this.collisionRectanglesBox.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Rectangles collision";
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
            this.groupBox5.Location = new System.Drawing.Point(13, 369);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 158);
            this.groupBox5.TabIndex = 2;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rectanglesCollisionControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(776, 535);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Rectangles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl
            // 
            this.rectanglesCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            this.rectanglesCollisionControl.Size = new System.Drawing.Size(776, 535);
            this.rectanglesCollisionControl.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(368, 8);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(400, 360);
            this.moviesControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox ringsBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox outerRadiusBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox innerRadiusBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox collisionRingsBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox collisionRectanglesBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl;
        private View.Panels.EnumerationControl enumerationControl;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
    }
}

