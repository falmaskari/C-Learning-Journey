using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ARR<int> arr = new ARR<int>();
            arr.add(1);
            arr.add(2);
            arr.add(3);
            arr.add(4);
            arr.add(5);
            arr.remove(0);
           arr.display(); 

        }
    }
}