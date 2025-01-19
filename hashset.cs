


using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
        HashSet<int> set = new HashSet<int> ();

        for(int i = 0 ; i < 5 ; i++){
            set.Add(i);
        }
        
        set.Add(1);
        set.Add(2) ;
        
        foreach(int i in set ){
            Console.WriteLine(i);
        }
        
        Console.WriteLine(set.Contains(2)); 

        set.Remove(1);
        Console.WriteLine(set.Contains(1)); 
      
        HashSet<int> otherSet = new HashSet<int> { 30, 40, 50 };
        set.UnionWith(otherSet); 
        
        foreach(int i in set ){
            Console.WriteLine(i);
        }

    }
}





