// Задача 56: Задайте прямоугольный двумерный массив. 
// апишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] arr = new int[,] { { 1, 4, 7, 2 },{ 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

PrintArray(arr);

int minSumRow = FindMinSumRow(arr);
            
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minSumRow + 1}");

int FindMinSumRow(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRow = 0;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += arr[i, j];
            }
            if (rowSum < minSum)
            {
            minSum = rowSum;
            minSumRow = i;
            }
    }
    return minSumRow;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}