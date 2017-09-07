using System;
using System.Collections;
namespace Collections
{
    class MyStack
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Clear();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Contains(2));

            foreach (var itm in myStack)
            {
                Console.WriteLine(itm);
            }
            Console.ReadLine();
        }
    }
}