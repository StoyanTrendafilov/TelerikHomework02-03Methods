//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 


using System;

class Task11Polynomials
{
    static int[] SumPolinom(int[] pol1, int[] pol2)
    {
        int[] sum = new int[pol1.Length];
        for (int i = 0; i < pol1.Length; i++)
        {
            sum[i] = pol1[i] + pol2[i];
        }
        return sum;
    }

    static void PrintNewPolinom(int[] array)
    {
        Console.WriteLine("The new polinom is {0}*x^2 + {1}*x^1 + {2}*x^0 = 0.", array[2], array[1], array[0]);
    }

    static int[] GiveValueToPolinom(int[] polinom)
    {
        for (int i = 0; i < polinom.Length; i++)
		{
            Console.WriteLine("\"{0}\"*X^{1} : ", 0 , i);
            Console.Write("Please, enter value for \"0\" in here : ");
            polinom[i] = int.Parse(Console.ReadLine());
		}
        return polinom;
    }

    static void Main(string[] args)
    {
        int[] polinom1 = new int[3];
        int[] polinom2 = new int[3];
        int[] sum = new int[3];

        polinom1 = GiveValueToPolinom(polinom1);
        polinom2 = GiveValueToPolinom(polinom2);

        sum = SumPolinom(polinom1, polinom2);

        PrintNewPolinom(sum);

    }
}

