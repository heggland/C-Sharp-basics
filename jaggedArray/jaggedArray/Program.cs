using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine($"The value in the middle of " +
                $"first entry is: {jaggedArray2[0][2]}");

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($"Element: {i}");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine($": {jaggedArray2[i][j]}");
                }
            }

            string[] joesFamily = new string[] { "Martha", "Robert" };

            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Frank", "Claudia"},
                new string[]{"Andrew", "Michelle"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[3][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
