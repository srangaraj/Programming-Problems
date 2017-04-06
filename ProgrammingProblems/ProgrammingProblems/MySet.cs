using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProgrammingProblems
{
    public class MySet
    {
       private ArrayList list;
       private Dictionary<int, int> dict;
        public MySet()
        {
            list = new ArrayList();
            dict = new Dictionary<int, int>();
        }
        /// <summary>
        /// Inserts specified value into arraylist. 
        /// </summary>
        /// <param name="value">Value to be inserted</param>
        public void Insert(int value)
        {
            if (!list.Contains(value))
            {
                list.Add(value);
                // Inserts element as key and it's index in arraylist as value.
                dict.Add(value, list.Count - 1);
            }
        }

        /// <summary>
        /// Removes specified value from arraylist by looking up it's index from the dictionary. 
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
        {
            if (dict.ContainsKey(value))
            {
                int index = dict[value];
                //Copy last element into the index of element to be removed
                list[index] = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                //Remove element from dictionary
                dict.Remove(value);
                //Update index of last element.
                dict.Remove(Convert.ToInt32(list[index]));
                dict.Add(Convert.ToInt32(list[index]), Convert.ToInt32(index));
            }
        }

        /// <summary>
        /// Returns a random element from arraylist
        /// </summary>
        /// <returns></returns>
        public int GetRandomElement()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, list.Count );
            return Convert.ToInt32(list[randomIndex]);
        }
    }
}
