using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an arraylist with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            // declare a defined amount of objects.
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(20.3);
            myArrayList.Add(22);
            myArrayList.Add(285);
            myArrayList.Add(49.5);

            foreach (object item in myArrayList)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\n");

            // delete element with specific value from arraylist
            myArrayList.Remove(22);

            foreach (object item in myArrayList)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n");

            // delete element at specific position
            myArrayList.RemoveAt(0);

            foreach (object item in myArrayList)
            {
                Console.Write(item);
            }

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object item in myArrayList)
            {
                if (item is int)
                {
                    sum += Convert.ToDouble(item);
                }
                else if (item is double)
                {
                    sum += (double)item;
                }
                else if (item is string)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
