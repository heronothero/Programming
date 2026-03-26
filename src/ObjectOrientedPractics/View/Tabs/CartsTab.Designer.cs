namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.AllItemsListBox = new System.Windows.Forms.ListBox();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.29851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27363F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.29851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78607F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.79602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ItemsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AmountLabel, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.SumLabel, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.AllItemsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomersComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CartLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CartListBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddToCartButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ClearCartButton, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.RemoveItemButton, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.CreateOrderButton, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.968254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.349206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.960318F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.50794F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.365079F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.738095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.81746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89683F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 2);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(45, 16);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(289, 28);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(79, 16);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customer:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(723, 262);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(78, 20);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount:";
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.SumLabel.Location = new System.Drawing.Point(682, 287);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(119, 31);
            this.SumLabel.TabIndex = 3;
            this.SumLabel.Text = "4999.90";
            this.SumLabel.Click += new System.EventHandler(this.SumLabel_Click);
            // 
            // AllItemsListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AllItemsListBox, 2);
            this.AllItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllItemsListBox.FormattingEnabled = true;
            this.AllItemsListBox.Location = new System.Drawing.Point(3, 23);
            this.AllItemsListBox.Name = "AllItemsListBox";
            this.tableLayoutPanel1.SetRowSpan(this.AllItemsListBox, 6);
            this.AllItemsListBox.Size = new System.Drawing.Size(280, 411);
            this.AllItemsListBox.TabIndex = 4;
            this.AllItemsListBox.SelectedIndexChanged += new System.EventHandler(this.AllItemsListBox_SelectedIndexChanged);
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.CustomersComboBox, 3);
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(412, 24);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(389, 21);
            this.CustomersComboBox.TabIndex = 5;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartLabel.Location = new System.Drawing.Point(289, 56);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(34, 16);
            this.CartLabel.TabIndex = 6;
            this.CartLabel.Text = "Cart:";
            // 
            // CartListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CartListBox, 4);
            this.CartListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(289, 80);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(512, 178);
            this.CartListBox.TabIndex = 7;
            this.CartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBox_SelectedIndexChanged);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToCartButton.Location = new System.Drawing.Point(3, 440);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(117, 61);
            this.AddToCartButton.TabIndex = 8;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearCartButton.Location = new System.Drawing.Point(679, 325);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(117, 61);
            this.ClearCartButton.TabIndex = 9;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveItemButton.Location = new System.Drawing.Point(555, 325);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(117, 61);
            this.RemoveItemButton.TabIndex = 10;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrderButton.Location = new System.Drawing.Point(289, 325);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(117, 61);
            this.CreateOrderButton.TabIndex = 11;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(804, 504);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.ListBox AllItemsListBox;
        private System.Windows.Forms.ComboBox CustomersComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button CreateOrderButton;
    }
}
