using System;
using System.Collections.Generic;
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

namespace WPFTest.Validations
{
    /// <summary>
    /// Interaction logic for ValidationRule.xaml
    /// </summary>
    public partial class ValidationRule : Window
    {
        public ValidationRule()
        {
            InitializeComponent();
            DataContext = new Customer();
        }

        private void btnSvae_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("customer save");
        }
    }
}
