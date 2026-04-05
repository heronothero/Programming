using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        private MainVM _vm;
        private ContactSerializer _serializer;

        public SaveCommand(MainVM vm, ContactSerializer serializer)
        {
            _vm = vm;
            _serializer = serializer;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _serializer.Save(_vm.Contacts.ToList());
        }

        public event EventHandler CanExecuteChanged;
    }
}
