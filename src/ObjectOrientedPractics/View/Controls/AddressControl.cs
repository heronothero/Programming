using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для отображения и редактирования адреса
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Событие вызывается при изменении данных в адресе покупателя
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Текущий адрес
        /// При получении свойства выполняется валидация всех полей
        /// </summary>
        public Address Address
        {
            get
            {
                PostIndexTextBox_TextChanged(null, null);
                CountryTextBox_TextChanged(null, null);
                CityTextBox_TextChanged(null, null);
                StreetTextBox_TextChanged(null, null);
                BuildingTextBox_TextChanged(null, null);
                ApartmentTextBox_TextChanged(null, null);

                return _address;
            }
            set
            {
                _address = value ?? new Address();
                UpdateUI();
            }
        }

        /// <summary>
        /// Конструктор. Инициализирует компоненты и подписывает обработчики событий на текстовые поля
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();

            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
        }

        /// <summary>
        /// Обновляет значения текстовых полей на форме согласно текущему адресу
        /// </summary>
        private void UpdateUI()
        {
            if (_address == null) return;

            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        /// <summary>
        /// Обрабатывает изменение почтового индекса. Подсвечивает поле при некорректном вводе и выводит подсказку
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = Color.White;
                _toolTip.SetToolTip(PostIndexTextBox, "");
            }
            catch (Exception ex)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                _toolTip.SetToolTip(PostIndexTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Обрабатывает изменение страны. Подсвечивает поле при ошибке
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения в городе. Подсвечивает поле при ошибке
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение улицы. Подсвечивает поле при ошибке
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения здания. Подсвечивает поле при ошибке
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения квартиры. Подсвечивает поле при ошибке
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        private void AdressTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
