using System;
using System.Windows.Controls;

// Presenter

namespace MVP
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.AddClicked += addButton_Click;
            this.view.SubClicked += subButton_Click;
            this.view.MultClicked += multButton_Click;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var data = model.Add(view.FirstNumber + view.SecondNumber);
            this.view.resultButton.Text = data.ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            var data = model.Sub(view.FirstNumber - view.SecondNumber);
            this.view.resultButton.Text = data.ToString();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            var data = model.Mult(view.FirstNumber * view.SecondNumber);
            this.view.resultButton.Text = data.ToString();
        }

    }
}
