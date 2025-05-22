using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello :)");
            Graph graph = new Graph();
            graph.DepthFirstSearch();
            Console.WriteLine();
            Console.WriteLine();
            graph.BreadthFirstSearch();
            Console.ReadKey();
        }
    }
    public class Node
    {
        public char id { get; }
        public Node(char inID)
        {
            id = inID;
        }
    }
    public class Graph
    {
        private Dictionary<Node, List<Node>> adjList;
        private Node start;
        private Node end;
        public Graph()
        {
            adjList = new Dictionary<Node, List<Node>>();
            Initialise();
        }
        private void Initialise() //L177 slide 7
        {
            Node A = new Node('A');
            Node B = new Node('B');
            Node C = new Node('C');
            Node D = new Node('D');
            Node E = new Node('E');
            Node F = new Node('F');
            Node G = new Node('G');
            Node H = new Node('H');
            Node I = new Node('I');
            Node J = new Node('J');
            adjList.Add(A, new List<Node>() { B, D });
            adjList.Add(B, new List<Node>() { A, C });
            adjList.Add(C, new List<Node>() { B });
            adjList.Add(D, new List<Node>() { A, E });
            adjList.Add(E, new List<Node>() { D, F, G });
            adjList.Add(F, new List<Node>() { E });
            adjList.Add(G, new List<Node>() { E, H, I });
            adjList.Add(H, new List<Node>() { G });
            adjList.Add(I, new List<Node>() { G, J });
            adjList.Add(J, new List<Node>() { I });
            start = A;
            end = J;
        }
        public void DepthFirstSearch()
        {
            HashSet<Node> visited = new HashSet<Node>();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                visited.Add(current);
                List<Node> neighbours = adjList[current];
                Console.WriteLine($"At {current.id}");
                Console.Write("   Considering: ");
                foreach (Node neighbour in neighbours)
                {
                    if (!visited.Contains(neighbour))
                    {
                        Console.Write($"{neighbour.id}  ");
                        stack.Push(neighbour);
                    }
                }
                Console.WriteLine();
            }
        }
        public void BreadthFirstSearch()
        {
            HashSet<Node> visited = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();

        }

    }
}


