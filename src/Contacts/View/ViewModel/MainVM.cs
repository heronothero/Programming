using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string _name;
        private string _phoneNumber;
        private string _email;

        public Contact Contact { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
                UpdateContact();
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
                UpdateContact();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
                UpdateContact();
            }
        }

        public SaveCommand SaveCommand { get; set; }
        public LoadCommand LoadCommand { get; set; }

        private ContactSerializer _serializer;

        public MainVM()
        {
            Contact = new Contact();
            _serializer = new ContactSerializer();

            SaveCommand = new SaveCommand(this, _serializer);
            LoadCommand = new LoadCommand(this, _serializer);
        }

        private void UpdateContact()
        {
            Contact.Name = Name;
            Contact.Phone = PhoneNumber;
            Contact.Email = Email;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
