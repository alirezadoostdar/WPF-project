using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Element4.xaml
    /// </summary>
    public partial class Element4 : Window
    {
        public Element4()
        {
            InitializeComponent();
        }

        private void MainSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(lblSliderValue is not null)
                 lblSliderValue.Text = MainSlide.Value.ToString();
        }

        private void sRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)sRed.Value, (byte)sGreen.Value, (byte)sBlue.Value);
            panelColor.Fill = new SolidColorBrush(color);
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerAsync();

        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            pbValue.Value =e.ProgressPercentage;
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
