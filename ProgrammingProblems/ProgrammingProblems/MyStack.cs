using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class MyStack
    {
        private const int SIZE = 98;
        public int stackNum;
        public int[] stack;
        public int[] stackPointer = { -1, -1, -1 };
        public MyStack()
        {
            stack = new int[SIZE];
        }
        public bool Push(int value, int stackNum)
        {
            bool success = false;
            try
            {
                int i = (stackNum * 33) + stackPointer[stackNum] + 1;
                stack[i] = value;
                stackPointer[stackNum]++;
                success = true;
            }
            catch (Exception ex)
            { }
            return success;

        }
        public int Pop(int stackNum)
        {
            int temp;
            int i = (stackNum * 33) + stackPointer[stackNum];
            temp = stack[i];
            stack[i] = 0;
            stackPointer[stackNum]--;
            return temp;
        }
        public bool isEmpty(int stackNum)
        {
            return (stackNum * 33) + stackPointer[stackNum] == 0;
        }
        public int getTop(int stackNum)
        {
            return (stackNum * 33) + stackPointer[stackNum];
        }


    }
    public class StackWithin : Stack<NodeWithMin>
    {
        public void push(int value)
        {
            int newMin = Math.Min(value, Peek().Min);
            base.Push(new NodeWithMin(value, newMin));
        }
        public int min()
        {
            return Peek().Min;
        }
    }
    public class NodeWithMin
    {
        private int _value, _min;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        public NodeWithMin(int value, int min)
        {
            _value = value;
            _min = min;
        }
    }
    public class StackWithMinAlt : Stack<Node>
    {
        public Stack<int> MinStack;
        public void Push(int value)
        {
            if (value < MinStack.Peek())
                MinStack.Push(value);
            this.Push(value);
        }
        public int Pop()
        {
            int v = this.Pop();
            if (v == MinStack.Peek())
                MinStack.Pop();
            return v;
        }
        public int Min()
        {
            return MinStack.Peek();
        }
    }
}

