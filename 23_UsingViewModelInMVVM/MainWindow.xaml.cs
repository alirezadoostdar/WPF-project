
using _23_UsingViewModelInMVVM.ViewModel;
using System.Windows;

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