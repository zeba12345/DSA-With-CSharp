
using System;
class HelloWorld
{
    static void FindSumofArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine("Sum of array: " + sum);
    }


    static void MaxElement(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("Max element: " + max);
    }
    static void ReverseArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }



    static void Main()
    {

        int[] myArray = { 2, 5, 3, 7, 4, 9 };

        PrintArray(myArray);
        FindSumofArray(myArray);
        MaxElement(myArray);
        ReverseArray(myArray);
    }


}