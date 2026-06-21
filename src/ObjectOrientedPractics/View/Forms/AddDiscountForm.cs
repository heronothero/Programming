using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Форма для выбора категории скидки
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Выбранная пользователем категория
        /// </summary>
        public Category SelectedCategory { get; private set; }

        /// <summary>
        /// Инициализирует форму и заполняет список категорий
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = 0;

            OkButton.Click += OkButton_Click;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает нажатие кнопки OK (сохраняет выбранную категорию и закрывает форму с результатом ОК)
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Cancel (закрывает форму без сохранения изменений)
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
