// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arr = new int[4];  //указываем кол-во чисел
Random rnd = new Random(); // Создаем массив из случайных трехзначных целых чисел
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }

// вызываем метод 
int count = CountEvenNumbers(arr);
 Console.Write($"[{string.Join(", ", arr)}]-> {count}");       

// Метод для подсчета кол-ва четных чисел в массиве
static int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) // Проверяем четное ли число
            {
                count++; 
            }
        }
        return count;
}