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

namespace WPFTest.Templates
{
    /// <summary>
    /// Interaction logic for Templates.xaml
    /// </summary>
    public partial class Templates : Window
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void btnControlTemplate_Click(object sender, RoutedEventArgs e)
        {
            var win = new ControlTemplate();
            win.Owner = this;
            win.ShowDialog();
        }

        private void btnDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            var win  = new DataTemplate();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
