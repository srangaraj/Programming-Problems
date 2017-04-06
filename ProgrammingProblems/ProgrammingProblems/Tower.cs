using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class Tower
    {
        public Stack<int> disks;
        private int index;
        public Tower()
        {
            disks = new Stack<int>();
        }
        public int getCurrentIndex()
        {
            return index;
        }
        public void addDisk(int d)
        {
            disks.Push(d);
        }
        public void moveTopTo(Tower t)
        {
            int i = this.disks.Pop();
            t.addDisk(i);
        }
        public void moveDisks(int n, Tower destination, Tower buffer)
        {
            if (n > 0)
            {
                moveDisks(n - 1, buffer, destination);
                moveTopTo(destination);
                moveDisks(n - 1, destination, this);

            }
        }
    }
  
}
