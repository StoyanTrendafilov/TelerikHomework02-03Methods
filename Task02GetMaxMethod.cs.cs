//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


using System;

class Task02GetMaxMethod
{
    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else if (secondNum > firstNum)
        {
            return secondNum;
        }
        else
        {
            return firstNum;
        }
        
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter your first number here : ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Please, enter your second number here : ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Bigger of your two numbers is : " + GetMax(numberOne, numberTwo));
    }
}

