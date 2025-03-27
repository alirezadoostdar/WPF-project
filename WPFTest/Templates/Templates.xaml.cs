using System.Windows;


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

        private void btnHierarchicalTemplate_Click(object sender, RoutedEventArgs e)
        {
            var win = new HierarchicalTemplate();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
