namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AdressTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.AdressTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdressTableLayoutPanel
            // 
            this.AdressTableLayoutPanel.AutoSize = true;
            this.AdressTableLayoutPanel.ColumnCount = 6;
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4486F));
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82243F));
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81308F));
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.28037F));
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.37383F));
            this.AdressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.AdressTableLayoutPanel.Controls.Add(this.PostIndexLabel, 0, 1);
            this.AdressTableLayoutPanel.Controls.Add(this.CountryLabel, 0, 2);
            this.AdressTableLayoutPanel.Controls.Add(this.StreetLabel, 0, 3);
            this.AdressTableLayoutPanel.Controls.Add(this.BuildingLabel, 0, 4);
            this.AdressTableLayoutPanel.Controls.Add(this.DeliveryAddressLabel, 0, 0);
            this.AdressTableLayoutPanel.Controls.Add(this.CountryTextBox, 1, 2);
            this.AdressTableLayoutPanel.Controls.Add(this.PostIndexTextBox, 1, 1);
            this.AdressTableLayoutPanel.Controls.Add(this.CityLabel, 3, 2);
            this.AdressTableLayoutPanel.Controls.Add(this.CityTextBox, 4, 2);
            this.AdressTableLayoutPanel.Controls.Add(this.StreetTextBox, 1, 3);
            this.AdressTableLayoutPanel.Controls.Add(this.BuildingTextBox, 1, 4);
            this.AdressTableLayoutPanel.Controls.Add(this.ApartmentLabel, 2, 4);
            this.AdressTableLayoutPanel.Controls.Add(this.ApartmentTextBox, 3, 4);
            this.AdressTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AdressTableLayoutPanel.Name = "AdressTableLayoutPanel";
            this.AdressTableLayoutPanel.RowCount = 5;
            this.AdressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AdressTableLayoutPanel.Size = new System.Drawing.Size(535, 193);
            this.AdressTableLayoutPanel.TabIndex = 0;
            this.AdressTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdressTableLayoutPanel_Paint);
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 49);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(72, 16);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(3, 87);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(55, 16);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetLabel.Location = new System.Drawing.Point(3, 124);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(50, 17);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingLabel.Location = new System.Drawing.Point(3, 164);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(62, 17);
            this.BuildingLabel.TabIndex = 5;
            this.BuildingLabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartmentLabel.Location = new System.Drawing.Point(204, 164);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(77, 17);
            this.ApartmentLabel.TabIndex = 6;
            this.ApartmentLabel.Text = "Apartment:";
            this.ApartmentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeliveryAddressLabel.AutoSize = true;
            this.AdressTableLayoutPanel.SetColumnSpan(this.DeliveryAddressLabel, 2);
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 11);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(130, 16);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTableLayoutPanel.SetColumnSpan(this.CountryTextBox, 2);
            this.CountryTextBox.Location = new System.Drawing.Point(91, 85);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(149, 20);
            this.CountryTextBox.TabIndex = 8;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PostIndexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTableLayoutPanel.SetColumnSpan(this.PostIndexTextBox, 2);
            this.PostIndexTextBox.Location = new System.Drawing.Point(91, 47);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(119, 20);
            this.PostIndexTextBox.TabIndex = 7;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(301, 86);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 17);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTableLayoutPanel.SetColumnSpan(this.CityTextBox, 2);
            this.CityTextBox.Location = new System.Drawing.Point(342, 85);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(190, 20);
            this.CityTextBox.TabIndex = 10;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StreetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTableLayoutPanel.SetColumnSpan(this.StreetTextBox, 5);
            this.StreetTextBox.Location = new System.Drawing.Point(91, 123);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(441, 20);
            this.StreetTextBox.TabIndex = 9;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BuildingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildingTextBox.Location = new System.Drawing.Point(91, 162);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(82, 20);
            this.BuildingTextBox.TabIndex = 11;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ApartmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTableLayoutPanel.SetColumnSpan(this.ApartmentTextBox, 2);
            this.ApartmentTextBox.Location = new System.Drawing.Point(287, 162);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(82, 20);
            this.ApartmentTextBox.TabIndex = 12;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdressTableLayoutPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(535, 193);
            this.Load += new System.EventHandler(this.AddressControl_Load);
            this.AdressTableLayoutPanel.ResumeLayout(false);
            this.AdressTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AdressTableLayoutPanel;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
    }
}
