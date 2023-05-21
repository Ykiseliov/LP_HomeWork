
// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine()); // ввод числа A
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()); // ввод числа B
int result = 1; // начальное значение результата

for (int i = 0; i < B; i++)
{
    result *= A; // умножаем результат на A B раз
}

Console.WriteLine($"{A}, {B} -> {result}"); 
