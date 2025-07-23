
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

    //reference type function
    static int fun(ref int num)
    {
        int sum = num + 1;
        return sum;
    }

    //out parameter
    static int fun2(int num, out int result)
    {
        result = num * num;
        return result;
    }

    //array as parameter
    static int arr(int[] arry)
    {
        for (int i = 0; i < arry.Length; i++)
        {
            arry[i] = 0;
        }

        return 0;
    }

    static void Main()
    {
        int x1 = 5;
        int a1 = fun(ref x1);
        Console.WriteLine(a1);

        int prod;
        Console.WriteLine(fun2(2, out prod));


        int[] b1 = { 1, 3, 6, 8, 9 };
        arr(b1);

        for (int i = 0; i < b1.Length; i++)
        {
            Console.WriteLine(b1[i]);
        }
        int[] myArray = { 2, 5, 3, 7, 4, 9 };

        PrintArray(myArray);
        FindSumofArray(myArray);
        MaxElement(myArray);
        ReverseArray(myArray);
    }


}