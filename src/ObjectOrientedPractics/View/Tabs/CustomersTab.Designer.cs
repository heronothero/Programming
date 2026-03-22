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
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.CustomersPanel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IdCustomerLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdCustomerTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.ColumnCount = 4;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersLabel, 0, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersListBox, 0, 1);
            this.CustomersTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 2);
            this.CustomersTableLayoutPanel.Controls.Add(this.AddButton, 0, 2);
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersPanel, 3, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 2);
            this.CustomersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 3;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.071429F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.92857F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(806, 620);
            this.CustomersTableLayoutPanel.TabIndex = 1;
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 6);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(100, 20);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersTableLayoutPanel.SetColumnSpan(this.CustomersListBox, 3);
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 36);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(354, 516);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(123, 558);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 59);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 558);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 59);
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
            this.CustomersPanel.Location = new System.Drawing.Point(363, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersTableLayoutPanel.SetRowSpan(this.CustomersPanel, 3);
            this.CustomersPanel.Size = new System.Drawing.Size(440, 614);
            this.CustomersPanel.TabIndex = 5;
            // 
            // CustomersPanel2
            // 
            this.CustomersPanel2.Location = new System.Drawing.Point(7, 236);
            this.CustomersPanel2.Name = "CustomersPanel2";
            this.CustomersPanel2.Size = new System.Drawing.Size(427, 375);
            this.CustomersPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.67442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.32558F));
            this.tableLayoutPanel1.Controls.Add(this.IdCustomerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdCustomerTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddressTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddressLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 197);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // IdCustomerLabel
            // 
            this.IdCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdCustomerLabel.AutoSize = true;
            this.IdCustomerLabel.Location = new System.Drawing.Point(3, 11);
            this.IdCustomerLabel.Name = "IdCustomerLabel";
            this.IdCustomerLabel.Size = new System.Drawing.Size(21, 16);
            this.IdCustomerLabel.TabIndex = 5;
            this.IdCustomerLabel.Text = "Id:";
            this.IdCustomerLabel.Click += new System.EventHandler(this.IdCustomerLabel_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 50);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(71, 16);
            this.FullNameLabel.TabIndex = 7;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdCustomerTextBox
            // 
            this.IdCustomerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdCustomerTextBox.Location = new System.Drawing.Point(122, 8);
            this.IdCustomerTextBox.Name = "IdCustomerTextBox";
            this.IdCustomerTextBox.ReadOnly = true;
            this.IdCustomerTextBox.Size = new System.Drawing.Size(142, 22);
            this.IdCustomerTextBox.TabIndex = 9;
            this.IdCustomerTextBox.TextChanged += new System.EventHandler(this.IdCustomerTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullNameTextBox.Location = new System.Drawing.Point(122, 47);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(305, 22);
            this.FullNameTextBox.TabIndex = 10;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressTextBox.Location = new System.Drawing.Point(122, 81);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.AddressTextBox, 2);
            this.AddressTextBox.Size = new System.Drawing.Size(305, 113);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(3, 89);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(61, 16);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(169, 20);
            this.SelectedCustomerLabel.TabIndex = 4;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Location = new System.Drawing.Point(243, 558);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(114, 59);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersTableLayoutPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(806, 620);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersTableLayoutPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Panel CustomersPanel2;
        private System.Windows.Forms.Button GenerateButton;
    }
}
