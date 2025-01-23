using WinForms = System.Windows.Forms;
using System.Windows;


namespace _11_FolderBrowserDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog folderBrowser = new WinForms.FolderBrowserDialog();
            folderBrowser.ShowDialog();
            WinForms.DialogResult result = folderBrowser.ShowDialog();

            if (result ==WinForms.DialogResult.OK)
            {
                string folder = folderBrowser.SelectedPath;
            }
        }
    }
}