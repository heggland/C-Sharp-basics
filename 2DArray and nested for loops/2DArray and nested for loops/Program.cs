using System;

namespace _2DArray_and_nested_for_loops
{
    class Program
    {

        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {
            // foreach loop
            Console.WriteLine("This is our 2D array printed using foreach loop:\n");
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\n\nThis is our 2D array printed using nesten for loop:\n");
            // nested for loop
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++) // go through colums
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++) // go through rows
                {
                    // matrix[i, j] = 0; // change go brrrr

                   /* 
                    if (matrix[i, j] % 2 != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    } else
                    {
                        Console.WriteLine(" ");
                    }
                   */

                    if (i == j)
                    {
                        //matrix[i, j] = 1;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                 

                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n");

            //for loop print only 1, 5, 9. 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, i]);
            }

            Console.WriteLine("\n\n");

            // print 3, 5, 7
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == 0 && j == 2 || i == 1 &&  j == 1 || i == 2 &&  j == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]);
            }


            Console.ReadKey();
        }


    }
}
