using System;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Mensagem 1");
        queue.Enqueue("Mensagem 2");
        queue.Enqueue("Mensagem 3");

        queue.Dequeue();
        queue.Dequeue();

        queue.Enqueue("Mensagem 4");
        Console.WriteLine(queue.Peek());

        Console.WriteLine(queue.ToString());
    }
}

class Queue<T> {
    private List<T> items = new List<T>();

    public void Enqueue(T i) {
        items.Add(i);
    }

    public T Dequeue() {
        if (this.isEmpty()) {
            throw new InvalidOperationException("Fila vazia!");
        }

        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public bool isEmpty() {
        return items.Count == 0;
    }

    public T Peek() {
        if (this.isEmpty()) {
            throw new InvalidOperationException("Fila vazia!");
        }

        return items[0];
    }

    public int Count() {
        return items.Count;
    }

    public override string ToString() {
        return string.Join(", ", items);
    }
}
