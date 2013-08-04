using System;

class Task07ConvertDigitsOrder
{
    static void ReverseDigits(string number)
    {
        char[] result = new char[number.Length];
        string output = "";

        for (int i = 0; i < number.Length; i++)
        {
            result[i] = number[number.Length - 1 - i];
        }

        for (int i = 0; i < result.Length; i++)
        {
            output += result[i];
        }

        Console.WriteLine(output);
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter one number: ");
        string number = Console.ReadLine();
        ReverseDigits(number);

    }
}

