using System;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue<int> queue = new Queue<int>();
            
            int count = 0;
            do
            {
                count++;
                queue.Enqueue(count);
                Console.WriteLine(count);
            } while (count < 10);

            queue.Dequeue();

            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");
           
            while (queue.Count > 0)
            {
                Console.WriteLine($"The front value {queue.Dequeue()} was removed from the queue");
                Console.WriteLine($"Current queue count is {queue.Count}");
            }
             */

            Queue<Order> ordersQueue = new Queue<Order>();
            foreach (Order o in ReciveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReciveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        static Order[] ReciveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] ReciveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }
}
