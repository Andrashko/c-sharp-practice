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

        public double FirstNumber
        { 
            get { return double.Parse(number1.Text); }
        }

        public double SecondNumber
        {
            get { return double.Parse(number2.Text); }
        }

        public event EventHandler AddClicked;

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (AddClicked != null)
                AddClicked(this, EventArgs.Empty);
        }


        public event EventHandler SubClicked;
        private void subButton_Click(object sender, RoutedEventArgs e)
        {
            if (SubClicked != null)
                SubClicked(this, EventArgs.Empty);
        }


        public event EventHandler MultClicked;
        private void multButton_Click(object sender, RoutedEventArgs e)
       {
            if (MultClicked != null)
                MultClicked(this, EventArgs.Empty);
        }

        public event EventHandler RemoveClicked;


        



    }
}
