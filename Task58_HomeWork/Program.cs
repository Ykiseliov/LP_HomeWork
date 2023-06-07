//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

 int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };
        int[,] result = MatrixMultiplication(matrix1, matrix2);
        Console.WriteLine("Результирующая матрица будет:");
        PrintMatrix(result);
    

     int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
        return result;
    }
    
     void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }