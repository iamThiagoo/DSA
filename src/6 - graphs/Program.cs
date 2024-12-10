using System;
using System.Collections.Generic;

public class Program {

    public static void Main(string[] args) {
        int vertices = 5;

        Graph graph = new Graph(vertices);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);

        graph.Print();
    }

}


class Graph {
    private List<List<int>> adjacency;

    public Graph(int numberOfVertices) {
        adjacency = new List<List<int>>(numberOfVertices);
        for (int i = 0; i < numberOfVertices; i++) {
            adjacency.Add(new List<int>());
        }
    }

    public void AddEdge(int source, int destination) {
        adjacency[source].Add(destination);
        adjacency[destination].Add(source);
    }

    public void RemoveEdge(int source, int destination) {
        adjacency[source].Remove(destination);
        adjacency[destination].Remove(source);
    }

    public void AddVertex() {
        adjacency.Add(new List<int>());
    }

    public void RemoveVertex(int vertex) {
        foreach (var list in adjacency) {
            list.Remove(vertex);
        }

        adjacency.RemoveAt(vertex);
        for (int i = 0; i < adjacency.Count; i++) {
            adjacency[i] = adjacency[i].Select(v => v > vertex ? v - 1 : v).ToList();
        }
    }

    public bool HasEdge(int source, int destination) {
        return adjacency[source].Contains(destination);
    }

    public void DepthFirstSearch(int startVertex, HashSet<int> visited = null)  {
        if (visited == null) {
            visited = new HashSet<int>();
        }

        Console.WriteLine(startVertex);
        visited.Add(startVertex);

        foreach (var neighbor in adjacency[startVertex]) {
            if (!visited.Contains(neighbor)) {
                DepthFirstSearch(neighbor, visited);
            }
        }
    }

    public void BreadthFirstSearch(int startVertex) {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();

        queue.Enqueue(startVertex);
        visited.Add(startVertex);

        while (queue.Count > 0) {
            int currentVertex = queue.Dequeue();
            Console.WriteLine(currentVertex);

            foreach (var neighbor in adjacency[currentVertex]) {
                if (!visited.Contains(neighbor)) {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    public void Print() {
        for (int i = 0; i < adjacency.Count; i++) {
            Console.Write($"V {i}: ");
            foreach (var neighbor in adjacency[i]) {
                Console.Write($"{neighbor} ");
            }
            
            Console.WriteLine();
        }
    }
}
