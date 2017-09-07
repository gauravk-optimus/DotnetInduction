using System;
using System.Collections;

namespace Collections
{
    public class MyQueue
    {
        public static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Dequeue();
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Contains(3));
            myQueue.Clear();
            foreach (var itm in myQueue)
            {
                Console.WriteLine(itm);
            }
            Console.ReadLine();
        }
    }
}
