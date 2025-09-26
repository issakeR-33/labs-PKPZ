using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int n; // кількість рядків
        Console.Write("Enter number of rows: ");
        n = int.Parse(Console.ReadLine());

        // Задаємо інтервал
        int minVal = -10;
        int maxVal = 10;

        // 1. Створення зубчастого масиву
        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            int rowLength = rnd.Next(3, 8); // випадкова довжина рядка від 3 до 7
            jaggedArray[i] = new int[rowLength];
            for (int j = 0; j < rowLength; j++)
            {
                jaggedArray[i][j] = rnd.Next(-20, 21); // заповнюємо числами від -20 до 20
            }
        }

        // Вивід початкового масиву
        Console.WriteLine("\nInitial jagged array:");
        for (int i = 0; i < n; i++)
        {
            foreach (var x in jaggedArray[i])
                Console.Write($"{x,4}");
            Console.WriteLine();
        }

        // 2. Обчислення сум елементів, що не потрапляють в інтервал
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

        // Вивід результату
        Console.WriteLine("\nSum of elements outside interval for each row:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Row {i + 1}: {sumArray[i]}");
        }
    }
}
