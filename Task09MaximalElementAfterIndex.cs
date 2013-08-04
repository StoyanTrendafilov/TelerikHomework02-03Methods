//Write a method that return the maximal element in a portion of array of 
//integers starting at given index. Using it write another method that sorts an array in ascending / descending order.


using System;

class Task09MaximalElementAfterIndex
{
    static int FindMaxValueIndex(int index, int[] array)
    {
        int max = int.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int [] SortArray (int [] array)
    {
        Array.Sort(array);
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static void Main(string[] args)
    {
        Random rand = new Random();
        Console.WriteLine("We will generate an array with random size and element's value.");
        int n = rand.Next(4, 10);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(5, 100);
        }
        Console.WriteLine();
        Console.WriteLine("And your random generated array looks like : ");
        PrintArray(arr);
        Console.Write("Please, enter the wanted index here(start counting from zero) : ");
        int ind = int.Parse(Console.ReadLine());
        Console.WriteLine("The max value after array's member on position {0} is {1}.", ind, FindMaxValueIndex(ind, arr));
        Console.WriteLine();
        arr = SortArray(arr);
        Console.WriteLine("Sorted array here : ");
        PrintArray(arr);

    }
}

