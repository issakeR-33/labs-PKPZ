using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int n;
        Console.Write("Enter number of rows: ");
        n = int.Parse(Console.ReadLine());

        // interval
        int minVal = -10;
        int maxVal = 10;

        //  зубчастий масив
        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            int rowLength = rnd.Next(3, 8); 
            jaggedArray[i] = new int[rowLength];
            for (int j = 0; j < rowLength; j++)
            {
                jaggedArray[i][j] = rnd.Next(-20, 21); 
            }
        }

        Console.WriteLine("\nInitial jagged array:");
        for (int i = 0; i < n; i++)
        {
            foreach (var x in jaggedArray[i])
                Console.Write($"{x,4}");
            Console.WriteLine();
        }

        // не потрапл.
        int[] sumArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            foreach (var x in jaggedArray[i])
            {
                if (x < minVal || x > maxVal)
                    sum += x;
            }
            sumArray[i] = sum;
        }

        Console.WriteLine("\nSum of elements outside interval for each row:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Row {i + 1}: {sumArray[i]}");
        }
    }
}
