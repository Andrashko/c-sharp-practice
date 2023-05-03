using System;
using System.Collections;

namespace InterIEnumerable
{
    // Клас UserCollection - колекція(набір) об'єктів класу Element.
    // Для застосування foreach, необхідно, щоб клас реалізовував інтерфейс - IEnumerable.
    public class UserCollection : IEnumerable, IEnumerator
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        // Покажчик поточної позиції елемента в масиві.
        int position = -1;

        // ------------------------------------------------------------------------------------------------------------------
        // Реалізація інтерфейсу IEnumerator.

        // Пересунути внутрішній покажчик (position) однією позицію.
        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        // Встановити вказівник (position) перед початком набору.
        public void Reset()
        {
            position = -1;
        }

        // Отримати поточний елемент набору. 
        public object Current
        {
            get { return elementsArray[position]; }
        }

        // -----------------------------------------------------------------------------------------------------------------
        // Реалізація інтерфейсу - IEnumerable.

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
