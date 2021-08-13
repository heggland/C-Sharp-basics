using System;
using System.Collections.Generic;

namespace IEnumerator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First example: ");
            One();

            Console.WriteLine("\nSecond example: ");
            Two();
        }

        static void Two()
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] nubmerArray = new int[] { 1, 7, 1, 3 };
            CollectionSum(nubmerArray);
        }


        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine($"Sum is {sum}");
        }


        static void One()
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This is a List<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            unknownCollection = GetCollection(2);
            Console.WriteLine("\nThis is a Que<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(" ");
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);


            return option switch
            {
                1 => numberList,
                2 => numbersQueue,
                _ => new int[] { 11, 12, 13, 14, 15 },
            };

        }
    }
}
