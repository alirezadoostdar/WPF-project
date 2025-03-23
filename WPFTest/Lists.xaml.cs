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
    /// Interaction logic for Lists.xaml
    /// </summary>
    public partial class Lists : Window
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void btnCombo_Click(object sender, RoutedEventArgs e)
        {
            var win = new wComboBox();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
