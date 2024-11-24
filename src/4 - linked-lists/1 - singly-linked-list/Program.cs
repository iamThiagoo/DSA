using System;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();

        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddLast(4);
        list.AddLast(5);
        list.AddFirst(50);

        Console.WriteLine(list.ToString());

        Console.WriteLine(list.Search(65).ToString());
        Console.WriteLine(list.Search(50).ToString());
    }
}

public class SinglyLinkedList<T> {

    public class Node {
        public T value;
        public Node? next;

        public Node(T value) {
            this.value = value;
            this.next = null;
        }
    }

    private Node? firstNode;

    public SinglyLinkedList() {
        this.firstNode = null;
    }

    public void AddFirst(T value) {
        Node newNode = new Node(value);
        newNode.next = this.firstNode;
        this.firstNode = newNode;
    }

    public void AddLast(T value) {
        Node newNode = new Node(value);

        if (this.firstNode == null) {
            this.firstNode = newNode;
            return;
        }

        Node current = this.firstNode;
        while (current.next != null) {
            current = current.next;
        }

        current.next = newNode;
    }

    public bool Search(T value) {
        Node? current = this.firstNode;

        while (current != null) {
            if (current.value!.Equals(value)) {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public int Count() {
        int count = 0;
        Node? current = this.firstNode;
        while (current != null) {
            count++;
            current = current.next;
        }
        return count;
    }

    public bool IsEmpty() {
        return this.firstNode == null;
    }

    public override string ToString() {
        Node? current = this.firstNode;
        string result = "";

        while (current != null) {
            result += current.value + ", ";
            current = current.next;
        }
        return result.TrimEnd(',', ' ');
    }
}