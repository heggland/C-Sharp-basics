using System;

namespace arrayAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine(averageResult);

            challangeHappy();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }

        static void challangeHappy()
        {

            Console.WriteLine("Challange happy");

            int[] happiness = new int[] { 1, 2, 3, 4, 5, 6 };

            SunIsShining(happiness);

            static void SunIsShining(int[] x)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i] + 2);
                }

            }
        }
    }
}
