using System;
using System.Collections.Generic; 


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
        
        List<int> l1 = new List<int>(){1,2,3,4,5,6,1,2,3,4,6,6,6};
        
        Dictionary<int, int> dict = new Dictionary<int, int>() ;
        
        foreach (int num in l1)
        {
            if (dict.ContainsKey(num))
            {
                dict[num] += 1; // Update the value of the existing key
            }
            else
            {
                dict.Add(num, 1); // Add a new key-value pair
            }
        }

        
        foreach( var ele in dict ){
    Console.WriteLine("Key: " + ele.Key + " Value: " + ele.Value);
        }
        
    }
}
