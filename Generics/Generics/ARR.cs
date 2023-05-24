using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ARR<T>
    {
        private T[] items;

        public void add(T member) 
        { 
            if (items == null)
            {
                items = new T[] { member };
            }
            else
            {
                T[] temp = new T[items.Length + 1];
                for(int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                temp[temp.Length - 1] = member;
                items = temp;
            }
        }

        public void remove(int index)
        {
            if (index >= 0 || index < items.Length - 1)
            {
                return;
            }
            int post = 0;
            T[] temp = new T[post - 1];
            for (int i = 0; i < items.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }
                temp[post++] = items[i];
            }
        }

        public bool empty() => items == null || items.Length == 0;

        public int count() => items.Length;

        public void display()
        {
            Console.Write("[");
            for(int i=0; i< items.Length; i++) 
            {
                Console.Write($"{items[i]},"); 
            }
            Console.WriteLine("]");
        } 
    }
}
