using System;
using System.Windows;

// View

namespace MVP
{
    public enum TimerAction
    {
        Start,
        Stop
    }
    public class ActionEventArgs: EventArgs
    {
        private TimerAction _action;

        public TimerAction Action { get { return _action; } }
        public ActionEventArgs(TimerAction action)
        {
            this._action = action;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }


        public event EventHandler<ActionEventArgs> ButtonClicked;
        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked.Invoke(this, new ActionEventArgs(TimerAction.Start));
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            ButtonClicked.Invoke(this, new ActionEventArgs(TimerAction.Stop));
        }
    }
}
