using System;
using System.Windows.Threading;
// Presenter

namespace MVP
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;
        DispatcherTimer dispatcherTimer;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            this.view.ButtonClicked += new EventHandler<ActionEventArgs>(mainWindow_Event);          
        }

        void mainWindow_Event(object sender, ActionEventArgs e)
        {
            switch (e.Action) {
                case TimerAction.Start:
                    UpdateValue();
                    dispatcherTimer.Start();
                    break;
                case TimerAction.Stop:
                    dispatcherTimer.Stop();
                    break;
                case TimerAction.Reset:
                    model.Reset();
                    dispatcherTimer.Stop();
                    UpdateValue();
                    break;
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            model.Inc();
            UpdateValue();
        }

        private void UpdateValue()
        {
            this.view.textBox1.Text = model.Value.ToString();
        }

    }
}
