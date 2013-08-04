//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

//fot the solution of this task we will use an random array if integers with random values of it's members :)
// othewise it is too long and i am too lazy. 

using System;

class Task14UsingVarArgs
{
    static void GetMaxValue(params int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("The biggest arguement in your set is : {0}.", max);
    }

    static void GetMinValue(params int[] arr)
    {
        int min = int.MaxValue;
        foreach (int value in arr)
        {
            if (value < min)
            {
                min = value;
            }
        }
        Console.WriteLine("The smallest arguement int your set is : {0}.", min);
    }

    static void GetAverageValue(params int[] arr)
    {
        int sum = 0;
        foreach (int value in arr)
        {
            sum += value;
        }
        float average = (float)sum / (float)arr.Length;
        Console.WriteLine("The average value of your set is : {0:0.00}.", average); ;
    }

    static void GetSum(params int[] arr)
    {
        int sum = 0;
        foreach (int value in arr)
        {
            sum += value;
        }
        Console.WriteLine("The sum of your set is : {0}.", sum); ;
    }

    static void GetProduct(params int[] arr)
    {
        int product = 1;
        foreach (int value in arr)
        {
            product *= value;
        }
        Console.WriteLine("The product of the members of your set is : {0}.", product); ;
    }

    

    static void Main(string[] args)
    {
        /*
         * if you uncomment the section below, you can generate random array with random value of it's members, so you won't have
         * to enter values manually. I have put it like a comment, just do follow the excersise. 
        Random rand = new Random();
        int n = rand.Next(4, 10);
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(5, 100);
        }
         */

        GetMaxValue(1, 2, 3, 4, 7, 1);
        GetMinValue(3, 5, 1, 9, 10000, -3);
        GetAverageValue(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        GetSum(19, 3123, 12314, 543, 123123, 1234);
        GetProduct(2, 3, 432, 2); // if we use too big numbers, we will get exception 
        Console.WriteLine("CONGRATULATIONS ! ");
    }
}

