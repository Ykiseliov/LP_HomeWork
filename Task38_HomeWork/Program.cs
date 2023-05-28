// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = new double[] { 3.5, 7.1, 22.9, 2.3, 78.5}; // задаем массив 
double diff = GetDiffMinMax(arr); 

// Вывод
Console.Write($"[{string.Join(", ", arr)}]-> {diff}");

static double GetDiffMinMax(double[] arr) 
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++) // находим мин и мак эл-ты
        {
            if (arr[i] < min) 
            {
                 min = arr[i];
            }
        if (arr[i] > max) 
            {
                max = arr[i];
            }
        }

        // вычисляем разницу между мин и макc эл-ми
        double diff = max - min;
        return diff;
}