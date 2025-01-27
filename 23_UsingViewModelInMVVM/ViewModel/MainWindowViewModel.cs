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


    }
}
