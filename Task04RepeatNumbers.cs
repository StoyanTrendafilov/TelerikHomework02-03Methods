//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


using System;
//using System.Collections.Generic;

class Task04RepeatNumbers
{
    static int CountRepeats(int[] array, int theNumber)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == theNumber)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("We will generate an array with random length and random members' value.");
        Console.WriteLine();
        Random rand = new Random();
        int n = rand.Next(4, 10);
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 15);
        }

        Console.Write("Please, enter the number, you want to check : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Your number is repeated in our random generated array {0} times!", CountRepeats(arr, number));
        Console.WriteLine();
        Console.WriteLine("And just for checkout look at the array below : ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

