


using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>()  ;
        
        for(int i = 0 ; i < 5 ;i++) {
            dict.Add(i, i*i);
            Console.WriteLine(dict[i]);
        }
        
        Dictionary<int , string> dict2 = new Dictionary<int, string>(){ {1,"one"} , {2,"Two"} };
        
        Console.WriteLine("\n");
        Console.WriteLine( "Value of dict2 at key = 1: "+  dict2[1] );
        Console.WriteLine( "Count: " +  dict.Count);

    }
}





