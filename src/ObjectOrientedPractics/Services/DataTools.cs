using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет вспомогательные методы для работы со списками товаров (фильтрация и сортировка)
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список товаров по заданному условию
        /// </summary>
        /// <param name="items">Исходный список товаров</param>
        /// <param name="filter">Функция-фильрт</param>
        /// <returns>Результат фильтра списка товаров</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> filter)
        {
            List<Item> result = new List<Item>();

            foreach (var item in items)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// Сортирует список товаров с использованием переданной функции сортировки
        /// </summary>
        /// <param name="items">Текущий список товаов</param>
        /// <param name="sorter">Функция сортировки</param>
        /// <returns>Результат сортировки</returns>
        public static List<Item> Sort(List<Item> items, Func<List<Item>, List<Item>> sorter)
        {
            return sorter(items);
        }

        /// <summary>
        /// Сортирует товары по названию в алфавитном порядке
        /// </summary>
        public static List<Item> SortByName(List<Item> items)
        {
            return items.OrderBy(i => i.Name).ToList();
        }

        /// <summary>
        /// Сортирует товары по возрастанию стоимости
        /// </summary>
        public static List<Item> SortByCostAsc(List<Item> items)
        {
            return items.OrderBy(i => i.Cost).ToList();
        }

        /// <summary>
        /// Сортирует товары по уменьшению стоимости
        /// </summary>
        public static List<Item> SortByCostDesc(List<Item> items)
        {
            return items.OrderByDescending(i => i.Cost).ToList();
        }
    }
}
