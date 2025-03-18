using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductManafement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Visible;
            EmployeePanel.Visibility = Visibility.Collapsed;
            CustomerPanel.Visibility = Visibility.Collapsed;
            ProductPanel.Visibility = Visibility.Collapsed;
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            EmployeePanel.Visibility = Visibility.Visible;
            CustomerPanel.Visibility = Visibility.Collapsed;
            ProductPanel.Visibility = Visibility.Collapsed;
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            EmployeePanel.Visibility = Visibility.Collapsed;
            CustomerPanel.Visibility = Visibility.Visible;
            ProductPanel.Visibility = Visibility.Collapsed;
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            EmployeePanel.Visibility = Visibility.Collapsed;
            CustomerPanel.Visibility = Visibility.Collapsed;
            ProductPanel.Visibility = Visibility.Visible;
        }
    }
}