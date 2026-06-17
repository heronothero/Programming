using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    public partial class MainVM : ObservableObject
    {
        private List<Contact> _allContacts;
        private ContactSerializer _serializer;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private Contact selectedContact;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private bool isEditing;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private bool isAdding;

        [ObservableProperty]
        private string searchText;

        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Загрузка основной логики (команд) и компонентов
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            _allContacts = _serializer.Load() ?? new List<Contact>();
            Contacts = new ObservableCollection<Contact>(_allContacts);
        }

        partial void OnSelectedContactChanged(Contact value)
        {
            ApplyCommand.NotifyCanExecuteChanged();
        }

        [RelayCommand] 
        private void Add() 
        { 
            var newContact = new Contact(); 
            _allContacts.Add(newContact); 
            SelectedContact = newContact; 
            IsAdding = true; 
            IsEditing = false; 
            FilterContacts(); 
        } 
        
        [RelayCommand(CanExecute = nameof(CanEdit))] 
        private void Edit() 
        { 
            IsEditing = true; 
            IsAdding = false; 
        } 
        
        private bool CanEdit() 
        {
            return SelectedContact != null && !IsAdding && !IsEditing;
        } 
        
        [RelayCommand(CanExecute = nameof(CanRemove))] 
        private void Remove() 
        { 
            if (SelectedContact == null) return; 
            _allContacts.Remove(SelectedContact); 
            SelectedContact = null; 
            FilterContacts(); 
            _serializer.Save(_allContacts); 
        } 
        
        private bool CanRemove() 
        {
            return SelectedContact != null && !IsAdding && !IsEditing;
        } 
        
        [RelayCommand(CanExecute = nameof(CanApply))] 
        private void Apply() 
        { 
            IsAdding = false; 
            IsEditing = false; 
            _serializer.Save(_allContacts); 
        } 
        
        private bool CanApply() 
        {
            if (SelectedContact == null)
                return false;

            if (!IsAdding && !IsEditing)
                return false;

            return string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Name"])
                && string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Phone"])
                && string.IsNullOrEmpty(((IDataErrorInfo)SelectedContact)["Email"]);
        } 
        
        partial void OnSearchTextChanged(string value) 
        { 
            FilterContacts(); 
        } 
        
        private void FilterContacts() 
        { 
            if (string.IsNullOrWhiteSpace(SearchText)) 
            { 
                Contacts = new ObservableCollection<Contact>(_allContacts); 
            } else 
            { 
                var filtered = _allContacts .Where(c => c.Name != null && c.Name.ToLower().Contains(SearchText.ToLower())) .ToList();
                Contacts = new ObservableCollection<Contact>(filtered);
            } 
            OnPropertyChanged(nameof(Contacts)); 
        }
    }
}
