using System;

class HelloWorld
{

    static void FindSumofArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum = " + sum);
    }

    static void MaxElement(int[] arr)
    {
        int max = arr[0];
        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[j] > max)
            {
                max = arr[j];
            }
        }
        Console.WriteLine("Max = " + max);
    }

    static void Main()
    {
        int[] arr = { 2, 5, 3, 7, 4, 9 };
        FindSumofArray(arr);
        MaxElement(arr);
    }
}
