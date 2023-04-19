using System;
using System.Text;

// Події (abstract and virtual).

namespace Events
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent; // Абстрактна подія.
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;

        public virtual event EventDelegate MyEvent // Віртуальна подія.
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent // Перевизначена подія.
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine("До події базового класу був прикріплений обробник - {0}", value.Method.Name);
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("Від події базового класу було відкріплено оброблювач - {0}", value.Method.Name);
            }
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
            DerivedClass instance = new DerivedClass();

            // Приєднання обробників подій.
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
