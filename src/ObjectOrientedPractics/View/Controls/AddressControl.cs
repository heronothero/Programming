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
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Статические пооля
        /// </summary>
        private Address _address = new Address();
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Объявление события для изменения дангнных
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Триггер валидации всех полей
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
        /// Инициализация компонентов
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
        /// Обновление UI
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
        /// Обрабатывает загрузку элемента
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает различные изменения с панелью-таблицей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdressTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает событие клика на заголовок
        /// </summary>
        /// <param name="sender">Источник событий</param>
        /// <param name="e">Данные события</param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменения в текстовом поле почтового индекса
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// Обрабатывает изменения в текстовом поле страны
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// Обрабатывает изменения в текстовом поле улицы
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// Обрабатывает изменения в текстовом поле здания
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// Обрабатывает изменения в текстовом поле квартиры
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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

        /// <summary>
        /// Обрабатывает изменения в текстовом поле города
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
    }
}
