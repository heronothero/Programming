using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private MainVM _vm;
        private ContactSerializer _serializer;

        public LoadCommand(MainVM vm, ContactSerializer serializer)
        {
            _vm = vm;
            _serializer = serializer;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var contact = _serializer.Load();

            _vm.Name = contact.Name;
            _vm.PhoneNumber = contact.Phone;
            _vm.Email = contact.Email;
        }

        public event EventHandler CanExecuteChanged;
    }
}
