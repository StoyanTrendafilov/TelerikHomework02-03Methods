//Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;

class Task06IdexReturn
{
    static int FindIndex(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i-1]) && (array[i] > array[i + 1]))
            {
                index = i;
                break;
            }
        }
        return index;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("We will generate an array with random length and random value of it's members.");

        Random rand = new Random();
        int n = rand.Next(4, 10);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(5, 100);
        }

        Console.WriteLine();
        Console.WriteLine("Your random generated array looks like this : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Position {0}: Value  {1}", i, arr[i]);
        }
        Console.WriteLine();

        int position = FindIndex(arr);
        Console.WriteLine("Wanted position : " + position);
    }
}

