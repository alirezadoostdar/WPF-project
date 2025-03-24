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
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        public Binding()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression width = txtWidth.GetBindingExpression(TextBox.TextProperty);
            BindingExpression height = txtHeight.GetBindingExpression(TextBox.TextProperty);
            width.UpdateSource();
            height.UpdateSource();
        }
    }
}
