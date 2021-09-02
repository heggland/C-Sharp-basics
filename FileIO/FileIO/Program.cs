using System.Text;
using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string text = System.IO.File.ReadAllText(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\text.txt");
            Console.WriteLine($"Text file contains following text: \n\n\t{text}");

            Console.WriteLine();
            */


            /*
             string[] lines = System.IO.File.ReadAllLines(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\text.txt");
            Console.WriteLine($"Contents of text.txt: \n");
            foreach(string line in lines)
            {
            Console.WriteLine("\t" + line);
            }
            */

            Console.WriteLine("Write text to a file: ");
            string[] writeLines = { Console.ReadLine() };
            Console.WriteLine("Give the file a name");
            string fileName = Console.ReadLine() + ".txt";
            File.WriteAllLines(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\" + fileName, writeLines);
            Console.WriteLine(System.IO.File.ReadAllText(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\" + fileName) + $"written into {fileName}");



            // only write if content contains..
            string[] lines = { "F250", "Second", "Third 420" };

            using (StreamWriter file = new StreamWriter(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\heggland\Documents\GitHub\Complete-C-Sharp-Masterclass-Udemy\assets\myText.txt", true))
            {
                file.WriteLine("Additional line");
            }

                Console.ReadKey();
        }
    }
}
