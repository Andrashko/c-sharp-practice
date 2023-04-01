using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_index
{
    /*
     *  Потрібно: Створити клас Article, що містить наступні закриті поля:
        • Назва товару;
        • назва магазину, в якому продається товар;
        • вартість товару в гривнях. 
     */
    internal class Article
    {
        private string name;
        private string store;
        private double price;

        public string Name{get; set;}
        public string Store { get; set; }
        public double Price { get; set;}

        public Article(string name, string store, double price)
        {
            Name = name;
            Store = store;
            Price = price;
        }

        public override string ToString()
        {
            return $"\tname:{Name}, \n\tprice: {Price},\n\tstor:{Store}";
        }
    }
}
