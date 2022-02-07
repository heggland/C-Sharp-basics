using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // HelloWorld();
             Counting();
            //ParalleleThread();
            Console.ReadLine();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello world 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world 3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world 4");
        }

        static void Counting()
        {

            int i = 0;

            new Thread(() =>
            {
             
            while (i <= 10)
            {
                Console.WriteLine(i++);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fin");
            }).Start();

            new Thread(() =>
            {
              
                if (i == 5)
                {
                    Console.WriteLine("Five");
                } else
                {
                    Console.WriteLine("not five");
                }
            }).Start();
        }

        static void ParalleleThread()
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
        }
    }
}
