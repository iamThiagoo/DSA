public class Program {
    public static void Main(string[] args) {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();

        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddLast(4);
        list.AddLast(5);

        Console.WriteLine(list.PrintList());
        Console.WriteLine(list.PrintListReverse());
    }
}

public class DoublyLinkedList<T> {

    public class Node {
        public T value;
        public Node? next;
        public Node? previous;

        public Node(T value) {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }

    private Node? firstNode;
    private Node? lastNode;

    public DoublyLinkedList() {
        this.firstNode = null;
        this.lastNode = null;
    }

    public void AddFirst(T value) {
        Node newNode = new Node(value);

        if (this.isEmpty()) {
            this.firstNode = newNode;
            this.lastNode = newNode;
        } else {
            newNode.next = this.firstNode;
            this.firstNode!.previous = newNode;
            this.firstNode = newNode;
        }
    }

    public void AddLast(T value) {
        Node newNode = new Node(value);

        if (this.isEmpty()) {
            this.firstNode = newNode;
            this.lastNode = newNode;
        } else {
            newNode.previous = this.lastNode;
            this.lastNode!.next = newNode;
            this.lastNode = newNode;
        }
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

    public bool isEmpty() {
        return this.firstNode == null;
    }

    public string PrintList() {
        return this.ToString();
    }

    public string PrintListReverse() {
        Node? current = this.lastNode;
        string result = "";

        while (current != null) {
            result += current.value + ", ";
            current = current.previous;
        }

        return result.TrimEnd(',', ' ');
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
