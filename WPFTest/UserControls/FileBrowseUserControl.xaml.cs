using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest.UserControls
{
    /// <summary>
    /// Interaction logic for FileBrowseUserControl.xaml
    /// </summary>
    public partial class FileBrowseUserControl : UserControl
    {
        public FileBrowseUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler<EventArgs> FileNameChanged;
        private void txtFileName_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
            if (FileNameChanged is not null)
                FileNameChanged(sender, e);
        }

        public string FileName
        {
            get { return txtFileName.Text; }
            set { txtFileName.Text = value; }
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
                FileName = dialog.FileName;
        }
    }
}
