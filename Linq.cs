using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        var greaterThanFive = numbers.Where(num => num > 5);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nNumbers Greater Than Five:");
        foreach (var num in greaterThanFive)
        {
            Console.WriteLine(num);
        }
    }
}
