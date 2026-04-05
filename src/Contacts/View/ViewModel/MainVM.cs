using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private bool _isEditing;
        private bool _isAdding;
        private List<Contact> _allContacts;
        private string _searchText;
        private ContactSerializer _serializer;

        public ObservableCollection<Contact> Contacts { get; set; }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged();

                ((RelayCommand)EditCommand)?.RaiseCanExecuteChanged();
                ((RelayCommand)RemoveCommand)?.RaiseCanExecuteChanged();
                ((RelayCommand)ApplyCommand)?.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Проверка на редактирование контактных данных
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set { _isEditing = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Проверка на добавление данных контакта
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set { _isAdding = value; OnPropertyChanged(); }
        }

        // Команды
        public ICommand ApplyCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        public SaveCommand SaveCommand { get; set; }
        public LoadCommand LoadCommand { get; set; }

        /// <summary>
        /// Загрузка основной логики (команд) и компонентов
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();

            _serializer = new ContactSerializer();

            _allContacts = _serializer.Load();

            if (_allContacts == null)
                _allContacts = new List<Contact>();

            Contacts = new ObservableCollection<Contact>(_allContacts);

            SaveCommand = new SaveCommand(this, _serializer);
            LoadCommand = new LoadCommand(this, _serializer);

            ApplyCommand = new RelayCommand(Apply);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit, CanEdit);
            RemoveCommand = new RelayCommand(Remove, CanRemove);
            ApplyCommand = new RelayCommand(Apply, CanApply);
        }

        private void Add(object obj)
        {
            var newContact = new Contact();

            _allContacts.Add(newContact);
            SelectedContact = newContact;

            FilterContacts();

            IsAdding = true;
            IsEditing = false;
        }

        private void Edit(object obj)
        {
            if (SelectedContact == null) return;

            IsEditing = true;
            IsAdding = false;
        }

        private void Apply(object obj)
        {
            if (IsAdding)
            {
                Contacts.Add(SelectedContact);
            }

            IsAdding = false;
            IsEditing = false;

            _serializer.Save(Contacts.ToList());
        }

        private void Remove(object obj)
        {
            if (SelectedContact == null) return;

            _allContacts.Remove(SelectedContact);

            SelectedContact = null;

            FilterContacts();
        }

        /// <summary>
        /// Проверка на возможность редактирования контакта
        /// </summary>
        private bool CanEdit(object obj)
        {
            Console.WriteLine(SelectedContact);
            return SelectedContact != null;
        }

        /// <summary>
        /// Проверка на возможность удаления контакта
        /// </summary>
        private bool CanRemove(object obj)
        {
            return SelectedContact != null;
        }

        /// <summary>
        /// Поиск контакта
        /// </summary>
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                FilterContacts();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private bool CanApply(object obj)
        {
            if (SelectedContact == null) return false;

            return string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Name"])
                && string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Phone"])
                && string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Email"]);
        }

        private void FilterContacts()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                Contacts = new ObservableCollection<Contact>(_allContacts);
            }
            else
            {
                var filtered = _allContacts
                    .Where(c => c.Name != null &&
                                c.Name.ToLower().Contains(SearchText.ToLower()))
                    .ToList();

                Contacts = new ObservableCollection<Contact>(filtered);
            }

            OnPropertyChanged(nameof(Contacts));
        }
    }
}
