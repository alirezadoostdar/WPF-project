﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;


namespace _8_DataBinding_INotifyPropertyChanged
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set
            { 
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null )
        {

        }
        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from button";
        }
    }
}