// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int[,] arr = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        int n = arr.GetLength(0);
        int m = arr.GetLength(1);

        Console.Write("Введите номер строки: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int j = Convert.ToInt32(Console.ReadLine());

        int value = GetValue(arr, i, j);

        if (value != -1)
            Console.WriteLine("({0}, {1}): {2}", i, j, value);
        else
            Console.WriteLine($"{i},{j}->Такого числа в массиве нет");

    int GetValue(int[,] arr, int i, int j)
    {
        int n = arr.GetLength(0);
        int m = arr.GetLength(1);

        if (i >= 0 && i < n && j >= 0 && j < m)
        {
            return arr[i, j];
        }
        else
        {
            return -1;
        }
    }