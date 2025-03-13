using _23_UsingViewModelInMVVM.Model;
using _23_UsingViewModelInMVVM.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _23_UsingViewModelInMVVM.ViewModel
{
    public class MainWindowViewModel :ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canExecute => selectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(),canExecute => CanSave());
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "laptop",
                SerialNumber = "1235",
                Quantity = 36
            });
            Items.Add(new Item
            {
                Name = "mobile",
                SerialNumber = "654784",
                Quantity = 55
            });
        }

        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "test",
                SerialNumber= "test",
                Quantity= 55
            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        private void Save()
        {
            //save to file or db
        }

        private bool CanSave()
        {
            return false;
        }
    }
}
