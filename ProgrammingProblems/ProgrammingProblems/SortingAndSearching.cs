using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public static class SortingAndSearching
    {
        public static void mergeSortedArrays(int[] a, int[] b, int lastA, int lastB)
        {
            int i = 1;
            while (lastA >= 0 && lastB >= 0)
            {
                if (b[lastB] > a[lastA])
                {
                    a[a.Length - i] = b[lastB];
                    lastB--;
                }
                else if (a[lastA] > b[lastB])
                {
                    a[a.Length - i] = a[lastA];
                    lastA--;
                }
                i++;

            }
            foreach (int ii in a)
            {
                Console.WriteLine(ii);
            }
        }
        public static void groupAnagrams(string[] s)
        {
            Dictionary<string, string> table = new Dictionary<string, string>();
            foreach (string str in s)
            {
                var sorted = new string(str.OrderBy(c => c).ToArray());
                if (table.ContainsKey(sorted) && !string.IsNullOrEmpty(table[sorted]))
                {
                    var value = table[sorted];
                    table[sorted] = value + "," + str;
                }
                else
                {
                    table.Add(sorted, str);
                }
            }
            Dictionary<string, string>.Enumerator iterator = table.GetEnumerator();
            int counter = 0;
            while (iterator.MoveNext())
            {
                KeyValuePair<string, string> pair = iterator.Current;
                if (pair.Value.Contains(","))
                {
                    foreach (string v in pair.Value.Split(','))
                    {
                        s[counter] = v;
                        counter++;
                    }
                }
                else
                {
                    s[counter] = pair.Value;
                    counter++;
                }
            }
            foreach (string v in s)
                Console.WriteLine(v);

        }

        public static int findElementInRotatedArray(int[] a, int k)
        {
            int offset = 0;
            while (offset < a.Length && a[offset] > a[offset + 1])
                offset++;
            int kthPos = binarySearch(a, 0, a.Length - 1, offset, k);
            if (kthPos + offset >= a.Length)
            {
                int x = (kthPos + offset) - a.Length;

                return x;
            }
            return kthPos + offset;
        }
        private static int binarySearch(int[] elems, int l, int h, int offset, int k)
        {
            int m = (h + l) / 2;
            if (k == elems[m + offset])
                return m;
            else if (k < elems[m + offset])
                return binarySearch(elems, l, m, offset, k);
            else
                return binarySearch(elems, m, h, offset, k);

        }

        public static int findStringInArrayWithEmptyStrings(string[] arr, string str, int start, int end)
        {
            int mid = (start + end) / 2;
            if (string.IsNullOrEmpty(arr[mid]))
            {
                int left = mid - 1;
                int right = mid + 1;
                while (true)
                {
                    if (right > end || left < start)
                        return -1;
                    if (right <= end && !string.IsNullOrEmpty(arr[right]))
                    {
                        mid = right;
                        break;
                    }
                    if (left >= start && !string.IsNullOrEmpty(arr[left]))
                    {
                        mid = left;
                        break;
                    }
                    left--;
                    right++;
                }
            }


            if (arr[mid].Equals(str))
                return mid;
            if (arr[mid].CompareTo(str) < 0)
                return findStringInArrayWithEmptyStrings(arr, str, mid + 1, end);
            else
                return findStringInArrayWithEmptyStrings(arr, str, start, mid - 1);
        }


    }
}