using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTest.ModeBinding
{
    /// <summary>
    /// Interaction logic for RespondingChange.xaml
    /// </summary>
    public partial class RespondingChange : Window
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();
        public RespondingChange()
        {
            InitializeComponent();
            people.Add(new Person() { Name = "Alireza doostdar", Age = 36 });
            people.Add(new Person() { Name = "Pegah Taraghi", Age = 30 });
            lbUser.ItemsSource = people;
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            people.Add(new Person() { Name = "new person", Age = 30 });
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem is not null)
            {
                var person = lbUser.SelectedItem as Person;
                person.Name = "edit user";
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lbUser.SelectedItem is not null) 
                people.Remove(lbUser.SelectedItem as Person);
        }
    }
}
