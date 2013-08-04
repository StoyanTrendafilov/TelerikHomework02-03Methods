//Write a method that checks if the element at given position in given array of integers 
//is bigger than its two neighbors (when such exist).


using System;
using System.Collections.Generic;

class Task05CheckNeighbours
{
    static void CheckNeighbours(int position, int[] array)
    {
        if (position > 0 && position < array.Length - 1)
        {
            if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
            {
                Console.WriteLine("The number at you position is bigger than its both neigbours!");
            }
            else if ((array[position] > array[position - 1]) && (array[position] <= array[position + 1]))
            {
                Console.WriteLine("The number at your position is bigger only than previous member of your array!");
            }
             else if ((array[position] <= array[position - 1]) && (array[position] > array[position + 1]))
            {
                Console.WriteLine("The number at your position is bigger only than next member of your array!");
            }
            else if ((array[position] == array[position - 1]) && (array[position] == array[position + 1]))
            {
                Console.WriteLine("Three of them are equal");
            }
            else
            {
                Console.WriteLine("Your number is smaller than both it's membersb !");
            }  
        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("The first array's member is bigger than second");
            }
            else
            {
                Console.WriteLine("The first array's member is not bigger than second.");
            }
        }
        else if (position == array.Length - 1)
        {
            if (array[position] > array[position - 1])
            {
                Console.WriteLine("The last array's member is bigger than previous one.");
            }
            else
            {
                Console.WriteLine("The last array's member is not bigger than previous one.");
            }
        }
        else
        {
            Console.WriteLine("You have entered invalid index. Try again.");
        }
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("We will generate an array with random length and random value of it's members.");
        Random rand = new Random();
        int n = rand.Next(6, 10);
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(5, 100);
        }
        Console.WriteLine();
        Console.WriteLine("Your random generated array looks like this : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Position {0}: Value  {1}", i , arr[i]);
        }
        Console.WriteLine();
        Console.Write("Please, enter the position of the array member, you are interested in : ");
        int pos = int.Parse(Console.ReadLine());
        
        CheckNeighbours(pos, arr);


    }
}

