using System.Text.RegularExpressions;

namespace Coding_exercises
{
    internal class ParsingGamePart2
    {
        public void Run()
        {
            string path = Directory.GetCurrentDirectory() + @"\";
            string fileName = "input2.txt";

            // Read and store the whole text from the source file
            string fileText = File.ReadAllText(path + fileName);

            // using regular expressions find all sequences of numbers that has length 2 or 3;
            string pattern = @"\d{2,3}";
            string[] numberArr = Regex.Matches(fileText, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();



            string text = "";
            for (int i = 0; i < numberArr.Length; i++)
            {
      
                // Pars every value into an integer;
                int numInt = int.Parse(numberArr[i]);

                // Use casting to convert every integer into a char.
                char character = (char)numInt;

                // Console.WriteLine("{0} converts to '{1}'", numInt, character);

                text += character;
            }

            Console.WriteLine(text);
        }
    }
}

