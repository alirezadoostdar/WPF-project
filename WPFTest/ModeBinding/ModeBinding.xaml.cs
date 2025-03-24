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

namespace WPFTest.ModeBinding
{
    /// <summary>
    /// Interaction logic for ModeBinding.xaml
    /// </summary>
    public partial class ModeBinding : Window
    {
        public ModeBinding()
        {
            InitializeComponent();
            this.DataContext = new Person { Name="Alireza Doostdar",Age=38};
        }
    }
}
