using System;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Deep";
        person1.Age = 22;
        person1.Introduce();
    }
}
