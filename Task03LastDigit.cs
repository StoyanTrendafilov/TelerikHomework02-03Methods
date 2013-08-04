//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


using System;

class Program
{
    static void ReturnDigit(int theDigit)
    {
        switch (theDigit)
        {
            case 0: Console.WriteLine("Zero");
                break;
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two"); 
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven");
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            default:
                break;
        }
    }


    static void Main(string[] args)
    {
        Console.Write("Please, enter your number here : ");
        int number = int.Parse(Console.ReadLine());
        int lastNumber = number % 10;
        Console.WriteLine(lastNumber);
        ReturnDigit(lastNumber);

    }
}

