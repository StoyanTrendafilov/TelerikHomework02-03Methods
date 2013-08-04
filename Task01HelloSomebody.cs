//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.


using System;

class Task01HelloSomebody
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0} !", name);
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter some name here : ");
        string theName = Console.ReadLine();
        PrintName(theName);
    }
}

