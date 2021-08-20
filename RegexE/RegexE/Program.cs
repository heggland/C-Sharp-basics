using System;
using System.Text.RegularExpressions;

namespace RegexE
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            string pattern2 = @"\d{5}";
            string pattern3 = @"there";
            Regex regex = new Regex(pattern3);

            string text = "1 Hi there, my number is 123456789ABC";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found in: {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
        }
    }
}
