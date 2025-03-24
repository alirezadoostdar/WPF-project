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
    /// Interaction logic for RouteEventExample.xaml
    /// </summary>
    public partial class RouteEventExample : Window
    {
        public RouteEventExample()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            MessageBox.Show("Window_KeyDown");
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            MessageBox.Show("Window_PreviewKeyDown");
        }

        private void Grid1_KeyDown(object sender, KeyEventArgs e)
        {
            Grid1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            MessageBox.Show("Grid1_KeyDown");
        }

        private void Grid1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Grid1.Background = new SolidColorBrush(Color.FromRgb(0, 200, 0));
            MessageBox.Show("Grid1_PreviewKeyDown");
        }

        private void stackPanel1_KeyDown(object sender, KeyEventArgs e)
        {
            stackPanel1.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            MessageBox.Show("stackPanel1_KeyDown");
        }

        private void stackPanel1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            stackPanel1.Background = new SolidColorBrush(Color.FromRgb(0, 0, 200));
            MessageBox.Show("stackPanel1_PreviewKeyDown");
        }

        private void stackPanel2_KeyDown(object sender, KeyEventArgs e)
        {
            stackPanel2.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            MessageBox.Show("stackPanel2_KeyDown");
        }

        private void stackPanel2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            stackPanel2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 0));
            MessageBox.Show("stackPanel2_PreviewKeyDown");
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            txtName.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
            MessageBox.Show("txtName_KeyDown");
        }

        private void txtName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            txtName.Background = new SolidColorBrush(Color.FromRgb(0, 200, 200));
            MessageBox.Show("txtName_PreviewKeyDown");
        }
    }
}
