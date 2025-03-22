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
    /// Interaction logic for Element2.xaml
    /// </summary>
    public partial class Element2 : Window
    {
        public Element2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = DateTime.Now.ToString();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox != null)
            {
                lblStatus.Content = $"char number:{textBox.SelectionStart}, ";
                lblStatus.Content += $"lenght:{textBox.SelectionLength}, ";
                lblStatus.Content += $"Selection:{textBox.SelectedText}, ";
            }
        }
    }
}
