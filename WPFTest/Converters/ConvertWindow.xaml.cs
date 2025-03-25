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

namespace WPFTest.Converters
{
    /// <summary>
    /// Interaction logic for ConvertWindow.xaml
    /// </summary>
    public partial class ConvertWindow : Window
    {
        public ConvertWindow()
        {
            InitializeComponent();
            GrdUser.ItemsSource = new List<User>()
            {
                new User{Id = 1 , Name = "Alireza Doostdar" , Result = 100},
                new User{Id = 2 , Name = "pegah taraghi" , Result = 65},
                new User{Id = 3 , Name = "Elham Shafiei" , Result = 70},
                new User{Id = 4 , Name = "sara moradi" , Result = 45},
            };
  
        }
    }
}
