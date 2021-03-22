using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.Object;
using StackAndQueue.Queue;
using StackAndQueue.Stack;

namespace StackAndQueue
{
    public class Program
    {
        private static void StackTests()
        {
            // STACK
            Console.WriteLine(("Starting STACK"));
            Console.WriteLine(("--------------"));

            var stack = new StackImpl(2);
            stack.Push(new DataObject
            {
                SomeProperty = "A"
            });

            if (stack.Peek() == null || stack.Peek().SomeProperty != "A")
            {
                Console.WriteLine($"peek returned a value that did not match A");
            }

            stack.Push(new DataObject
            {
                SomeProperty = "B"
            });

            if (stack.Peek() == null || stack.Peek().SomeProperty != "B")
            {
                Console.WriteLine($"peek returned a value that did not match B");
            }

            stack.Push(new DataObject
            {
                SomeProperty = "C"
            });

            if (stack.Peek() == null || stack.Peek().SomeProperty != "B")
            {
                Console.WriteLine($"adding C exceeded the size so C is discarded. However, peek returned a value that did not match B");
            }

            stack.Pop();
            stack.Pop();

            if (!stack.IsEmpty())
            {
                Console.WriteLine($"popped all items off of stack, but it is not empty");
            }
        }

        private static void QueueTests()
        {
            // QUEUE
            Console.WriteLine(("Starting QUEUE"));
            Console.WriteLine(("--------------"));

            var queue = new QueueImpl(2);
            queue.Enqueue(new DataObject
            {
                SomeProperty = "A"
            });

            if (queue.Peek() == null || queue.Peek().SomeProperty != "A")
            {
                Console.WriteLine($"peek returned a value that did not match A");
            }

            queue.Enqueue(new DataObject
            {
                SomeProperty = "B"
            });

            if (queue.Peek() == null || queue.Peek().SomeProperty != "A")
            {
                Console.WriteLine($"peek returned a value that did not match A");
            }

            queue.Enqueue(new DataObject
            {
                SomeProperty = "C"
            });

            if (queue.Peek() == null || queue.Peek().SomeProperty != "A")
            {
                Console.WriteLine($"adding C exceeded the size so C is discarded. However, peek returned a value that did not match A");
            }

            queue.Dequeue();
            queue.Dequeue();

            if (!queue.IsEmpty())
            {
                Console.WriteLine($"dequeued all items off of queue, but it is not empty");
            }
        }


        private static void Main(string[] args)
        {
            StackTests();

            QueueTests();
        }
    }
}
