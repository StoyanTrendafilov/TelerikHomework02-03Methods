//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


// Please, dont calc the answer manually.
using System;
using System.Numerics;

class Task10NFact
{
    static BigInteger CalcFact(int n)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0} has Factorial {1}.", i, CalcFact(i));
        }
    }
}

