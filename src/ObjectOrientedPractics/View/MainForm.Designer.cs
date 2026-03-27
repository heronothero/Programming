namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.OrderTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrderTabPage = new System.Windows.Forms.TabPage();
            this.TestTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.testTab1 = new ObjectOrientedPractics.View.Tabs.TestTab();
            this.tabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrderTabPage.SuspendLayout();
            this.PriorityOrderTabPage.SuspendLayout();
            this.TestTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ItemsTabPage);
            this.tabControl.Controls.Add(this.CustomersTabPage);
            this.tabControl.Controls.Add(this.CartsTabPage);
            this.tabControl.Controls.Add(this.OrderTabPage);
            this.tabControl.Controls.Add(this.PriorityOrderTabPage);
            this.tabControl.Controls.Add(this.TestTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1088, 661);
            this.tabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.itemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsTabPage.Size = new System.Drawing.Size(1080, 632);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.customersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomersTabPage.Size = new System.Drawing.Size(1080, 632);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.cartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CartsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Size = new System.Drawing.Size(1080, 632);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Cart";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // OrderTabPage
            // 
            this.OrderTabPage.Controls.Add(this.ordersTab);
            this.OrderTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrderTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderTabPage.Name = "OrderTabPage";
            this.OrderTabPage.Size = new System.Drawing.Size(1080, 632);
            this.OrderTabPage.TabIndex = 3;
            this.OrderTabPage.Text = "Orders";
            this.OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrderTabPage
            // 
            this.PriorityOrderTabPage.Controls.Add(this.priorityOrdersTab1);
            this.PriorityOrderTabPage.Location = new System.Drawing.Point(4, 25);
            this.PriorityOrderTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriorityOrderTabPage.Name = "PriorityOrderTabPage";
            this.PriorityOrderTabPage.Size = new System.Drawing.Size(1080, 632);
            this.PriorityOrderTabPage.TabIndex = 4;
            this.PriorityOrderTabPage.Text = "Priority Order";
            this.PriorityOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // TestTabPage
            // 
            this.TestTabPage.Controls.Add(this.testTab1);
            this.TestTabPage.Location = new System.Drawing.Point(4, 25);
            this.TestTabPage.Name = "TestTabPage";
            this.TestTabPage.Size = new System.Drawing.Size(1080, 632);
            this.TestTabPage.TabIndex = 5;
            this.TestTabPage.Text = "Test";
            this.TestTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsTab.Location = new System.Drawing.Point(4, 4);
            this.itemsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(1069, 618);
            this.itemsTab.TabIndex = 0;
            // 
            // customersTab
            // 
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(4, 4);
            this.customersTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(1072, 624);
            this.customersTab.TabIndex = 0;
            // 
            // cartsTab
            // 
            this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab.Location = new System.Drawing.Point(0, 0);
            this.cartsTab.Margin = new System.Windows.Forms.Padding(5);
            this.cartsTab.Name = "cartsTab";
            this.cartsTab.Size = new System.Drawing.Size(1080, 632);
            this.cartsTab.TabIndex = 0;
            // 
            // ordersTab
            // 
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(0, 0);
            this.ordersTab.Margin = new System.Windows.Forms.Padding(5);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(1080, 632);
            this.ordersTab.TabIndex = 0;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Location = new System.Drawing.Point(4, 4);
            this.priorityOrdersTab1.Margin = new System.Windows.Forms.Padding(5);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(656, 622);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // testTab1
            // 
            this.testTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testTab1.Location = new System.Drawing.Point(0, 0);
            this.testTab1.Name = "testTab1";
            this.testTab1.Size = new System.Drawing.Size(1080, 632);
            this.testTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 661);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrderTabPage.ResumeLayout(false);
            this.PriorityOrderTabPage.ResumeLayout(false);
            this.TestTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTab itemsTab;
        private View.Tabs.CustomersTab customersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private View.Tabs.CartsTab cartsTab;
        private System.Windows.Forms.TabPage OrderTabPage;
        private View.Tabs.OrdersTab ordersTab;
        private System.Windows.Forms.TabPage PriorityOrderTabPage;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
        private System.Windows.Forms.TabPage TestTabPage;
        private View.Tabs.TestTab testTab1;
    }
}

