//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.


using System;

class Task08AddDigits
{
    static byte[] ConvertStringToByteArray(string number)
    {
        byte[] num = new byte[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            num[i] = (byte)(number[number.Length - i - 1] - 48);
        }
        return num;
    }

    static void Sum(byte[] firstNum, byte[] secondNum, int lengthM)
    {
       
        int[] ending = new int[lengthM];
        string finalSum = "";
        bool passed = false;

        if (firstNum.Length > secondNum.Length)
        {
            int result = 0;
            for (int i = 0; i < secondNum.Length; i++)
            {
                result = firstNum[i] + secondNum[i];
                if (result > 10)
                {
                    result = result % 10;
                    passed = true;
                }
                if (passed)
                {
                    firstNum[i + 1] += 1;
                }
                ending[i] = result;
            }
            for (int i = secondNum.Length; i < firstNum.Length; i++)
            {
                result = firstNum[i];
                ending[i] = result;
            }
        }
        else if (secondNum.Length > firstNum.Length)
        {
            int result = 0;
            for (int i = 0; i < firstNum.Length; i++)
            {
                result = firstNum[i] + secondNum[i];
                if (result > 10)
                {
                    result = result % 10;
                    passed = true;
                }
                if (passed)
                {
                    secondNum[i + 1] += 1;
                }
                ending[i] = result;
            }
            for (int i = firstNum.Length; i < secondNum.Length; i++)
            {
                result = secondNum[i];
                ending[i] = result;
            }
        }
        else if (firstNum.Length == secondNum.Length)
        {
            int result = 0;
            for (int i = 0; i < secondNum.Length; i++)
            {
                result = (firstNum[i] + secondNum[i]);
                if (result > 10 && i + 1 != secondNum.Length)
                {
                    result = (result % 10);
                    passed = true;
                }
                if (passed && i + 1 < secondNum.Length)
                {
                    firstNum[i + 1] = Convert.ToByte(firstNum[i + 1] + 1);
                }
                ending[i] = result;
            }
        }


        
        
        finalSum = "";
        for (int i = ending.Length - 1; i >= 0; i--)
        {
            finalSum = finalSum + ending[i];
        }

        Console.WriteLine(finalSum);
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter first number : ");
        string number1 = Console.ReadLine();
        byte[] num1 = ConvertStringToByteArray(number1);

        Console.Write("Please, etner the second number : ");
        string number2 = Console.ReadLine();
        byte[] num2 = ConvertStringToByteArray(number2);

        int length = num1.Length;
        if (num2.Length > num1.Length)
        {
            length = num2.Length;
        }

        Sum(num1, num2, length);
    }
}

