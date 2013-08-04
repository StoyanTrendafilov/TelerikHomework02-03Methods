//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).


using System;
using System.Collections.Generic;

class Program
{
    static T GetMax<T>(params T[] arr)
    {
        dynamic max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static T GetMin<T>(params T[] arr)
    {
        dynamic min = arr[0];
        foreach (T value in arr)
        {
            if (value < min)
            {
                min = value;
            }
        }
        return min;
    }

    static T GetProduct<T>(params T[] arr)
    {
        dynamic product = 1;
        foreach (T value in arr)
        {
            product *= value;
        }
        return product;
    }

    static T GetSum<T>(params T[] arr)
    {
        dynamic sum = 0;
        foreach (T value in arr)
        {
            sum += value;
        }
        return sum;
    }

    static double GetAverage<T>(params T[] arr)
    {
        return Convert.ToDouble(GetSum(arr)) / arr.Length;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("If we use GetMax<T> for numbers 1, 2, 3, 4, 5.5, 10 we will get : " + GetMax(1, 2, 3, 4, 5.5, 10));
        Console.WriteLine("If we use GetMin<T> for numbers 1, 2, 3, 4, 5.5, 10 we will get : " + GetMin(1, 2, 3, 4, 5.5, 10));
        Console.WriteLine("If we use GetProduct<T> for numbers 1, 2, 3, 4, 5.5, 10 we will get : " + GetProduct(1, 2, 3, 4, 5.5, 10));
        Console.WriteLine("If we use GetSum<T> for numbers 1, 2, 3, 4, 5.5, 10 we will get : " + GetSum(1, 2, 3, 4, 5.5, 10));
        Console.WriteLine("If we use GetAverage<T> for numbers 1, 2, 3, 4, 5.5, 10 we will get : " + GetAverage(1, 2, 3, 4, 5.5, 10));

    }
}
