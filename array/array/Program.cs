using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //grades();
            //gradesOfMathStudentsA();
            nums();

            Console.ReadKey();
        }

        static void grades()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 30;
            grades[3] = 13;
            grades[4] = 5;

            Console.WriteLine($"Grades at index 0: {grades[0]}");

            Console.WriteLine("Change grade at index 0");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grades at index 0: {grades[0]}");

        }

        static void gradesOfMathStudentsA()
        {
            int[] grades = { 20, 13, 12, 8, 8 };

            Console.WriteLine($"Length of grades: {grades.Length}");

            int[] grades2 = new int[] { 15, 20, 43, 18, 23, 22, 11 };

            Console.WriteLine($"Length of grades2: {grades2.Length}");
        }

        static void nums()
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            Console.WriteLine(nums.Length);

            for (int j = 0; j < nums.Length; j++)
            {

                Console.WriteLine($"{nums[j]}");
            }

            int counter = 0;
            foreach (int item in nums)
            {
                counter++;
                Console.WriteLine($"foreach {counter}.. {item}");
            }

        }

    }
}
