// Задача 52. В C# Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] arr = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        int n = arr.GetLength(0);
        int m = arr.GetLength(1);

        double[] averages = FindAverages(arr, n, m);

        ShowAverages(averages);

    double[] FindAverages(int[,] arr, int n, int m)
    {
        double[] averages = new double[m];
        for (int j = 0; j < m; j++)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i, j];

            averages[j] = sum / n;
        }

        return averages;
    }

     void ShowAverages(double[] averages)
    {
            foreach (double ave in averages)
            Console.Write("{0:F1}; ", ave);
    }