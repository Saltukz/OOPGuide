using System.Collections;

namespace StacknQueue
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("John");
            stack.Push("Caroline");
            stack.Push("Kelly");
            Console.WriteLine("The element popped from the stack is {0}",stack.Pop());
            Console.WriteLine("The element at the top of the stack is {0}",stack.Peek());
            
            Console.WriteLine("the element popped from the stack is {0}",stack.Pop());
            Console.WriteLine("The element at the top of the stack is {0}", stack.Peek());
            Console.WriteLine("The number of the elemets in the stack is {0}",stack.Count);


            Console.WriteLine("*******************************************************");
            Queue queue = new Queue();
            queue.Enqueue("John");
            queue.Enqueue("Caroline");
            queue.Enqueue("Kelly");
            Console.WriteLine("The first element removed from the queue is {0}",queue.Dequeue());
            Console.WriteLine("The element at the beginning of the queue is {0}", queue.Peek());
            Console.WriteLine("The number of the elemets in the stack is {0}", queue.Count);
        }
    }
}