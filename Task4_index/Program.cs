using System;

namespace Task4_index
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     *
   
    • висновок на екран інформації про товар, назва якого введено з клавіатури,
    якщо таких товарів немає, видати відповідне повідомлення.
    Написати програму, виведення на екран інформацію про товар
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Dastor");
            store["cola"] = new Article("cola", "Dastor", 30);
            store["bread"] = new Article("bread", "Dastor", 42.49);

            Console.WriteLine("Введіть товар");
            string articleName = Console.ReadLine();
            Article article = store[articleName];
            if (article == null)
            {
                Console.WriteLine("Товар відсутній");
            }
            else
            {
                Console.WriteLine(article);
            }
            
            Console.ReadLine();
        }
    }
}
