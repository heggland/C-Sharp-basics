using System;
using System.Linq;

namespace Functions_Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Calculator\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            try
            {
                startCalc();
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }

        }

        public static void startCalc()
        {

            Console.WriteLine(
                "\n[1] - Addition" +
                "\n[2] - Subtraction" +
                "\n[3] - Multiplication" +
                "\n[4] - Division" +
                "\n" +
                "\n[9] - Quit program" +
                "\n"
                );
            Console.Write("Select option: ");

            double result = 0;
            double option = 0;

            string symbolValue = Console.ReadLine();

            Console.WriteLine(symbolValue);

            if (symbolValue.All(char.IsDigit) && symbolValue != "")
            {
                option = Convert.ToDouble(symbolValue);
                Console.Clear();
            }



            switch (option)
            {
                case 1:
                    result = AddNumbers(getNum(false, "Plus", true), getNum(false, "", false));
                    break;
                case 2:
                    result = SubtractNumbers(getNum(false, "Minus", true), getNum(false, "", false));
                    break;
                case 3:
                    result = MultiplyNumbers(getNum(false, "Multiply by", true), getNum(false, "", false));
                    break;
                case 4:
                    result = DivideNumbers(getNum(false, "Divided by", true), getNum(false, "", false));
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    startCalc();
                    break;
            }

            if (!Double.IsInfinity(result))
            {
                Console.WriteLine($"\nSum: {result}");
            }
            else
            {
                if (option == 4)
                {
                    Console.WriteLine("Cant devide by 0");
                }
                else
                {
                    if (result >= 0)
                    {
                        Console.WriteLine("Result is to big");
                    }
                    else
                    {
                        Console.WriteLine("Result is to small");
                    }
                }
            }


            resetCalc();

        }

        public static void resetCalc()
        {
            Console.Write("\nCalculate new number? (yes/no)");

            char resetValue = Console.ReadLine()[0];

            if (resetValue == 'y')
            {
                Console.Clear();
                startCalc();
            }
            else if (resetValue == 'n')
            {
                Console.WriteLine("farwell..");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("invalid input");
                resetCalc();
            }
        }

        public static double getNum(bool retry, string mathSymbol, bool firstNumberString)
        {

            if (retry)
            {
                Console.Write(String.Concat("Only numbers!\n"));
            }

            if (firstNumberString)
            {
                Console.Write(String.Concat("Type 2 numbers to calculate\n\n"));
            }


            string number = Console.ReadLine();

            if (mathSymbol != "" && number.All(char.IsDigit))
            {
                Console.WriteLine(mathSymbol + " ");
            }

            if (number.All(char.IsDigit))
            {
                return Convert.ToDouble(number);
            }
            else
            {
                return getNum(true, mathSymbol, false);
            }

        }

        public static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
