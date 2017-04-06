using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ProgrammingProblems
{
    public class MyLinkedList
    {
        public void deleteDups(Node n)
        {
            Hashtable table = new Hashtable();
            Node previous = null;
            while (n != null)
            {
                if (table.ContainsKey(n.data))
                {
                    previous.next = n.next;
                }
                else
                {
                    table.Add(n.data, true);
                    previous = n;

                }
                n = n.next;
            }
        }

        public Node DeleteDupsAlternate(Node n)
        {
            Node current = n;
            Node runner = n;
            while (current != null)
            {
                while (runner.next != null)
                {
                    if (current.data == runner.next.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                        runner = runner.next;

                }
                current = current.next;
            }
            return n;
        }
        public Info KthToLast(Node n, int k)
        {
            if (n == null)
                return new Info { Nd = n, Counter = 0 };
            Info t = KthToLast(n.next, k);
            if (t.Counter + 1 == k)
            {
                return t;
            }
            t.Counter = t.Counter + 1;
            t.Nd = n;
            return t;

        }

        public bool deleteNode(Node n)
        {
            if (n == null || n.next == null)
                return false;
            Node next = n.next;
            n.data = next.data;
            n.next = next.next;
            return true;
        }
        public void partitionList(LinkedListNode<int> n, int x)
        {
            LinkedList<int> before = new LinkedList<int>();
            LinkedList<int> after = new LinkedList<int>();
            LinkedListNode<int> current = n;
            while (current != null)
            {
                if (current.Value > x)
                {
                   
                        after.AddLast(current.Value);
                }
                else if (current.Value < x)
                {
                    before.AddLast(current.Value);
                    
                }
                current = current.Next;
            }
                current = n;
            var it = before.GetEnumerator();
                while(it.MoveNext())
                {
                    int curr = it.Current;
                    current.Value = curr;
                    it.MoveNext();
                    current = current.Next;
                }
                current.Next.Value = x;
                it = after.GetEnumerator();
                while (it.MoveNext())
                {
                    int curr = it.Current;
                    current.Value = curr;
                    it.MoveNext();
                    current = current.Next;
                }
                while (n != null)
                {
                    Console.WriteLine(n.Value);
                    n = n.Next;
                }
            }
        }
    
    public class Info
    {
        Node nd;

        public Node Nd
        {
            get { return nd; }
            set { nd = value; }
        }
        int counter;

        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d, Node n)
        {
            this.data = d;
            this.next = n;
        }
    }
    public class LinkedList
    {
        Node[] nodes;
        int numberOfNodes;
        public const int MAX_NODES = 60;
        public LinkedList(Node head)
        {
            nodes = new Node[MAX_NODES];
            nodes[0] = head;
            numberOfNodes++;
        }
        public void AddNode(Node n)
        {
            this.nodes[numberOfNodes++] = n;
            
        }
        public void AddNodes(Node[] listOfNodes)
        {
            foreach (Node n in listOfNodes)
            {
                this.nodes[numberOfNodes] = n;
                numberOfNodes++;
            }
        }
        public Node Head
        {
            get
            {
                return nodes[0];
            }
        }
        //public void RemoveNode(Node n)
        //{
        //    for (int i = 0; i < numberOfNodes; i++)
        //    {
        //        if(n.data == nodes[i].data )
        //    }
        //}

    }
}
