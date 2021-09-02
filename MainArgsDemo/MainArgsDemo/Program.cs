using System;

namespace MainArgsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // right click root, properties, debug, add a program argument
            // open program from bin/debug in cmd, add text after program to send in arguments to the program
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args, " +
                    "Please provide arguments next time" +
                    "type help if you want more options");
                Console.ReadKey();
                return;
            }

            if (args[0] == "help")
            {
                    Console.WriteLine("***************" +
                        "\nInstructions:" +
                        "\nuse one of the following commands followed by 2 numbers" +
                        "\n'add' : to add 2 nubmers" +
                        "\n'sub' to subtract 2 numbers" +
                        "\n ***************");
                return;
             }
             
            if (args.Length != 3)
             {
                    Console.WriteLine("invalid arguments, please use the help command for instructions");
                    Console.ReadKey();
                    return;
             }

             bool isNum1Parsed = float.TryParse(args[1], out float num1);
             bool isNum2Parsed = float.TryParse(args[2], out float num2);


             if (!isNum1Parsed || !isNum2Parsed)
             {
                    Console.WriteLine("invalid arguments, please use help command for instructions");
                    Console.ReadKey();
                    return;
             }

            float result;

            switch (args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The add sum of {num1} and {num2} is {result}");
                    break;
                case "sub":
                    result = num1 + num2;
                    Console.WriteLine($"The sub sum of {num1} and {num2} is {result}");
                    break;
                default:
                    Console.WriteLine("invalid arguments, please use help command for instructions");
                    break;
            }


        }
    }
}
