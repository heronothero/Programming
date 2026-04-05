using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        public string FilePath { get; set; }

        /// <summary>
        /// Создание файла для работы с данными контактов
        /// </summary>
        public ContactSerializer()
        {
            FilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Contacts",
                "contacts.json"
            );
        }

        /// <summary>
        /// Сохранение данных контакта
        /// </summary>
        public void Save(Contact contact)
        {
            var dir = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var json = JsonConvert.SerializeObject(contact, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Возвращает предыдущий сохраненный контакт (после предыдущего запуска)
        /// </summary>
        public Contact Load()
        {
            if (!File.Exists(FilePath))
                return new Contact();

            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<Contact>(json);
        }
    }
}
