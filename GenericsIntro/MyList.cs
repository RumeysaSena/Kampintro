using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> // T-tip-type 
    {
        T[] items; //constructor
        public MyList()
        {
                items = new T[0];
        }
        public void Add(T item)    //item-eleman , yerine başka bir şey yazsanda olur.
        {
            T[] tempArray = items; // geçici dizinin referansı itemsın referansı
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        } 
    }
}
