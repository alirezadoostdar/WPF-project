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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for HandelingException.xaml
    /// </summary>
    public partial class HandelingException : Window
    {
        public HandelingException()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txtNumber1.Text);
            int b = Convert.ToInt32(txtNumber2.Text);
            int sum = a + b;
            txtSum.Text = sum.ToString();
        }
    }
}
