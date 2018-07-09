using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First in queue");
            queue.Enqueue("Second in queue");
            queue.Enqueue("Third in queue");
            queue.Enqueue("Fourth in queue");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
            }

            Console.WriteLine("\n\n");

            Stack stack = new Stack();
            stack.Push("First in stack");
            stack.Push("Second in stack");
            stack.Push("Third in stack");
            stack.Push("Fourth in stack");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }

            Console.WriteLine("\n\n");


        }
    }
}
