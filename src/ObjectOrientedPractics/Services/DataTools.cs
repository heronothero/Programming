using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class DataTools
    {
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

        public static List<Item> Sort(List<Item> items, Func<List<Item>, List<Item>> sorter)
        {
            return sorter(items);
        }

        public static List<Item> SortByName(List<Item> items)
        {
            return items.OrderBy(i => i.Name).ToList();
        }

        public static List<Item> SortByCostAsc(List<Item> items)
        {
            return items.OrderBy(i => i.Cost).ToList();
        }

        public static List<Item> SortByCostDesc(List<Item> items)
        {
            return items.OrderByDescending(i => i.Cost).ToList();
        }
    }
}
