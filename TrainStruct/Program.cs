using System;
using static System.Net.Mime.MediaTypeNames;

namespace TrainStruct

{
    /*    
     *    Використовуючи Visual Studio, створіть проект за шаблоном 
     *    Console Application.
     *    Потрібно: Описати структуру з ім'ям Train, 
     *    що містить такі поля: назву пункту призначення, номер поїзда, 
     *    час відправлення. */
    struct Train
    {
        public string Distanition;
        public int NumberOfTrain;
        public DateTime Time;
    }
    /*
     *    Написати програму,  яка виконує такі дії: 
     *    введення з клавіатури даних до масиву,
     *    що складається з восьми елементів типу Train 
     *    (записи мають бути впорядковані за номерами поїздів); 
     *    виведення на екран інформації про поїзд, 
     *    номер якого введено з клавіатури
     *    (якщо таких поїздів немає, вивести відповідне повідомлення).
     */


    internal class Program
    {
        static void Find(Train[] trains, int number)
        {

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].NumberOfTrain == number)
                {
                    Console.WriteLine($"{trains[i].NumberOfTrain} | {trains[i].Distanition}");
                    return;
                }
            }
            Console.WriteLine($"Не знайдено потяг з номером {number}");
        }
        static void Print(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"{trains[i].NumberOfTrain} | {trains[i].Distanition}");
            }
        }
        static Train[] Input()
        {
            int count = 3;
            Train[] trains = new Train[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введіть номер потяга:");
                int numberOfTrain = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть пункт призначення потяга:");
                string distanation = Console.ReadLine();
                Console.WriteLine("Введіть час відправлення потяга:");
                DateTime time = Convert.ToDateTime(Console.ReadLine());
                /* trains[i] = new Train()
                 {
                     NumberOfTrain = numberOfTrain,
                     Distanition = distanation,
                     Time = time
                 };*/
                trains[i].NumberOfTrain = numberOfTrain;
                trains[i].Time = time;
                trains[i].Distanition = distanation;
            }
            return trains;
        }
        static void Main(string[] args)
        {
            Train[] trains = Input();

            Array.Sort(trains,
            (Train t1, Train t2) =>
            {
                return t1.NumberOfTrain - t2.NumberOfTrain;
                /*
                if (t1.NumberOfTrain == t2.NumberOfTrain)
                    return 0;
                if (t1.NumberOfTrain > t2.NumberOfTrain)
                    return 1;
                return -1;*/
            });

            Print(trains);

            Find(trains, 1);
            Find(trains, -1);
            Console.ReadLine();
        }
    }
}