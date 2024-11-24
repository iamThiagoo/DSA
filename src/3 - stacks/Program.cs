using System;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        stack.Pop();

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.ToString());
    }
}

public class Stack<T> {
    private List<T> items = new List<T>();

    public void Push(T item) {
        items.Add(item);
    }

    public T Pop() {
        if (this.isEmpty()) {
            throw new InvalidOperationException("Pilha vazia!");
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public T Peek() {
        if (this.isEmpty()) {
            throw new InvalidOperationException("Pilha vazia!");
        }

        return items[items.Count - 1];
    }

    public bool isEmpty() {
        return items.Count == 0;
    }

    public int Count() {
        return items.Count;
    }

    public override string ToString() {
        return string.Join(", ", items);
    }
}