

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>() { "1", "2", "3" };
        list.Add("4"); 

        Console.WriteLine("\nList Elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item); 
        }
        
        Console.WriteLine(list[2]);
        Console.WriteLine(list.Count);
    }
}

