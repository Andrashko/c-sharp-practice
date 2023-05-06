using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using MyDictionary;

namespace CollectionTask3
{
    internal class Program
    {

        /*
         * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.

            Створіть колекцію MyDictionary <TKey, TValue>. 
            Реалізуйте в найпростішому наближенні можливість
            використання її примірника аналогічно примірнику 
            класу Dictionary <TKey, TValue>. Мінімально
            необхідний інтерфейс взаємодії з екземпляром, повинен включати 
            метод додавання елемента,   
            індексатор для отримання значення елемента за вказаною індексу 
            і властивість тільки для читання для отримання загальної кількості елементів. 
            Реалізуйте можливість перебору елементів колекції в циклі foreach.
         */
        static void Main(string[] args)
        {
            try
            {
                var dictionary = new MyDictionary<int, string>();
                dictionary.Add(1, "Bob");
                dictionary.Add(7, "Jack");
                dictionary.Add(3, "Nick");
                foreach (var name in dictionary)
                {
                    Console.WriteLine(name);
                }


                Console.WriteLine(dictionary.Count);
                Console.WriteLine(dictionary[7]);
                Console.WriteLine(dictionary[8]);

                var vocabulary = new MyDictionary<string, string>();
                vocabulary.Add("Milk", "молоко");
                vocabulary.Add("Bread", "Хліб");
                Console.WriteLine(vocabulary["Bread"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { Console.ReadLine(); }
        }
    }
}
