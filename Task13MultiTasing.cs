//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
		//Create appropriate methods.
		//Provide a simple text-based menu for the user to choose which task to solve.
		//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;

class Task13MultiTasing
{
    static void Reverse(string number)
    {
        char[] result = new char[number.Length];
        string output = "";

        for (int i = 0; i < number.Length; i++)
        {
            result[i] = number[number.Length - 1 - i];
            output += result[i];
        }
        Console.WriteLine(output);
    }

    static void CalcAverage(string number)
    {
        int sum = 0;
        byte[] digits = new byte[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            digits[i] = (byte)(number[i] - 48);
            sum = sum + digits[i];
        }
        decimal result = ((decimal)sum / number.Length);
        Console.Clear();
        Console.WriteLine("The average value of the sum of your digits is\"{0:0.00}\".", result);
    }

    static void LinearEquation()
    {
        Console.Clear();
        Console.WriteLine("Linear equation looks like \"a * x + b = c\"");
        Console.WriteLine("We are looking for \"X\"");
        Console.Write("Please, enter value for \"a\" : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter value for \"b\" : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please, enter value for \"c\" : ");
        int c = int.Parse(Console.ReadLine());
        decimal result = ((decimal)c - (decimal)b) / (decimal)a;
        Console.WriteLine("The root of your linear euqtion is : {0:0.00}.", result);
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter your number here : ");
        string theNumber = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("MENU : ");
        Console.WriteLine("1. Reverse digits in your number.");
        Console.WriteLine("2. Calculate average of a sequence of integers. We will use the digits \nof your number \"{0}\".", theNumber);
        Console.WriteLine("3. Solve a linear equation \"a * x + b = c\"");
        Console.WriteLine("================================================");
        Console.Write("Please, enter your choice here : ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                {
                    Reverse(theNumber);
                }
                break;
            case 2:
                {
                    CalcAverage(theNumber);
                }
                break;
            case 3:
                {
                    LinearEquation();
                }
                break;
            default: Console.WriteLine("Wrong inpur, restart the program, cuz I'm too lazy to use endless while cycle :)");
                break;
        }
    }
}

