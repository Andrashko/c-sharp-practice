using System;
using System.Collections.Generic;
using System.Linq;

namespace Template
{
    /*
     * Завдання 3 

        Створіть проект Console Application, 
        де реалізуйте типізований клас "Чарівний мішок". 
        Чарівність полягає в тому, що подарунок сам з'являється
        у мішку та залежить від того, хто намагається відкрити мішок. 
        Причому подарунок для однієї істоти може з'явитись 
        лише 1 раз на день. Використовуйте обмеження типу 
        - інтерфейс із властивістю, що зберігає тип істоти, 
        яка намагається отримати подарунок із мішка.
     */
    /*
     * реалізуйте типізований клас "Чарівний мішок". 
     */
    public enum Creatures
    {
        Humen,
        Monkey
    }
    interface CreatureType
    {
        Creatures Type { get; }
    }

    public class Humen: CreatureType
    {
        public Creatures Type
        {
            get { return Creatures.Humen; }
        }

    }

    public class Monkey : CreatureType
    {
        public Creatures Type
        {
            get { return Creatures.Monkey; }
        }
    }
    class MagicBag 
    {
        private List<Creatures> hasOpened = new List<Creatures>();
       /*
        public string Open()
        {

            if (typeof(T) == typeof(Humen)) 
            {
                if (hasOpened.Contains(Creatures.Humen))
                    return "Людина вже сьогодні відкривала";
                hasOpened.Add(Creatures.Humen);
                return "Грошi";
            }

            if (typeof(T) == typeof(Monkey))
            {
                if (hasOpened.Contains(Creatures.Monkey))
                    return "Мавпа вже сьогодні відкривала";
                hasOpened.Add(Creatures.Monkey);
                return "Банан";
            }
            return "Невыдоми тип істоти";
        }
       */

        public string Open<T>(T creature) where T : CreatureType
        {
            if (hasOpened.Contains(creature.Type))
                return $"{creature.Type} вже сьогодні відкривала";
            hasOpened.Add(creature.Type);
            if (creature.Type == Creatures.Monkey)
                return "Банан";
            if (creature.Type == Creatures.Humen)
                return "Гроші";
            return "Невідомий тип істоти";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MagicBag<Humen> magicBag = new MagicBag<Humen>();
            Console.WriteLine(magicBag.Open());
            Console.WriteLine(magicBag.Open());
            Console.WriteLine(magicBag.Open());
            MagicBag<Monkey> magicBag2 = new MagicBag<Monkey>();
            Console.WriteLine(magicBag2.Open());
            Console.WriteLine(magicBag2.Open());
            Console.WriteLine(magicBag2.Open());
            Console.WriteLine(magicBag.Open());
            */

            MagicBag magicBag1 = new MagicBag();
            Console.WriteLine(magicBag1.Open(new Monkey()));
            Console.WriteLine(magicBag1.Open(new Monkey()));
            Console.WriteLine(magicBag1.Open(new Humen()));
            Console.WriteLine(magicBag1.Open(new Humen()));
            MagicBag magicBag2 = new MagicBag();
            Console.WriteLine(magicBag2.Open(new Monkey()));
            Console.WriteLine(magicBag2.Open(new Monkey()));
            Console.WriteLine(magicBag2.Open(new Humen()));
            Console.WriteLine(magicBag2.Open(new Humen()));
            Console.ReadLine();
        }
    }
}
