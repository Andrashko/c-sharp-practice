using System;
using System.Text;

// Події.

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
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

            // Приєднання обробників подій.
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);
            instance.MyEvent += delegate { Console.WriteLine("Анонімний метод 1."); };

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Відкріплюємо Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);

            // Неможливо відкріпити раніше приєднаний анонімний метод.
            instance.MyEvent -= delegate { Console.WriteLine("Анонімний метод 1."); };

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
