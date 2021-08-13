using System;
using System.Collections.Generic;

namespace stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            Console.WriteLine($"Top value in stack is: {stack.Peek()}");
            stack.Push(2);
            Console.WriteLine($"Top value in stack is: {stack.Peek()}");
            stack.Push(3);
            int myStackItem = stack.Pop();
            Console.WriteLine($"Popped item: {myStackItem}");
            Console.WriteLine($"Top value in stack is: {stack.Peek()}");

            while (stack.Count > 0)
            {
                Console.WriteLine($"The top value was removed from the stack: : {stack.Pop()}");
                Console.WriteLine($"Current stack count is: {stack.Count}");
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> myStack = new Stack<int>();

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("\n");

            while (myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }
        }
    }
}
