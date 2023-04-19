using System;

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
            this.view.addEvent += new EventHandler(mainWindow_addEvent);          
        }

        void mainWindow_addEvent(object sender, System.EventArgs e)
        {
            var data = this.view.textBox1.Text;

            var val = this.model.Add(double.Parse(data));

            this.view.textBox1.Text = val.ToString();
        }

       
    }
}
