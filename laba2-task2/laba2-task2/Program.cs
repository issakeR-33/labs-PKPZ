using System;

class Program
{
    static void Main()
    {
        int n = 7;
        int[,] A = new int[n, n];
        Random rnd = new Random();

        // create matrix
        Console.WriteLine("Initial matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = rnd.Next(-50, 50); // -50 ... +49
                Console.Write($"{A[i, j],4}");
            }
            Console.WriteLine();
        }

        // min element
        int minValue = A[0, 0];
        int minCol = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] < minValue)
                {
                    minValue = A[i, j];
                    minCol = j;
                }
            }
        }

        // print min element and its column
        Console.WriteLine($"\nMinimum element: {minValue}, column: {minCol + 1}");

   
        int[,] B = new int[n, n]; // new matrix 
        for (int j = 0; j < n; j++)
        {
            int newCol = (j - minCol + n) % n;
            for (int i = 0; i < n; i++)
            {
                B[i, newCol] = A[i, j];
            }
        }

        // Print result matrix
        Console.WriteLine("\nMatrix after swap column :");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{B[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
