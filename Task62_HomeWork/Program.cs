// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

    Console.Clear();
    {
        int[,] arr = new int[4, 4];
        FillSpiralArray(arr);
        PrintArray(arr);
    }

    static void FillSpiralArray(int[,] arr)
    {
        int num = 0;
        int n = arr.GetLength(0);
        int m = arr.GetLength(1);
        int row = 0;
        int col = 0;

        while (num < n * m)
        {
        
            for (int i = col; i < m - col && num < n * m; i++)
            {
                arr[row, i] = ++num;
            }

            for (int i = row + 1; i < n - row && num < n * m; i++)
            {
                arr[i, m - col - 1] = ++num;
            }

          
            for (int i = m - col - 2; i >= col && num < n * m; i--)
            {
                arr[n - row - 1, i] = ++num;
            }

          
            for (int i = n - row - 2; i > row && num < n * m; i--)
            {
                arr[i, col] = ++num;
            }

           
            row++;
            col++;
        }
    }

    static void PrintArray(int[,] arr)
    {
        int n = arr.GetLength(0);
        int m = arr.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{arr[i,j]:00} ");
            }
            Console.WriteLine();
        }
    }