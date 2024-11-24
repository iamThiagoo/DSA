using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinkedList<int> list = new CircularLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine(list.ToString());

        list.Remove(2);
        Console.WriteLine(list.ToString());

        Console.WriteLine(list.Search(1));
        Console.WriteLine(list.Search(2));

        Console.WriteLine(list.Count());

        list.Rotate();
        Console.WriteLine(list.ToString());
    }
}

public class CircularLinkedList<T>
{

    public class Node
    {
        public T value;
        public Node? next;

        public Node(T value) {
            this.value = value;
            this.next = null;
        }
    }

    private Node? lastNode;

    public CircularLinkedList()
    {
        this.lastNode = null;
    }

    public void Add(T value)
    {
        Node newNode = new Node(value);

        if (this.isEmpty()) {
            newNode.next = newNode;
            this.lastNode = newNode;
        }
        else {
            newNode.next = this.lastNode!.next;
            this.lastNode!.next = newNode;
            this.lastNode = newNode;
        }
    }

    public bool Remove(T value)
    {
        if (this.isEmpty()) {
            return false;
        }

        Node? current = this.lastNode!.next;
        Node? previous = this.lastNode;

        do {
            if (current != null && current.value!.Equals(value)) {
                if (current == current.next) {
                    this.lastNode = null;
                }
                else
                {
                    previous!.next = current.next;
                    if (current == this.lastNode) {
                        this.lastNode = previous;
                    }
                }
                return true;
            }

            previous = current;
            current = current?.next;
        } while (current != null && current != this.lastNode!.next);

        return false;
    }

    public bool Search(T value) {
        if (this.isEmpty()) {
            return false;
        }

        Node? current = this.lastNode!.next;

        do {
            if (current != null && current.value!.Equals(value)) {
                return true;
            }
            current = current?.next;
        } while (current != null && current != this.lastNode!.next);

        return false;
    }

    public int Count() {
        if (this.isEmpty()) {
            return 0;
        }

        int count = 1;
        Node? current = this.lastNode!.next;

        while (current != this.lastNode) {
            count++;
            current = current?.next;
        }

        return count;
    }

    public bool isEmpty() {
        return this.lastNode == null;
    }

    public void Rotate() {
        if (this.isEmpty()) {
            return;
        }

        this.lastNode = this.lastNode!.next;
    }

    public override string ToString() {
        if (this.isEmpty()) {
            return "[]";
        }

        Node? current = this.lastNode!.next;
        string result = "[";

        do {
            if (current != null) {
                result += current.value;
                current = current.next;

                if (current != this.lastNode!.next) {
                    result += ", ";
                }
            }
        } while (current != null && current != this.lastNode!.next);

        result += "]";
        return result;
    }
}