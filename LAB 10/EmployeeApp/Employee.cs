using System;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
