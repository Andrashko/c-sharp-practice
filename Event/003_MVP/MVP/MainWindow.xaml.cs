using System;
using System.Windows;

// View

namespace MVP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler myEvent = null;
        public event EventHandler addEvent = null;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            addEvent.Invoke(sender, e);
        }
    }
}
