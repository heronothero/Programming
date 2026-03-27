namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address3 = new ObjectOrientedPractics.Model.Address();
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.CustomersPanel2 = new System.Windows.Forms.Panel();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IdCustomerLabel = new System.Windows.Forms.Label();
            this.IdCustomerTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.CustomersPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.ColumnCount = 4;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.88733F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.88733F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.88733F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.338F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersLabel, 0, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersListBox, 0, 1);
            this.CustomersTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 2);
            this.CustomersTableLayoutPanel.Controls.Add(this.AddButton, 0, 2);
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersPanel, 3, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 2);
            this.CustomersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 3;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.044409F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.25852F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69707F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(1072, 620);
            this.CustomersTableLayoutPanel.TabIndex = 1;
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 4);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(80, 16);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersTableLayoutPanel.SetColumnSpan(this.CustomersListBox, 3);
            this.CustomersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 27);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(341, 516);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(119, 549);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(110, 69);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(3, 549);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 69);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersPanel.Controls.Add(this.CustomersPanel2);
            this.CustomersPanel.Controls.Add(this.tableLayoutPanel1);
            this.CustomersPanel.Controls.Add(this.SelectedCustomerLabel);
            this.CustomersPanel.Location = new System.Drawing.Point(351, 2);
            this.CustomersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersTableLayoutPanel.SetRowSpan(this.CustomersPanel, 3);
            this.CustomersPanel.Size = new System.Drawing.Size(718, 615);
            this.CustomersPanel.TabIndex = 5;
            // 
            // CustomersPanel2
            // 
            this.CustomersPanel2.Controls.Add(this.tableLayoutPanel2);
            this.CustomersPanel2.Location = new System.Drawing.Point(0, 313);
            this.CustomersPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersPanel2.Name = "CustomersPanel2";
            this.CustomersPanel2.Size = new System.Drawing.Size(721, 300);
            this.CustomersPanel2.TabIndex = 10;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(3, 202);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(88, 21);
            this.IsPriorityCheckBox.TabIndex = 0;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.72794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.27206F));
            this.tableLayoutPanel1.Controls.Add(this.IdCustomerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdCustomerTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddressControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FullNameTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 274);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // IdCustomerLabel
            // 
            this.IdCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdCustomerLabel.AutoSize = true;
            this.IdCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdCustomerLabel.Location = new System.Drawing.Point(3, 14);
            this.IdCustomerLabel.Name = "IdCustomerLabel";
            this.IdCustomerLabel.Size = new System.Drawing.Size(23, 17);
            this.IdCustomerLabel.TabIndex = 5;
            this.IdCustomerLabel.Text = "Id:";
            this.IdCustomerLabel.Click += new System.EventHandler(this.IdCustomerLabel_Click);
            // 
            // IdCustomerTextBox
            // 
            this.IdCustomerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdCustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdCustomerTextBox.Location = new System.Drawing.Point(124, 11);
            this.IdCustomerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdCustomerTextBox.Name = "IdCustomerTextBox";
            this.IdCustomerTextBox.ReadOnly = true;
            this.IdCustomerTextBox.Size = new System.Drawing.Size(143, 22);
            this.IdCustomerTextBox.TabIndex = 9;
            this.IdCustomerTextBox.TextChanged += new System.EventHandler(this.IdCustomerTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(3, 59);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.FullNameLabel.TabIndex = 7;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Location = new System.Drawing.Point(124, 56);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(591, 22);
            this.FullNameTextBox.TabIndex = 10;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 4);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(138, 16);
            this.SelectedCustomerLabel.TabIndex = 4;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(235, 549);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(110, 69);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40499F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16921F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.IsPriorityCheckBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.DiscountsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DiscountsListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddDiscountButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.RemoveDiscountButton, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(721, 300);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(3, 6);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(75, 16);
            this.DiscountsLabel.TabIndex = 0;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 16;
            this.DiscountsListBox.Location = new System.Drawing.Point(3, 31);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.tableLayoutPanel2.SetRowSpan(this.DiscountsListBox, 2);
            this.DiscountsListBox.Size = new System.Drawing.Size(343, 165);
            this.DiscountsListBox.TabIndex = 1;
            this.DiscountsListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsListBox_SelectedIndexChanged);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiscountButton.Location = new System.Drawing.Point(352, 30);
            this.AddDiscountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(125, 51);
            this.AddDiscountButton.TabIndex = 7;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveDiscountButton.Location = new System.Drawing.Point(352, 116);
            this.RemoveDiscountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(125, 51);
            this.RemoveDiscountButton.TabIndex = 8;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddressControl
            // 
            address3.Apartment = "";
            address3.Building = "";
            address3.City = "";
            address3.Country = "";
            address3.Index = 100000;
            address3.Street = "";
            this.AddressControl.Address = address3;
            this.tableLayoutPanel1.SetColumnSpan(this.AddressControl, 2);
            this.AddressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControl.Location = new System.Drawing.Point(5, 95);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(5);
            this.AddressControl.Name = "AddressControl";
            this.tableLayoutPanel1.SetRowSpan(this.AddressControl, 2);
            this.AddressControl.Size = new System.Drawing.Size(715, 174);
            this.AddressControl.TabIndex = 11;
            this.AddressControl.Load += new System.EventHandler(this.AddressControl_Load);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1072, 620);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersTableLayoutPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.CustomersPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CustomersTableLayoutPanel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IdCustomerLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdCustomerTextBox;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Panel CustomersPanel2;
        private System.Windows.Forms.Button GenerateButton;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button RemoveDiscountButton;
    }
}
