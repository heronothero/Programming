using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class TestTab : UserControl
    {
        public TestTab()
        {
            InitializeComponent();
        }

        private void Log(string text)
        {
            TestOutputListBox.Items.Add(text);
        }

        private void ClearLog(string title)
        {
            TestOutputListBox.Items.Add("");
            TestOutputListBox.Items.Add($"=== {title} ===");
        }

        private void CloneTestButton_Click(object sender, EventArgs e)
        {
            TestOutputListBox.Items.Clear();
            ClearLog("CLONE TEST");

            var item = new Item("Phone", "Test item", 1000m, Category.Ноутбуки);
            var itemClone = (Item)item.Clone();

            Log("Item:");
            Log($"ReferenceEquals: {ReferenceEquals(item, itemClone)}");
            Log($"Equals: {item.Equals(itemClone)}");
            Log($"Name: {item.Name} / {itemClone.Name}");
            Log($"Cost: {item.Cost} / {itemClone.Cost}");
            Log($"Category: {item.Category} / {itemClone.Category}");

            var address = new Address(123456, "Russia", "Tomsk", "Lenina", "10", "5");
            var addressClone = (Address)address.Clone();

            Log("");
            Log("Address:");
            Log($"ReferenceEquals: {ReferenceEquals(address, addressClone)}");
            Log($"Equals: {address.Equals(addressClone)}");
            Log($"Text: {address} / {addressClone}");

            var cart = new Cart();
            cart.Items.Add(new Item("Стилус", "Test book", 500m, Category.Аксессуары));
            cart.Items.Add(new Item("Планшет", "Test pen", 100m, Category.Планшеты));

            var cartClone = (Cart)cart.Clone();

            Log("");
            Log("Cart:");
            Log($"ReferenceEquals: {ReferenceEquals(cart, cartClone)}");
            Log($"Same Items list reference: {ReferenceEquals(cart.Items, cartClone.Items)}");
            Log($"Items count: {cart.Items.Count} / {cartClone.Items.Count}");
            Log($"Amount: {cart.Amount} / {cartClone.Amount}");
        }

        private void EqualsTestButton_Click(object sender, EventArgs e)
        {
            TestOutputListBox.Items.Clear();
            ClearLog("EQUALS TEST");

            var item1 = new Item("Смартфон 1488", "Test item", 1000m, Category.Смартфоны);
            var item2 = new Item("Ремешок для часов", "Test item", 1000m, Category.Ремешки);
            var item3 = new Item("Роутер 228", "Different item", 3000m, Category.Роутеры);

            Log("Item:");
            Log($"item1.Equals(item2): {item1.Equals(item2)}");
            Log($"item1.Equals(item3): {item1.Equals(item3)}");

            var address1 = new Address(123456, "Russia", "Tomsk", "Lenina", "10", "5");
            var address2 = new Address(123456, "Russia", "Tomsk", "Lenina", "10", "5");
            var address3 = new Address(654321, "Russia", "Moscow", "Tverskaya", "1", "2");

            Log("");
            Log("Address:");
            Log($"address1.Equals(address2): {address1.Equals(address2)}");
            Log($"address1.Equals(address3): {address1.Equals(address3)}");

            var order1 = new Order(
                new List<Item> { item1 },
                address1);

            var order2 = new Order(
                new List<Item> { item2 },
                address2);

            var order3 = new Order(
                new List<Item> { item3 },
                address3);

            Log("");
            Log("Order:");
            Log($"order1.Equals(order2): {order1.Equals(order2)}");
            Log($"order1.Equals(order3): {order1.Equals(order3)}");
        }

        private void CompareTestButton_Click(object sender, EventArgs e)
        {
            TestOutputListBox.Items.Clear();
            ClearLog("COMPARE TEST");

            var cheapItem = new Item("Смарт-часы", "Cheap item", 100m, Category.Часы);
            var expensiveItem = new Item("Роутер", "Expensive item", 3000m, Category.Роутеры);

            Log("Item:");
            Log($"cheapItem.CompareTo(expensiveItem): {cheapItem.CompareTo(expensiveItem)}");
            Log($"expensiveItem.CompareTo(cheapItem): {expensiveItem.CompareTo(cheapItem)}");

            var points1 = new PointsDiscount();
            var points2 = new PointsDiscount();

            points1.Update(new List<Item>
            {
                new Item("A", "", 1000m, Category.Ремешки)
            });

            points2.Update(new List<Item>
            {
                new Item("A", "", 5000m, Category.Смартфоны)
            });

            Log("");
            Log("PointsDiscount:");
            Log($"points1.CompareTo(points2): {points1.CompareTo(points2)}");
            Log($"points2.CompareTo(points1): {points2.CompareTo(points1)}");

            var percent1 = new PercentDiscount(Category.Планшеты);
            var percent2 = new PercentDiscount(Category.Смартфоны);

            percent1.Update(new List<Item>
            {
                new Item("A", "", 1000m, Category.Ремешки)
            });

            percent2.Update(new List<Item>
            {
                new Item("A", "", 4000m, Category.Ремешки)
            });

            Log("");
            Log("PercentDiscount:");
            Log($"percent1.CompareTo(percent2): {percent1.CompareTo(percent2)}");
            Log($"percent2.CompareTo(percent1): {percent2.CompareTo(percent1)}");
        }

        private void DiscountTestButton_Click(object sender, EventArgs e)
        {
            TestOutputListBox.Items.Clear();
            ClearLog("DISCOUNT TEST");

            var items = new List<Item>
            {
                new Item("Роутер яблоко", "", 1000m, Category.Роутеры),
                new Item("Ремень", "", 500m, Category.Аксессуары),
                new Item("Смарт-часы", "", 10000m, Category.Часы)
            };

            var points = new PointsDiscount();
            var percent = new PercentDiscount(Category.Смартфоны);

            Log("Before update:");
            Log(points.Info);
            Log(percent.Info);

            Log("");
            Log("Calculate:");
            Log($"Points Calculate: {points.Calculate(items)}");
            Log($"Percent Calculate: {percent.Calculate(items)}");

            Log("");
            Log("Apply:");
            Log($"Points Apply: {points.Apply(items)}");
            Log($"Percent Apply: {percent.Apply(items)}");

            Log("");
            Log("After Apply, before Update:");
            Log(points.Info);
            Log(percent.Info);

            points.Update(items);
            percent.Update(items);

            Log("");
            Log("After Update:");
            Log(points.Info);
            Log(percent.Info);

            Log("");
            Log("Calculate again:");
            Log($"Points Calculate: {points.Calculate(items)}");
            Log($"Percent Calculate: {percent.Calculate(items)}");
        }

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            TestOutputListBox.Items.Clear();
            ClearLog("ORDER TEST");

            var address = new Address(123456, "Russia", "Tomsk", "Lenina", "10", "5");

            var items = new List<Item>
            {
                new Item("Часы", "", 500m, Category.Часы),
                new Item("Телефон", "", 100m, Category.Смартфоны)
            };

            var order1 = new Order(items, address);
            var order2 = (Order)order1.Clone();

            Log("Order clone:");
            Log($"ReferenceEquals: {ReferenceEquals(order1, order2)}");
            Log($"Equals: {order1.Equals(order2)}");
            Log($"Amount: {order1.Amount} / {order2.Amount}");
            Log($"Total: {order1.Total} / {order2.Total}");
        }

        private void TestOutputListBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}