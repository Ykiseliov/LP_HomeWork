﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Kол-во строк: "); //m
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во столбцов: "); //n
int n = Convert.ToInt32(Console.ReadLine());

double[,] CrtMtrxRndDbl(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()* 20 - 10, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine(); 
    }
}

double[,] array2d = CrtMtrxRndDbl(m, n);
PrintMatrix(array2d);