namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityPanel = new System.Windows.Forms.Panel();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.PriorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.452736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.1791F));
            this.tableLayoutPanel1.Controls.Add(this.OrdersLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrdersDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SelectedOrderLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreatedLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.IdTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreatedTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusComboBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.addressControl1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OrderItemsLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.OrderItemsListBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AmountLabel, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.SumLabel, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.DeliveryTimeLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeliveryTimeComboBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriorityPanel, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.960318F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.952381F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.09524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.563492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.547619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.29365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(3, 4);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(55, 16);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CreatedColumn,
            this.CustomerColumn,
            this.AddressColumn,
            this.AmountColumn,
            this.StatusColumn});
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 28);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.OrdersDataGridView, 10);
            this.OrdersDataGridView.Size = new System.Drawing.Size(362, 473);
            this.OrdersDataGridView.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 125;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.HeaderText = "Created At";
            this.CreatedColumn.MinimumWidth = 6;
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.Width = 125;
            // 
            // CustomerColumn
            // 
            this.CustomerColumn.HeaderText = "Customer";
            this.CustomerColumn.MinimumWidth = 6;
            this.CustomerColumn.Name = "CustomerColumn";
            this.CustomerColumn.Width = 125;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MinimumWidth = 6;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.Width = 125;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 125;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedOrderLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.SelectedOrderLabel, 2);
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(371, 4);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(115, 16);
            this.SelectedOrderLabel.TabIndex = 2;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(371, 30);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(23, 17);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "Id:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(371, 58);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(371, 86);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 17);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTextBox.Location = new System.Drawing.Point(446, 28);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(133, 23);
            this.IdTextBox.TabIndex = 6;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // CreatedTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CreatedTextBox, 2);
            this.CreatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedTextBox.Location = new System.Drawing.Point(446, 56);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(135, 23);
            this.CreatedTextBox.TabIndex = 7;
            this.CreatedTextBox.TextChanged += new System.EventHandler(this.CreatedTextBox_TextChanged);
            // 
            // StatusComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.StatusComboBox, 2);
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(446, 84);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(135, 24);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.addressControl1.Address = address1;
            this.addressControl1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.addressControl1, 4);
            this.addressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl1.Location = new System.Drawing.Point(371, 111);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(430, 150);
            this.addressControl1.TabIndex = 9;
            this.addressControl1.Load += new System.EventHandler(this.addressControl1_Load);
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderItemsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.OrderItemsLabel, 2);
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(371, 271);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(90, 16);
            this.OrderItemsLabel.TabIndex = 10;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.OrderItemsListBox, 4);
            this.OrderItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 16;
            this.OrderItemsListBox.Location = new System.Drawing.Point(371, 297);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.tableLayoutPanel1.SetRowSpan(this.OrderItemsListBox, 3);
            this.OrderItemsListBox.Size = new System.Drawing.Size(430, 104);
            this.OrderItemsListBox.TabIndex = 11;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.OrderItemsListBox_SelectedIndexChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(737, 412);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(64, 16);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(711, 437);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(90, 25);
            this.SumLabel.TabIndex = 13;
            this.SumLabel.Text = "4999.90";
            this.SumLabel.Click += new System.EventHandler(this.SumLabel_Click);
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(585, 30);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(98, 17);
            this.DeliveryTimeLabel.TabIndex = 14;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryTimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(692, 28);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(109, 24);
            this.DeliveryTimeComboBox.TabIndex = 15;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // PriorityPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PriorityPanel, 2);
            this.PriorityPanel.Controls.Add(this.IsPriorityCheckBox);
            this.PriorityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityPanel.Location = new System.Drawing.Point(371, 407);
            this.PriorityPanel.Name = "PriorityPanel";
            this.PriorityPanel.Size = new System.Drawing.Size(208, 27);
            this.PriorityPanel.TabIndex = 16;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(0, 3);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(78, 19);
            this.IsPriorityCheckBox.TabIndex = 0;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(804, 504);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.PriorityPanel.ResumeLayout(false);
            this.PriorityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Panel PriorityPanel;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
    }
}
