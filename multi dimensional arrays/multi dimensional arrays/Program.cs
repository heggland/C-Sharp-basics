using System;

namespace multi_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9} // row 2
            };

            Console.WriteLine($"Central value is: {array2D[1, 0]}");


            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            Console.WriteLine(array2DString[1, 1]);

            Console.WriteLine("Change 2D entry four");
            string input = Console.ReadLine();

            array2DString[1, 1] = input;

            Console.WriteLine(array2DString[1, 1]);


            int dimensions = array2DString.Rank;
            Console.WriteLine($"Dimensions are: " + dimensions);

            // another way to declare multi array
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            // 3D array
            int[,,] threeD;

            // three dimensional array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "whats up"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "last entry"}
                }
            };

            Console.WriteLine($"The value is: {array3D[0, 2, 0]}");

        }
    }
}
