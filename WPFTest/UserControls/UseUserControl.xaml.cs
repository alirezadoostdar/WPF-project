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

namespace WPFTest.UserControls
{
    /// <summary>
    /// Interaction logic for UseUserControl.xaml
    /// </summary>
    public partial class UseUserControl : Window
    {
        public UseUserControl()
        {
            InitializeComponent();
        }

        private void MyUcFileBrowse_FileNameChanged(object sender, EventArgs e)
        {
            lblShow.Content = MyUcFileBrowse.FileName;
        }
    }
}
