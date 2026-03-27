namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора
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
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FindLabel = new System.Windows.Forms.Label();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.OrderByComboBox = new System.Windows.Forms.ComboBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ItemsTableLayoutPanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 4;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsLabel, 0, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.AddButton, 0, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsPanel, 3, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 3;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.071429F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.92857F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(1076, 620);
            this.ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 6);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(55, 20);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(164, 557);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(155, 61);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 557);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 61);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsPanel.Controls.Add(this.tableLayoutPanel1);
            this.ItemsPanel.Controls.Add(this.SelectedItemLabel);
            this.ItemsPanel.Location = new System.Drawing.Point(486, 2);
            this.ItemsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsTableLayoutPanel.SetRowSpan(this.ItemsPanel, 3);
            this.ItemsPanel.Size = new System.Drawing.Size(587, 614);
            this.ItemsPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.37209F));
            this.tableLayoutPanel1.Controls.Add(this.CostTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CostLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.InfoLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.InfoTextBox, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 438);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CostTextBox.Location = new System.Drawing.Point(127, 53);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(143, 22);
            this.CostTextBox.TabIndex = 10;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 13);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 16);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "Id:";
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 56);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(37, 16);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdTextBox.Location = new System.Drawing.Point(127, 10);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(143, 22);
            this.IdTextBox.TabIndex = 9;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 142);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 99);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.CategoryLabel.TabIndex = 13;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(127, 95);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(143, 24);
            this.CategoryComboBox.TabIndex = 14;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.NameTextBox, 2);
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(3, 174);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(571, 83);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(3, 272);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(78, 16);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Description:";
            // 
            // InfoTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.InfoTextBox, 2);
            this.InfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTextBox.Location = new System.Drawing.Point(3, 304);
            this.InfoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(571, 132);
            this.InfoTextBox.TabIndex = 12;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 2);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(124, 20);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Location = new System.Drawing.Point(325, 557);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(155, 61);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // panel1
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 516);
            this.panel1.TabIndex = 7;
            // 
            // ItemsListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ItemsListBox, 2);
            this.ItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 27);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.tableLayoutPanel2.SetRowSpan(this.ItemsListBox, 2);
            this.ItemsListBox.Size = new System.Drawing.Size(471, 457);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.22851F));
            this.tableLayoutPanel2.Controls.Add(this.ItemsListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FindLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OrderByLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.OrderByComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.FindTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.03876F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.96124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.76744F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.620155F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 516);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FindLabel
            // 
            this.FindLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.FindLabel.Location = new System.Drawing.Point(3, 4);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(44, 17);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByLabel.Location = new System.Drawing.Point(5, 493);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(72, 16);
            this.OrderByLabel.TabIndex = 1;
            this.OrderByLabel.Text = "Order By:";
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderByComboBox.FormattingEnabled = true;
            this.OrderByComboBox.Location = new System.Drawing.Point(83, 489);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(391, 24);
            this.OrderByComboBox.TabIndex = 2;
            this.OrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTextBox.Location = new System.Drawing.Point(83, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(391, 22);
            this.FindTextBox.TabIndex = 3;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1079, 620);
            this.Load += new System.EventHandler(this.ItemsTab_Load);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox OrderByComboBox;
        private System.Windows.Forms.TextBox FindTextBox;
    }
}
