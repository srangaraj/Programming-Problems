using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class SpecialArray
    {
        public Dictionary<int, int> dict;
        public int[] A;

        public SpecialArray()
        {
            dict = new Dictionary<int, int>();
        }
        public void AddElement(int elem)
        {
            if (A.Length == 0)
            {
                A[0] = elem;
                dict.Add(0, elem);
            }
            else
            {
                int index = A.Length - 1;
                A[index] = elem;
                if (dict.ContainsKey(elem))
                {
                    dict.Remove(elem);
                }
                dict.Add(elem, index);
            }
        }
        public bool RemoveElement(int elem)
        {
            if (dict.ContainsKey(elem))
            {
                int index = dict[elem];
                dict.Remove(elem);
                A[index] = -1;
                return true;
            }
            return false;
        }
      
    }
}
