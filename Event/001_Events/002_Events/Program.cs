using System;
using System.Text;

// Події.

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        // Реалізація методів доступу add та remove для події.
        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    class Program
    {
        // Методи обробники події.

        static private void Handler1()
        {
            Console.WriteLine("Обробник події 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обробник події 2");
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyClass instance = new MyClass();

            // Подписка на событие.
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);

            // Метод, який викликає подію.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Відкріплюємо Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
