using System;
using System.Collections.Generic;
using System.Collections;
namespace BFS
{
  
    class Program
    {
        public static void DFS(Dictionary<int, List<int>> graph, int start)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> seen = new HashSet<int>();
            stack.Push(start);
            seen.Add(start);
            while (stack.Count > 0)
            {
                int vertex = stack.Pop();
                List<int> nodes = graph[vertex];
                foreach (var x in nodes)
                {
                    if (!seen.Contains(x))
                    {
                        stack.Push(x);
                        seen.Add(x);
                    }
                }
                Console.WriteLine(vertex);
            }
        }
      
        public static void BFS(Dictionary<int, List<int>> graph, int start)
        {
            Queue<int> queue = new Queue<int>(); //коллекция для обхода графа
            HashSet<int> seen = new HashSet<int>();//посещенные вершины
            queue.Enqueue(start); //помещаем в очередь
            seen.Add(start);
            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();//вытаскиваем из очереди
                List<int> nodes = graph[vertex]; 
                foreach (var x in nodes)
                {
                    if (!seen.Contains(x))
                    {
                        queue.Enqueue(x);
                        seen.Add(x);
                    }
                }
                Console.WriteLine(vertex);
            }
        }
        static void Main(string[] args)
        {
            
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>()
            {
                [1] = new List<int>() { 2, 3 },
                [2] = new List<int>() { 1, 3, 4 },
                [3] = new List<int>() { 1, 2, 4, 5 },
                [4] = new List<int>() { 2, 3, 5, 6 },
                [5] = new List<int>() { 3, 4 },
                [6] = new List<int>() { 4 },
            };
            BFS(graph, 6);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i*j);
                }
            }
        }
    }
}
