using System;
using System.Collections.Generic;
using arLib2;

namespace arQueue_try2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            ArrayQueue<string> arr = new ArrayQueue<string>(count);
            string s = "cfvfd";
            for (int i = 0; i < count; i++)
            {
                arr.Enqueue("элемент" + i);
            }
            IEnumerator<string> el1 = arr.GetEnumerator();
            arr.Enqueue(s);
            arr.Enqueue(s);
            arr.Enqueue(s);
            arr.Enqueue(s);
            foreach (string el in arr)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("//--//--//");
            Console.WriteLine();
       
            Console.WriteLine(arr.Dequeue());
           // Console.WriteLine(arr.Peek());
            // arr.Clear();
            Console.ReadLine();
        }
    }
}
