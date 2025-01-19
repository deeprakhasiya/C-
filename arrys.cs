

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 2; 
            Console.WriteLine("Array Element: " + arr[i]); 
        }

        Console.WriteLine("Array Element at index 5: " + arr[5]);
        Console.WriteLine("Array Length: " + arr.Length);

    }
}

