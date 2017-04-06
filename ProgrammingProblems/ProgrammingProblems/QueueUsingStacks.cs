using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class QueueUsingStacks
    {
        private Stack<int> stackOldest;
        private Stack<int> stackNewest;
        private static int CAPACITY = 100;
        public QueueUsingStacks()
        {
            stackNewest = new Stack<int>();
            stackOldest = new Stack<int>();
        }
        public int getSize()
        {
            return stackNewest.Count + stackOldest.Count;
        }
        public void enqueue(int data)
        {
            stackNewest.Push(data);
        }
        public int dequeue()
        {
            shiftStacks();
            return stackOldest.Pop();
        }
        public int peek()
        {
            shiftStacks();
            return stackOldest.Peek();
        }
        private void shiftStacks()
        {
            if (stackOldest.Count == 0)
            {
                for (int i = 0; i < stackNewest.Count; i++)
                {
                    int n = stackNewest.Pop();
                    stackOldest.Push(n);
                }

            }
        }
    }
}
