using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a1");
            lvEntries.Items.Add("a2");
            lvEntries.Items.Add("a3");
            lvEntries.Items.Add("a4");
            lvEntries.Items.Add("a5");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure want to delete: {items.Count} Items?","Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach (var item in itemList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }
    }
}