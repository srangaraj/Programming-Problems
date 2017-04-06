using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class PalindromeChecker
    {
        private Dictionary<string, int> map;
        private string[] elems;
        public PalindromeChecker(string[] input)
        {
            elems = input;
            map = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                //assuming strings are unique
                map.Add(Reverse(input[i]), i);
            }

        }
        public List<List<string>> GetPalindromPairs()
        {
            List<List<string>> result = new List<List<string>>();
            foreach (string s in elems)
            {
                List<string> prefixes = GetPrefixes(s);
                foreach (string pre in prefixes)
                {
                    if (map.ContainsKey(pre))
                    {
                        int index = map[pre];
                        if (!string.Equals(elems[index], pre))
                        {
                            string suffix = GetSuffix(s, pre);
                            if (IsPalindrome(suffix))
                            {
                                List<string> palindromePair = new List<string>();
                                palindromePair.Add(s);
                                palindromePair.Add(elems[index]);
                                if (!result.Contains(palindromePair))
                                    result.Add(palindromePair);
                            }
                        }
                    }
                }

            }
            return result;
        }

        private string Reverse(string s)
        {
            char temp;
            char[] charArray = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                temp = s[j];
                charArray[j] = charArray[i];
                charArray[i] = temp;
            }
            return new string(charArray);
        }
        private List<string> GetPrefixes(string str)
        {
            List<string> prefixes = new List<string>();
            int start = 0, length = 1;
            while (length <= str.Length)
            {
                prefixes.Add(str.Substring(start, length));
                length++;
            }
            return prefixes;
        }
        private string GetSuffix(string s, string pre)
        {
            return s.Substring(pre.Length);
        }
        private bool IsPalindrome(string s)
        {
            if (s == null)
                return false;
            if (s == "")
                return true;
            int start = 0, end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
