namespace Coding_exercises
{
    internal class ParsingGamePart1
    {
        public void Run()
        {
            string path = Directory.GetCurrentDirectory() + @"\";
            string fileName = "input.txt";

            string[] file = File.ReadAllLines(path + fileName);

            string filteredWords = "";

            foreach (string line in file)
            {
                if (line.Contains("split"))
                {
                    string[] words = line.Split(" ");
                    filteredWords += FilterOutWord(words, 4);;
                }
            }

            Console.WriteLine(filteredWords);
            File.WriteAllText(path + "output.txt", filteredWords);
        }

        private string FilterOutWord(string[] words, int pos) => words[pos].ToString() + " ";
    }
}

