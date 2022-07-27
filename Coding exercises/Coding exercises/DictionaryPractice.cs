using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class DictionaryPractice
    {
        public static string Convert(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>(){
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"}
            };

            if (dic.ContainsKey(i))
                return dic[i];
            else
                return "nope";
        }

        public void Run()
        {
            var print = Convert(3);
            Console.WriteLine(print);
        }

    }
}
