using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using System.IO;

namespace ObjectOrientedPractics.Services
{
    internal static class ProjectSerializer
    {
        /// <summary>
        /// Обрабатывает функцию сохранения данных
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="items">Данные</param>
        public static void Save(string path, List<Item> items)
        {
            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Выгрузка данных из файла
        /// </summary>
        /// <param name="path">Путь к файул</param>
        /// <returns>Возвращает данные, сохраненные в файле</returns>
        public static List<Item> Load(string path)
        {
            if (!File.Exists(path))
                return new List<Item>();

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Item>>(json);
        }
    }
}
