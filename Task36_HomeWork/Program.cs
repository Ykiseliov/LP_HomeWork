// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[4];
Random randNum = new Random(); // генерируем массив из  случайных чисел от 0 до 99
for (int i = 0; i < 4; i++) 
    {
        arr[i] = randNum.Next(100);
    }
        
//вызываем метод
int sum = GetSumOnOddPositions(arr);

Console.Write($"[{string.Join(", ", arr)}]-> {sum}");

// находим сумму элементов, стоящих на нечётных позициях
static int GetSumOnOddPositions(int[] arr) 
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) 
    {
        sum += arr[i];
    }
    return sum;
}