//Extend the program to support also subtraction and multiplication of polynomials.


using System;

class Task12Task11WithAdditions
{
    static int[] GiveValueToPolinomMembers(int[] polinom)
    {
        for (int i = 0; i < polinom.Length; i++)
        {
            Console.Write("\"{0}\"*X^{1} : ", 0, i);
            Console.Write("Please, enter the value of your first \"0\" here : ");
            polinom[i] = int.Parse(Console.ReadLine());
        }
        return polinom;
    }

    static int[] MultiplyPolinom(int[] polinom1, int[] polinom2)
    {
        int[] multiplied = new int[polinom1.Length];
        for (int i = 0; i < polinom1.Length; i++)
        {
            multiplied[i] = polinom1[i] * polinom2[i];
        }
        return multiplied;
    }

    static int[] SubstractPolinoms(int[] polinom1, int[] polinom2)
    {
        int[] substracted = new int[polinom1.Length];
        for (int i = 0; i < polinom1.Length; i++)
        {
            substracted[i] = polinom1[i] - polinom2[i];
        }
        return substracted;
    }

    static int[] SumPolinoms(int[] polinom1, int[] polinom2)
    {
        int [] summed = new int [polinom1.Length];
        for (int i = 0; i < polinom1.Length; i++)
		{
            summed[i] = polinom1[i] + polinom2[i];
		}
        return summed;
    }

    static void PrintPolinom(int[] polinom)
    {
        Console.WriteLine("The new polinom is {0}*x^2 + {1}*x^1 + {2}*x^0 = 0.", polinom[2], polinom[1], polinom[0]);
    }

    static void Main(string[] args)
    {
        int[] firstPolinom = new int[3];
        int[] secondPolinom = new int[3];
        int[] sum = new int[3];
        int[] multiplied = new int[3];
        int[] substracted = new int[3];

        firstPolinom = GiveValueToPolinomMembers(firstPolinom);
        secondPolinom = GiveValueToPolinomMembers(secondPolinom);

        sum = SumPolinoms(firstPolinom, secondPolinom);
        multiplied = MultiplyPolinom(firstPolinom, secondPolinom);
        substracted = SubstractPolinoms(firstPolinom, secondPolinom);

        Console.Write("Multiplied polinom : ");
        PrintPolinom(multiplied);
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

        Console.Write("Summed polinoms : ");
        PrintPolinom(sum);
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

        Console.Write("Substracted polinoms : ");
        PrintPolinom(substracted);
        Console.WriteLine();
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("That's all, folks ! :)" );
    }
}

