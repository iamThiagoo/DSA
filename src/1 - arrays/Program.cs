using System;

public class Program 
{
    public static void Main(string[] args) 
    {
        // Static array
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        // Dynamic array
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Print array
        Console.WriteLine("Static array: " + string.Join(", ", array));
        Console.WriteLine("Dynamic array: " + string.Join(", ", list));
    }
}

