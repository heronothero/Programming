
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
            this.ringsControl1 = new Programming.View.Panels.RingsControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.seasonHandleControl1);
            this.Enums.Controls.Add(this.weekdayParsingControl1);
            this.Enums.Controls.Add(this.enumerationControl);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enums.Size = new System.Drawing.Size(1037, 661);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(479, 4);
            this.seasonHandleControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(529, 166);
            this.seasonHandleControl1.TabIndex = 7;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(479, 240);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(529, 203);
            this.weekdayParsingControl1.TabIndex = 6;
            // 
            // enumerationControl
            // 
            this.enumerationControl.Location = new System.Drawing.Point(11, 0);
            this.enumerationControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enumerationControl.Name = "enumerationControl";
            this.enumerationControl.Size = new System.Drawing.Size(440, 443);
            this.enumerationControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ringsControl1);
            this.tabPage1.Controls.Add(this.moviesControl1);
            this.tabPage1.Controls.Add(this.rectanglesControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1037, 661);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ringsControl1
            // 
            this.ringsControl1.Location = new System.Drawing.Point(11, 458);
            this.ringsControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ringsControl1.Name = "ringsControl1";
            this.ringsControl1.Size = new System.Drawing.Size(467, 197);
            this.ringsControl1.TabIndex = 6;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(491, 10);
            this.moviesControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(533, 443);
            this.moviesControl1.TabIndex = 5;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(11, 10);
            this.rectanglesControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(467, 443);
            this.rectanglesControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rectanglesCollisionControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1037, 661);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Rectangles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl
            // 
            this.rectanglesCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            this.rectanglesCollisionControl.Size = new System.Drawing.Size(1035, 658);
            this.rectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl;
        private View.Panels.EnumerationControl enumerationControl;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.RingsControl ringsControl1;
    }
}

