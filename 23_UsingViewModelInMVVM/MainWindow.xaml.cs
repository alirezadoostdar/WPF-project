
using _23_UsingViewModelInMVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace _23_UsingViewModelInMVVM
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}