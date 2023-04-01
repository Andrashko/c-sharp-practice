using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_index
{
    /*
     *  Створити клас Store, який містить закритий масив елементів типу Article.
    Забезпечити такі можливості:
    • висновок інформації про товар за номером за допомогою індексу;
    • висновок на екран інформації про товар, назва якого введено з клавіатури, 
    якщо таких товарів немає, видати відповідне повідомлення.
     */
    internal class Store
    {
        private Article[] articles;
        public Store(string name) { 
            articles = new Article[]
            {
                new Article("Cola", name, 25.22),
                new Article("Beer", name, 50)
            };
        }

        public Article this[string articleName]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name.ToLower() == articleName.ToLower())
                        return articles[i];
                }
                return null;
            }

            set
            {
                //1 перевірити чи вже існує такий товар
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name.ToLower() == articleName.ToLower())
                    {
                        articles[i].Price = value.Price;
                        return;
                    }  
                }

                //якщо не знайшли, то потрыбно додати новий товар
                Array.Resize(ref articles, articles.Length+1);
                articles[articles.Length - 1] = value;
            }
        }
    }
}
