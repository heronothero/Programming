using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        /// <summary>
        /// Создание рандомайзера для товаров
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Массив наименований товаров
        /// </summary>
        private static string[] _names =
        {
            "Смартфон Apple iPhone 16 256GB Black (без RuStore)", 
            "Samsung Galaxy S22", 
            "Ноутбук ASUS",
            "Наушники Sony", 
            "Клавиатура Logitech",
            "Смартфон HUAWEI Pura70 Ultra 16/512GB зеленый",
            "Смартфон HUAWEI Mate 70 Pro 12/512GB Black",
            "Смартфон HUAWEI Pura 80 Ultra 16/512 черный",
            "Смартфон HUAWEI nova 14 12/256GB белый",
            "Смартфон HUAWEI nova Y63 6/128GB серебристый",
        };

        /// <summary>
        /// Массив описаний товаров
        /// </summary>
        private static string[] _descriptions =
        {
            "Отличный товар с высоким качеством.",
            "Популярная модель среди пользователей.",
            "Идеально подходит для работы и развлечений.",
            "Высокая производительность и надежность.",
            "Лучшее соотношение цены и качества.",
            "Смартфон Apple iPhone 16 nanoSim/eSim Black получил 6,1-дюймовый дисплей разрешением 1179x2556 пикселей, выполненный по технологии Super Retina XDR, которая отличается высочайшей точностью цветопередачи.",
            "Смартфон Huawei Pura 70 Ultra Green получил 6,8-дюймовый OLED LTPO-экран разрешением 2844х1260 пикселей, отображающим 1,07 млрд цветов. Частота обновления адаптивная в зависимости от контента и достигает 120 Гц, что позволяет с комфортом играть в современные игры.",
            "Huawei Mate 70 Pro 12/512GB Black — смартфон с искусственным интеллектом, который улучшает снимки, устраняет шумы при звонках и скрывает уведомления от посторонних.",
            "Смартфон Huawei Pura 80 Ultra, цвет черный выполнен в ультратонком глянцевом корпусе весом около 230 г, защищенном от воды и пыли по стандартам IP68/69. Его можно не прятать под снегом и дождем и применять для подводной съемки на глубине до 2 метров в течение 30 минут. Модель поддерживает работу до двух nano-Sim карт в сетях 2G, 3G, 4G LTE и 5G.",
            "Смартфон Huawei Nova 14 12/256GB White действует на базе операционной системы EMUI 14 и восьмиядерного процессора Huawei Kirin 8000 2,4 ГГц. Оперативная память 12 ГБ гарантирует быструю обработку приложений, бесперебойность в режиме многозадачности и комфортный запуск требовательных игр и программ. Внутренний накопитель объемом 256 ГБ позволяет хранить обширную коллекцию фото, видео, музыки и документов без необходимости постоянно освобождать место.",
        };

        /// <summary>
        /// Массив категорий
        /// </summary>
        private static Category[] _categories =
        {
            Category.Наушники,
            Category.Смартфоны,
            Category.Планшеты,
            Category.Часы,
            Category.Ноутбуки,
            Category.Роутеры,
            Category.Ремешки,
            Category.Аксессуары
        };

        /// <summary>
        /// Генерация случайных товаров с ценой
        /// </summary>
        /// <returns>Возвращает сгенерированный элемент</returns>
        public static Item CreateRandom()
        {
            return new Item(
                _names[_random.Next(_names.Length)],
                _descriptions[_random.Next(_descriptions.Length)],
                (decimal)_random.Next(1, 100000),
                _categories[_random.Next(_categories.Length)]
            );
        }
    }
}
