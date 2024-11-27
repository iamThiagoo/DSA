using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        BinaryTree tree = new BinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(80);
        tree.Insert(40);

        tree.InOrderRecursive();
        Console.WriteLine(tree.PrintTree());

    }
}

class BinaryTree {

    class Node {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value) {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    private Node? root;

    public BinaryTree() {
        root = null;
    }

    public void Insert(int value) {
        root = InsertRecursive(root, value);
    }

    private Node InsertRecursive(Node? root, int value) {
        if (root == null) {
            return new Node(value);
        }

        if (value < root.Value) {
            root.Left = InsertRecursive(root.Left, value);
        } else {
            root.Right = InsertRecursive(root.Right, value);
        }

        return root;
    }

    public void InOrderRecursive() {
        InOrderRecursiveHelper(root);
    }

    private void InOrderRecursiveHelper(Node? root) {
        if (root != null) {
            InOrderRecursiveHelper(root.Left);
            Console.WriteLine(root.Value);
            InOrderRecursiveHelper(root.Right);
        }
    }

    public bool Search(int value) {
        return SearchRecursive(root, value);
    }

    private bool SearchRecursive(Node? root, int value) {
        if (root == null || root.Value == value) {
            return root != null;
        }

        if (value < root.Value) {
            return SearchRecursive(root.Left, value);
        }

        return SearchRecursive(root.Right, value);
    }

    public string PrintTree() {
        return PrintTreeRecursive(root);
    }

    private string PrintTreeRecursive(Node? root) {
        if (root == null) {
            return "";
        }

        return root.Value + " " + PrintTreeRecursive(root.Left) + PrintTreeRecursive(root.Right);
    }
}