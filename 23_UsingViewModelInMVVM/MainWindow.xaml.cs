
using _23_UsingViewModelInMVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace _23_UsingViewModelInMVVM
{

    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty TextProperty =
    DependencyProperty.Register("Text", typeof(string), typeof(MyControl));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}