using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
namespace ProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUniqueChars = IsUniqueCharsAlternate(args[0]);

            string reversedString = RevString("fancyfreed\0");

            bool isPermutation = IsPerm("abcde", "abecd");

            char[] str = new char[60];
            str[0] = 's';
            str[1] = ' ';
            str[2] = 't';
            str[3] = 'r';
            string noSpacesString = replaceSpaces(str, 4);

            bool result = isRotation("waterbottle", "erbottlewat");

            string compressedString = compressedStringAlternate("aabbb");

            Node n = new Node(1, null);
            Node n1 = new Node(2, n);
            Node n2 = new Node(3, n1);
            Node n3 = new Node(4, n2);
            Node n4 = new Node(5, n3);
            LinkedList list = new LinkedList(n4);
            list.AddNodes(new Node[] { n3, n2, n1, n });
            Node head = list.Head;
            ReverseList(head);

            RevRecursive(head);
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

            MyLinkedList linkedListproblems = new MyLinkedList();
            LinkedList<int> lList = new LinkedList<int>();
            LinkedListNode<int> node = new LinkedListNode<int>(10);
            lList.AddFirst(node);
            lList.AddLast(6);
            lList.AddLast(9);
            lList.AddLast(77);
            lList.AddLast(100);
            lList.AddLast(43);
            lList.AddLast(25);
            lList.AddLast(27);
            lList.AddLast(88);
            linkedListproblems.partitionList(node, 50);

            SortingAndSearching.mergeSortedArrays(new int[] { 2, 20, 44, 50, 55, 0, 0, 0, 0, 0 }, new int[] { 3, 18, 27, 95, 100 }, 4, 4);

            SortingAndSearching.groupAnagrams(new string[] { "abc", "dev", "bca", "prf", "edv", "cab", "frp" });

            SortingAndSearching.findElementInRotatedArray(new int[] { 5, 6, 1, 2, 3, 4 }, 6);

            int pos = SortingAndSearching.findStringInArrayWithEmptyStrings(new string[] { "abc", "def", "", "ghi", "", "jkl", "mno", "", "pqr" }, "jkl", 0, 7);

            Info inf = linkedListproblems.KthToLast(n3, 4);

            Node noDups = linkedListproblems.DeleteDupsAlternate(n3);

            while (noDups != null)
            {
                Console.WriteLine(noDups.data);
                noDups = noDups.next;
            }

            MyStack myStack = new MyStack();
            myStack.Push(10, 2);
            myStack.Push(11, 2);
            myStack.Push(12, 2);
            int numDelted = myStack.Pop(2);
            Tower origin = new Tower();
            Tower destination = new Tower();
            Tower buffer = new Tower();
            for (int i = 5; i > 0; i--)
                origin.addDisk(i);
            origin.moveDisks(5, destination, buffer);

            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(3);
            stack.Push(10);
            stack.Push(1);
            stack.Push(5);
            stack.Push(-1);
            Stack<int> sorted = sortStack(stack);

            bool isBalanced = IsBalanced("[{()}");

            int[] num = new int[] { 1, 2, 3, 4 };
            int[] product = ProductOfAllOtherNumbers(num);

            LinkedList<int> l1 = new LinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            l1.AddFirst(node1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            LinkedList<int> l2 = new LinkedList<int>();
            LinkedListNode<int> node2 = new LinkedListNode<int>(6);
            l2.AddFirst(node2);
            l2.AddLast(5);
            l2.AddLast(7);
            l2.AddLast(8);
            LinkedListNode<int> intersection = GetIntersection(node1, node2);

            Heap pq = new Heap();
            pq.Insert(1492);
            pq.Insert(1783);
            pq.Insert(1776);
            pq.Insert(1804);

            int[] A = new int[] { 4, 10, 1, 2, 9, 6, 7, 5 };
            MergeSort(ref A, 8, 0, 7);

            int[] B = new int[] { 10, 15, 16, 39, 44, 100, 200 };
            int index = BinarySearch(B, 300);

            float root = SquareRoot(122);

            Graph g = new Graph(6, true);
            g.AddEdge(1, 6);
            g.AddEdge(1, 5);
            g.AddEdge(1, 2);
            g.AddEdge(2, 5);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.Initialize_DFS();
            g.DFS(1);

            PalindromeChecker checker = new PalindromeChecker(new string[] { "gab", "bag", "nurses", "run", "cat" });
            List<List<string>> palindromePairs = checker.GetPalindromPairs();
            int[] sorted_array = InsertionSort(new int[] { 10, 9, 1, 15, 25, 2 });

            SeggregateArray(new int[] { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 });

            PartitionArray(new int[] { 10, 20, 40, 8, 10, 2, 9, 50, 100 }, 4);

            PartitionArray(new int[] { 0, 1, 0, 1, 2, 2, 1, 1, 1, 0 });

            string int_to_str = IntToString(-9677);

            int str_to_int = StringToInt("945");

            string str_input = "ram is costly";
            string reverse_str = RevWord(str_input, 0, str_input.Length - 1);
            StringBuilder sb = new StringBuilder();
            foreach (string s2 in str_input.Split(' '))
                sb.Append(RevWord(s2, 0, s2.Length - 1) + " ");
            Console.WriteLine(sb);

            string arr = "dfgabsafb                   ";
            ReplaceChars(arr);

            int index_smallest = FindSmallest(new int[] { 220, 234, 279, 368, 378, 478, 550, 631, 103, 203 }, 0, 9);

            int index_elem = FindElemInCylclicallySortedArray(new int[] { 220, 234, 279, 368, 378, 478, 550, 631, 103, 203 }, 0, 9, 279);

            int[][] C = new int[2][];
            C[0] = new int[] { 1, 2 };
            C[1] = new int[] { 5, 6 };
            C[2] = new int[] { 9, 10, 11, 12 };
            C[3] = new int[] { 13, 14, 15, 16 };
            PrintSpiral(C);

            permutation("", "abc");

            dnf(new int[] { 9, 11, 3, 5, 1, 9, 15 }, 5);

            ManipulateString("abcd");

            Stack<int> input = new Stack<int>();
            input.Push(1);
            input.Push(10);
            input.Push(3);
            input.Push(-1);
            input.Push(2);
            input.Push(5);
            input.Push(5);
            SortStack(input);

            List<List<int>> master = new List<List<int>>();
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            master.Add(l);
            l = new List<int>();
            l.Add(4);
            l.Add(6);
            master.Add(l);
            l = new List<int>();
            l.Add(5);
            master.Add(l);
            Permutation(master);

            paren("", 6, 0, 0, 3, 3);

            string s = convertinttoword(24519);
            List<List<char>> list1 = new List<List<char>> { new List<char>() { 'a', 'b' }, new List<char> { 'c', 'd' }, new List<char> { 'e', 'f' } };

            int[] A1 = new int[] { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
            int ans = lis(A1, 0);
        }
        public static bool IsUniqueChars(string str)
        {
            if (str.Length > 256)
                return false;
            bool[] char_str = new bool[256];
            for (int i = 0; i < char_str.Length; i++)
            {
                int c = str[i];
                if (char_str[c])
                    return false;
                char_str[c] = true;
            }
            return true;
        }



        public static bool IsUniqueCharsAlternate(string str)
        {
            if (str.Length > 256)
                return false;
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = (int)str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                    return false;
                checker = checker | (1 << val);
            }
            return true;
        }


        public static string RevString(string s)
        {
            int start = 0, end = s.Length - 1;
            char[] sArray = s.ToCharArray();
            while (start < end)
            {
                Swap(ref sArray, start, end);
                start++;
                end--;
            }
            return new string(sArray);
        }
        private static void Swap(ref char[] strArray, int ptr1, int ptr2)
        {
            char temp;
            temp = strArray[ptr1];
            strArray[ptr1] = strArray[ptr2];
            strArray[ptr2] = temp;
        }



        public static string ReverseString(string str)
        {
            int end = str.Length - 2;
            int start = 0;
            char[] str_CharArray = str.ToCharArray();
            while (start < end)
            {
                char temp = str_CharArray[start];
                str_CharArray[start++] = str_CharArray[end];
                str_CharArray[end--] = temp;
            }
            return new string(str_CharArray, 0, str_CharArray.Length - 1);
        }
        public static bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            char[] str1_array = str1.ToCharArray();
            char[] str2_array = str2.ToCharArray();
            Array.Sort(str1_array);
            Array.Sort(str2_array);
            return new string(str1_array).Equals(new string(str2_array));

        }

        public static bool IsPerm(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            int[] letters = new int[256];
            for (int i = 0; i < str1.Length; i++)
                letters[(int)str1[i]]++;
            for (int i = 0; i < str2.Length; i++)
            {
                if (--letters[(int)str2[i]] < 0)
                    return false;
            }
            return true;
        }
        //check if 2 strings have identical character counts
        public static bool IsPermutationAlternate(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            int[] letters = new int[256];
            foreach (char c in str1)
                letters[c]++;
            foreach (char c in str2)
            {
                if (--letters[c] < 0)
                    return false;
            }
            return true;
        }

        public static void RepSpace(char[] str, int length)
        {
            int newLength = 0, spaceCount = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                    spaceCount++;
            }
            newLength = length + (spaceCount * 2);

            int i = length - 1;
            while (i >= 0)
            {
                if (str[i] == ' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    str[newLength - 1] = str[i];
                    newLength--;
                }
                i--;
            }

        }

        public static string replaceSpaces(char[] strArray, int length)
        {
            int count = 0;

            foreach (char c in strArray)
            {
                if (c == ' ')
                    count++;
            }
            int newLength = length + count * 2;
            //if you star with i = 0 then you end up with a reversed string
            for (int i = length - 1; i >= 0; i--)
            {
                if (strArray[i] == ' ')
                {
                    strArray[newLength - 1] = '0';
                    strArray[newLength - 2] = '2';
                    strArray[newLength - 3] = '%';
                    newLength -= 3;
                }
                else
                {
                    strArray[newLength - 1] = strArray[i];
                    newLength -= 1;
                }
            }
            return new string(strArray);
        }
        public static bool isRotation(string s1, string s2)
        {
            int len = s1.Length;
            if (len == s2.Length && len > 0)
            {
                string s1s1 = s1 + s1;
                return s1s1.IndexOf(s2) > 0;
            }
            return false;
        }
        public static string compressString(string str)
        {
            StringBuilder compressedStr = new StringBuilder();
            int length = CountCompression(str);
            if (length < str.Length)
            {
                char last = str[0];
                int charCount = 0;
                foreach (char c in str)
                {
                    if (last == c)
                        charCount++;
                    else
                    {
                        compressedStr.Append(last);
                        compressedStr.Append(charCount);
                        charCount = 1;
                        last = c;
                    }
                }
                compressedStr.Append(last);
                compressedStr.Append(charCount);
                return compressedStr.ToString();
            }
            return str;
        }

        public static string compressedStringAlternate(string str)
        {

            int length = CountCompression(str);
            char[] compressedStr = new char[length];
            if (length < str.Length)
            {
                char last = str[0];
                int charCount = 0;
                int index = 0;
                foreach (char c in str)
                {
                    if (last == c)
                        charCount++;
                    else
                    {
                        compressedStr[index] = last;
                        compressedStr[index + 1] = charCount.ToString().ToCharArray()[0];
                        index += 2;
                        charCount = 1;
                        last = c;
                    }
                }
                compressedStr[index] = last;
                compressedStr[index + 1] = charCount.ToString().ToCharArray()[0];
                return new string(compressedStr);
            }
            return str;
        }
        public static int CountCompression(string str)
        {
            int count = 0, length = 0;
            char last = str[0];
            foreach (char c in str)
            {
                if (last == c)
                    count++;
                else
                {
                    length += count.ToString().Length + 1;
                    count = 1;
                    last = c;
                }

            }
            length += count.ToString().Length + 1;
            return length;
        }
        public static int Multiples()
        {
            int result = 0;

            for (int ii = 0; ii < 1000; ii++)
            {
                if (ii % 3 == 0 || ii % 5 == 0)
                    result += ii;
            }
            return result;
        }

        public static void Set0Matrix(int[][] matrix)
        {
            bool[] rows = new bool[matrix.GetLength(0)];
            bool[] columns = new bool[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = true;
                        columns[j] = true;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (rows[i] || columns[j])
                        matrix[i][j] = 0;
                }
            }
        }

        public static Stack<int> sortStack(Stack<int> s)
        {

            Stack<int> r = new Stack<int>();
            while (s.Count > 0)
            {
                int v1 = s.Pop();

                if (r.Count > 0 && v1 < r.Peek() || r.Count == 0)
                    r.Push(v1);
                else
                {
                    int counter = 0;
                    while (r.Count > 0 && v1 > r.Peek())
                    {
                        s.Push(r.Pop());
                        counter++;
                    }
                    r.Push(v1);
                    //for (int i = 0; i < counter; i++)
                    //    r.Push(s.Pop());
                }
            }
            //while (s.Count > 0)
            //{
            //    int tmp = s.Pop();
            //    while (r.Count > 0 && r.Peek() < tmp)
            //        s.Push(r.Pop());
            //    r.Push(tmp);

            //}
            return r;

        }
        public static bool IsBalanced(string expression)
        {
            HashSet<char> openers = new HashSet<char>();
            HashSet<char> closers = new HashSet<char>();
            Dictionary<char, char> braces = new Dictionary<char, char>();
            Stack<char> tracker = new Stack<char>();
            braces.Add('[', ']');
            braces.Add('(', ')');
            braces.Add('{', '}');
            openers.UnionWith(braces.Keys);
            closers.UnionWith(braces.Values);
            foreach (char c in expression)
            {
                if (openers.Contains(c))
                    tracker.Push(c);
                else if (closers.Contains(c))
                {
                    if (tracker.Count == 0)
                        return false;
                    char lastItem = tracker.Pop();
                    if (c != braces[lastItem])
                        return false;
                }

            }
            return tracker.Count == 0;
        }
        public static int[] ProductOfAllOtherNumbers(int[] num)
        {
            int l = num.Length;
            int[] arrProductBeforeIndex = new int[l];
            int productSoFar = 1;
            for (int i = 0; i < l; i++)
            {
                arrProductBeforeIndex[i] = productSoFar;
                productSoFar *= num[i];
            }
            productSoFar = 1;
            for (int i = l - 1; i >= 0; i--)
            {
                arrProductBeforeIndex[i] *= productSoFar;
                productSoFar *= num[i];
            }
            return arrProductBeforeIndex;

        }
        public static LinkedListNode<int> GetIntersection(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            if (l1 == null || l2 == null)
                return null;

            int len1 = 0, len2 = 0;
            LinkedListNode<int> temp = l1;
            while (temp != null)
            {
                len1++;
                temp = temp.Next;
            }
            temp = l2;
            while (temp != null)
            {
                len2++;
                temp = temp.Next;
            }
            if (len1 == len2)
                return GetIntersectionOfLists(l1, l2, len1);
            else if (len1 > len2)
            {
                int counter = 0;
                while (counter != (len1 - len2))
                {
                    l1 = l1.Next;
                    counter++;
                }
                return GetIntersectionOfLists(l1, l2, len2);

            }
            else if (len2 > len1)
            {
                int counter = 0;
                while (counter == (len2 - len1))
                    l1 = l1.Next;
                return GetIntersectionOfLists(l1, l2, len1);

            }
            return null;
        }

        private static LinkedListNode<int> GetIntersectionOfLists(LinkedListNode<int> l1, LinkedListNode<int> l2, int length)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.Value == l2.Value)
                    return l1;
                l1 = l1.Next;
                l2 = l2.Next;
            }
            return null;

        }
        public static void MergeSort(ref int[] num, int count, int start, int end)
        {
            int mid = 0;
            if (count > 1)
            {
                mid = (end + start) / 2;
                MergeSort(ref num, count / 2, start, mid);
                MergeSort(ref num, count / 2, mid + 1, end);
                Merge(ref num, start, end, mid);
            }
        }
        private static void Merge(ref int[] a, int start, int end, int mid)
        {
            int[] res = new int[(end - start) + 1];
            int ptr = 0, ptrA = start, ptrB = mid + 1;
            // int ptr = a.Count() > b.Count() ? a.Count() : b.Count();
            while (ptrA <= mid && ptrB <= end)
            {
                if (a[ptrA] < a[ptrB])
                {
                    res[ptr] = a[ptrA];
                    ptrA++;
                }
                else
                {
                    res[ptr] = a[ptrB];
                    ptrB++;
                }
                ptr++;
            }
            if (ptrA <= mid)
            {
                for (int i = ptrA; i <= mid; i++)
                    res[ptr++] = a[i];
            }
            else if (ptrB <= end)
            {
                for (int i = ptrB; i <= end; i++)
                    res[ptr++] = a[i];

            }
            for (int i = start, j = 0; i <= end && j < res.Length; i++, j++)
                a[i] = res[j];

        }

        public static int BinarySearch(int[] n, int num)
        {
            if (n.Length == 0)
                return -1;
            int start = 0, end = n.Length - 1, mid = (start + end) / 2;
            return BinarySearch(n, start, end, mid, num);

        }
        private static int BinarySearch(int[] n, int start, int end, int mid, int num)
        {
            if (n[mid] == num)
                return mid;
            if (start > end)
                return -1;

            else if (num > n[mid])
            {
                return BinarySearch(n, mid + 1, end, (end + mid + 1) / 2, num);
            }
            else
                return BinarySearch(n, start, mid, (start + mid) / 2, num);
        }
        private static float SquareRoot(float n)
        {
            float l = 0;
            float h = n;

            return SquareRoot(n, l, h);

        }
        private static float SquareRoot(float n, float l, float h)
        {
            float m = (l + h) / 2;
            if (m * m == n)
                return m;
            else if (m * m > n)
                return SquareRoot(n, l, m - 1);
            else
                return SquareRoot(n, m, h);
        }
        public static int[] InsertionSort(int[] a)
        {
            int temp = 0, j = 0; ;
            for (int i = 1; i < a.Length; i++)
            {

                for (j = i - 1; j >= 0; j--)
                {
                    if (a[j + 1] < a[j])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }

                }


            }
            return a;
        }
        public static void PartitionArray(int[] A, int i)
        {
            int smaller = 0, equal = 0, larger = A.Length - 1;
            int pivot = A[i];
            while (equal <= larger)
            {
                if (A[equal] == pivot)
                    equal++;
                else if (A[equal] > pivot)
                {
                    Swap(A, larger, equal);
                    larger--;
                }
                else //A[equal] < pivot
                {
                    Swap(A, smaller, equal);
                    smaller++;
                    equal++;
                }
            }
            for (int ptr = 0; ptr < A.Length; ptr++)
                Console.Write(A[ptr] + " ");
        }
        public static int[] Swap(int[] A, int i, int j)
        {
            A[i] = A[i] ^ A[j];
            A[j] = A[i] ^ A[j];
            A[i] = A[i] ^ A[j];
            return A;
        }

        public static void SeggregateArray(int[] A)
        {
            int i = 0, j = A.Length - 1;
            while (i < j)
            {
                if (A[i] == 1 && A[j] == 0)
                {
                    Swap(A, i, j);
                    i++;
                    j--;
                }
                else if (A[i] == 0)
                    i++;
                else if (A[j] == 1)
                    j--;
            }
            for (int ptr = 0; ptr < A.Length; ptr++)
                Console.Write(A[ptr] + " ");
        }
        public static void PartitionArray(int[] A)
        {
            int low = 0, mid = 0, hi = A.Length - 1;

            while (mid <= hi)
            {
                if (A[mid] == 1)
                    mid++;
                else if (A[mid] > 1)
                {
                    Swap(A, hi, mid);
                    hi--;
                }
                else //A[equal] < 1
                {
                    Swap(A, low, mid);
                    low++;
                    mid++;
                }
            }
            for (int ptr = 0; ptr < A.Length; ptr++)
                Console.Write(A[ptr] + " ");
        }
        public static string IntToString(int x)
        {
            bool isNegative = x < 0;
            if (isNegative)
                x *= -1;
            StringBuilder str = new StringBuilder();
            while (x > 0)
            {
                str.Append(x % 10);
                x = x / 10;
            }
            string res = isNegative ? "-" + RevString(str.ToString()) : RevString(str.ToString());
            return res;
        }
        public static int StringToInt(string str)
        {
            int res = 0;
            int mul = 1;
            char[] arr = str.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int elem = arr[i] - '0';
                res = res * 10 + elem;
                // res = res + (mul * (arr[i]-'0'));
                //  mul *= 10;
            }
            return res;
        }
        //public static int ComputeDecimalZip(int a, int b)
        //{
        //    int divA = 1, divB = 1;
        //    int temp = a;
        //    while (temp > 1)
        //    {
        //        temp = temp / divA;
        //        divA *= 10;                
        //    }
        //    divA = divA / 10;
        //    temp = b;
        //    while (temp > 1)
        //    {
        //        temp = temp / divB;
        //        divB *= 10;
        //    }
        //    divB = divB / 10;
        //    while (divA > 1 && divB > 1)
        //    {
        //        temp = (a / divA) % 10;
        //    }

        public static bool ContainsSum(int[] A, int sum)
        {
            if (A.Length == 0)
                return false;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for (int i = 0; i < A.Length; i++)
            {
                int diff = sum - A[i];
                if (dict.ContainsKey(diff))
                    return true;
                dict[A[i]] = true;
            }
            return false;
        }
        public static string RevWord(string s, int start, int end)
        {
            int i = start;
            int j = end;

            char[] arr = s.ToCharArray();
            while (i < s.Length / 2)
            {
                char c = arr[i];
                arr[i] = arr[j];
                arr[j] = c;
                i++;
                j--;

            }
            return new string(arr);
        }
        public static void ReplaceChars(string s)
        {
            char[] arr = s.ToCharArray();
            int write_index = 0, a_count = 0, i = 0;
            while (arr[i] != ' ')
            {
                if (arr[i] != 'b')
                {
                    arr[write_index] = arr[i];
                    write_index++;
                }
                if (arr[i] == 'a')
                    a_count++;
                i++;
            }
            for (int j = write_index; j < arr.Length; j++)
                arr[j] = ' ';
            int newLength = i + a_count;
            int newIndex = newLength;
            while (i > 0)
            {
                if (arr[i] == 'a')
                {
                    arr[newIndex] = 'd';
                    arr[--newIndex] = 'd';
                }
                else
                    arr[newIndex] = arr[i];
                newIndex--;
                i--;
            }

            Console.WriteLine(new string(arr));
        }

        public static int FindSmallest(int[] A, int s, int e)
        {
            if (s == e || s > e)
                return A[s];
            //if (A.Length == 2)
            //    return A[0] < A[1] ? A[0] : A[1];
            int m = (s + e) / 2;
            //if (A[m] < A[s] && A[m] < A[e])
            //    return A[m];
            if (A[e] < A[m])
                return FindSmallest(A, m + 1, e);
            else
                return FindSmallest(A, s, m - 1);
        }

        public static int FindElemInCylclicallySortedArray(int[] A, int s, int e, int k)
        {

            int m = (s + e) / 2;
            if (A[m] == k)
                return m;
            //if (A.Length == 2)
            //    return A[0] < A[1] ? A[0] : A[1];

            //if (A[m] < A[s] && A[m] < A[e])
            //    return A[m];
            if (A[s] < A[m])
            {

                if (k > A[s] && k < A[m])
                    return FindElemInCylclicallySortedArray(A, s, m - 1, k);
                else
                    return FindElemInCylclicallySortedArray(A, m + 1, e, k);
            }
            else if (A[e] > A[m])
            {

                if (k > A[m] && k < A[e])
                    return FindElemInCylclicallySortedArray(A, m + 1, e, k);
                else
                    return FindElemInCylclicallySortedArray(A, s, m - 1, k);
            }
            else return -1;
        }

        private static void PrintSpiral(int[][] A)
        {
            int i = 0, j = 0, k = A.Length - 1, l = A[0].Length - 1;
            while (i < k && j < l)
            {
                PrintElements(i, k, j, l, A);
                i++;
                j++;
                k--;
                l--;
                Console.WriteLine();
            }
        }

        private static void PrintElements(int sr, int er, int sc, int ec, int[][] A)
        {
            for (int i = sc; i < ec; i++)
                Console.Write(A[sr][i] + " ");
            for (int i = sr; i < er; i++)
                Console.Write(A[i][ec] + " ");
            for (int i = ec; i > sc; i--)
                Console.Write(A[er][i] + " ");
            for (int i = er; i > sr; i--)
                Console.Write(A[i][sc] + " ");

        }
        private static void permutation(String ans, String remain)
        {
            int n = remain.Length;
            // ans serves as an accumulator variable
            // base case: we print out ans since there are no more letters to be added
            if (n == 0)
            {
                Console.WriteLine(ans);
            }
            // recursive case
            else
            {
                for (int i = 0; i < n; i++)
                {
                    // we call permutation, each time combining prefix with the individual letters in str
                    // we also remove these letters from str

                    permutation(ans + remain[i], remain.Substring(0, i) + remain.Substring(i + 1, n - (i + 1)));
                }
            }
        }

        //Dutch national flag problem
        private static void dnf(int[] A, int i)
        {
            int pivot = A[i];
            int smaller = 0, equals = 0, larger = A.Count() - 1;
            while (equals <= larger)
            {
                if (A[equals] < pivot)
                    SwapAlt(A, smaller++, equals++);
                else if (A[equals] == pivot)
                    ++equals;
                else
                    SwapAlt(A, equals, larger--);

            }
            for (int ii = 0; ii < A.Count(); ii++)
                Console.WriteLine(A[ii]);
        }

        private static void SwapAlt(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        public static void ManipulateString(string s)
        {

            int wi = 0;
            int len = 0;
            int cnt = 0;
            char[] A = s.ToCharArray();
            for (int k = 0; k < A.Length; k++)
            {

                if (A[k] == 'a')

                    cnt++;
                if (A[k] != 'b')
                    A[wi++] = A[k];


            }

            int newlen = wi + cnt;
            for (int k = wi; k < newlen; k++)
                A[k] = ' ';
            int i = wi - 1;
            int j = newlen - 1;


            while (i >= 0 && j >= 0)
            {

                if (A[i] == 'a')
                {

                    A[j] = 'd';

                    A[--j] = 'd';
                    j--;


                }


                else
                {

                    A[j] = A[i];
                    j--;


                }


                i--;


            }
            Console.WriteLine(new string(A));

        }
        static void ReverseList(Node n)
        {

            Node temp = n.next;

            Node c = n.next;

            while (temp != null)
            {

                c = temp.next;

                temp.next = n;

                n = temp;

                temp = c;

            }

        }

        static void RevRecursive(Node n)
        {
            Node tail = new Node(n.data, null);
            RevRecursive(tail, n.next);
        }

        static Node RevRecursive(Node n, Node ahead)
        {
            //5->4->3->2->1->null
            if (ahead == null)
                return n;
            Node temp = ahead.next;
            ahead.next = n;
            return RevRecursive(ahead, temp);

        }
        static Stack<int> SortStack(Stack<int> input)
        {
            if (input.Count == 0)
                return input;
            Stack<int> s = new Stack<int>();
            while (input.Count != 0)
            {
                int v = input.Pop();
                if (input.Count == 0)
                    s.Push(v);
                else
                {
                    int top = input.Peek();
                    if (v > top || v == top)
                        s.Push(v);
                    else
                    {
                        int h = input.Pop();
                        s.Push(h);
                        s.Push(v);
                        input = FillStack(s, input);
                    }
                }
            }
            input = FillStack(s, input);
            return input;
        }

        private static Stack<int> FillStack(Stack<int> src, Stack<int> dest)
        {
            if (src.Count == 0)
                return src;
            while (src.Count != 0)
            {
                int val = src.Pop();
                dest.Push(val);
            }
            return dest;
        }

        private static void Permutation(List<List<int>> l, List<int> prefix, int curr)
        {
            if (curr == l.Count)
            {
                foreach (int i in prefix)
                    Console.Write(i + " ");
                Console.WriteLine("");
                // prefix = new List<int>();
                return;
            }
            for (int i = curr; i < l.Count; i++)
            {
                for (int j = 0; j < l[curr].Count; j++)
                {
                    prefix.Add(l[curr][j]);
                    Permutation(l, prefix, curr + 1);

                    prefix.Remove(l[curr][j]);
                }
            }

        }
        private static void Permutation(List<List<int>> l)
        {
            Permutation(l, new List<int>(), 0);
        }

        private static void paren(string s, int target, int numLeft, int numRight, int targetLeft, int targetRight)
        {
            if (s.Length == target)
            {
                Console.Write(s);
                if (IsValid(s))
                    Console.WriteLine(" is valid");
                else
                    Console.WriteLine(" is not valid");
                return;
            }
            if (numRight < targetRight)
                paren(s + ')', target, numLeft, numRight + 1, targetLeft, targetRight);
            if (numLeft < targetLeft)
                paren(s + '(', target, numLeft + 1, numRight, targetLeft, targetRight);
        }

        private static bool IsValid(string combo)
        {
            Stack<char> s = new Stack<char>();
            foreach (char c in combo)
            {
                if (c == '(')
                    s.Push(c);
                else if (s.Count() > 0)
                    s.Pop();
            }
            return s.Count() == 0;
        }
        private static string convertinttoword(int num)
        {
            List<string> l = new List<string>();

            l.Add("zero");
            l.Add("one");
            l.Add("two");
            l.Add("three");
            l.Add("four");
            l.Add("five");
            l.Add("six");
            l.Add("seven");
            l.Add("eight");
            l.Add("nine");

            l.Add("ten");
            l.Add("eleven");
            l.Add("twelve");
            l.Add("thirteen");
            l.Add("fourteen");
            l.Add("fifteen");
            l.Add("sixteen");
            l.Add("seventeen");
            l.Add("eighteen");
            l.Add("nineteen");
            l.Add("twenty");
            l.Add("twenty one");
            l.Add("twenty two");
            l.Add("twenty three");
            l.Add("twenty four");
            l.Add("ninety nine");

            List<string> lookup = new List<string>();
            lookup.Add("hundred");
            lookup.Add("thousand");
            lookup.Add("hundred thousand");
            lookup.Add("million");
            lookup.Add("billion");

            if (num < 100)
                return l[num];
            int counter = 0, temp = 0;
            StringBuilder res = new StringBuilder();
            res.Append(" and " + l[num % 100]);
            num = num / 100;

            while (num > 0)
            {
                temp = num % 10;
                num /= 10;

                res.Insert(0, l[temp] + " ");
                res.Insert(l[temp].Length + 1, lookup[counter] + " ");
                counter++;
            }
            return res.ToString();
        }
        public static void BuildCP(List<List<char>> l)
        {
            StringBuilder s = new StringBuilder();
            BuildCP(l, 0, "");
        }
        public static void BuildCP(List<List<char>> l, int curr, string s)
        {
            if (curr >= l.Count)
                return;

            foreach (char c in l[curr])
            {
                s += c;
                //  Console.WriteLine("after append - " + s);
                BuildCP(l, curr + 1, s);
                if (s.Length == l.Count)
                    Console.WriteLine(s);
                s = RemoveChar(s, c);
            }
        }
        private static string RemoveChar(string s, char r)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == r)
                {
                    s = s.Substring(0, i) + s.Substring(i + 1);
                    return s;
                }
            }

            return "";
        }

        public static int lis(int[] A, int i)
        {
            if (i >= A.Length)
                return 0;
            if (i == A.Length - 1)
                return 1;
            int len = 0;

            len = Math.Max(len, lis(A, i + 1));

            if (A[i] < A[i + 1])
            {
                len++;
                Console.WriteLine(A[i + 1] + " length so far " + len);
            }
            return len;
        }
    }



}

