using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 namespace ProgrammingProblems
{
    public class Heap
    {
        private int[] p_queue;
        private int index = 0;
        private static int SIZE = 20;
        public Heap()
        {
            p_queue = new int[SIZE];
        }
        public void Insert(int elem)
        {
            if (index == SIZE)
                return;
            p_queue[index] = elem;
            
            Bubble_up(index++);
        }
        private void Bubble_up(int currIndex)
        {
            
                int parentIndex = GetParentIndex(currIndex);
                if (p_queue[currIndex] < p_queue[parentIndex])
                {
                    Swap(ref p_queue[currIndex], ref p_queue[parentIndex]);
                    Bubble_up(parentIndex);
                }
            
        }
        private int GetParentIndex(int curr)
        {
            if (curr == 0 || curr == 1 )
                return 0;
            if (index % 2 == 0)
                return (curr / 2) - 1;
            else return (curr / 2);

        }
        private void Swap(ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;

        }
        

    }
}
