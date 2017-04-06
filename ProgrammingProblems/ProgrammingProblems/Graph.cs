using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    public class Graph
    {
        private List<int>[] nodes;
        private int numberOfVertices;
        private bool isDirected;
        private int[]  entry_time, exit_time, parent;
        private bool[] discovered, processed;
        public enum State{
            Unvisited,
            Visiting,
            Visited
        }
        public Graph(int v, bool isDir)
        {
            nodes = new List<int>[v+1];
            for (int i = 0; i <= v; i++)
                nodes[i] = new List<int>();
           numberOfVertices=v;
            isDirected = isDir;
        }
        public void AddEdge(int s, int e)
        {
            nodes[s].Add(e);
        }
        public void RemoveEdge(int s, int e)
        {
            nodes[s].Remove(e);
        }
        public int GetNumberOfVertices()
        {
            return nodes.Length;
        }
        public void Initialize_DFS()
        {
            discovered = new bool[numberOfVertices+1];
            processed = new bool[numberOfVertices+1];
            entry_time = new int[numberOfVertices+1];
            exit_time = new int[numberOfVertices+1];
            parent = new int[numberOfVertices+1];
        }
        public void DFS(int v)
        {
            int tempVertex = 0, time = 0, counter = 0;
            discovered[v] = true;
            Console.WriteLine("discovered " + v);
            time++;
            entry_time[v] = time;
            List<int> neighbors = nodes[v];
            while (counter < neighbors.Count())
            {
                tempVertex = neighbors[counter];
                if (!discovered[tempVertex])
                {
                    parent[tempVertex] = v;
                    //processedge(v,tempvertext)
                    DFS(tempVertex);
                }
                else if (!processed[tempVertex] || isDirected)
                {
                   //process edge(v,tempvertext)
                }
                counter += 1;
                //process vertext late(v)
                processed[v] = true;
                Console.Write("processed " + v);
                Console.WriteLine();
                time++;
                exit_time[v] = time;
            }
        }
       
    }
}
