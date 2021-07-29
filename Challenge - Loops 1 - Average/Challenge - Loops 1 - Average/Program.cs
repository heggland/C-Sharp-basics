using System;

namespace Challenge___Loops_1___Average
{
    class Program
    {

        static string userInput;
        static int count = 1;
        static int number = 0;
        static int total = 0;


        static void Main(string[] args)
        {
            start();

            Console.Read();
        }

        static void start()
        {

            Console.WriteLine("Please enter a score");
            string x = Console.ReadLine();

            Console.WriteLine("Please enter score");

            while (x != "-1")
            {
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                userInput = Console.ReadLine();
                if (userInput.Equals("-1"))
                {
                    doAverage();
                    break;
                }
                if (int.TryParse(userInput, out number) && number >= 0 && number <= 20)
                {
                    total += number;
                }
                else
                {
                    if (!(userInput.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }
                count++;
            }
        }

        static void doAverage()
        {
            Console.Clear();
            Console.WriteLine($"Calculating average score out of {count} entries.");
            double average = (double)total / (double)count;
            Console.WriteLine(average);
        }
    }
}
