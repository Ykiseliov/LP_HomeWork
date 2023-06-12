// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число(M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число(N): ");
int n = Convert.ToInt32(Console.ReadLine());
      
int sum = SumInRange(m, n); // вызываем метод с начальными значениями m и n
Console.WriteLine($"M={m};N={n} -> {sum}");

int SumInRange(int m, int n)
{
    if (m == n) // условие выхода из рекурсии
        {
            return m; // возвращаем текущее число
        }
    if (m > n)
        {
            return 0; // если m > n, возвращаем ноль, так как суммы не будет
        }
    else
        {
            return m + SumInRange(m + 1, n); // возвращаем текущее число плюс сумму оставшегося диапазона
        }
}