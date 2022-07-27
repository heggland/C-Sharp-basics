using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class Lists
    {
        List<int> Solution()
        {
            // TODO: write your solution here
            //create a new list 
            List<int> myList = new List<int>();
            //go thorugh every number beyweem 100 and 170
            for (int i = 100; i <= 170; i++)
            {
                //check if its an even number
                if (i % 2 == 0)
                {
                    //add it to the list
                    myList.Add(i);
                }
            }
            //return the list
            return myList;
        }

        public void Run()
        {
            //
        }
    }
}
