﻿        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
        // сколько чисел больше 0 ввёл пользователь.

        // Пример: 0, 7, 8, -2, -2 -> 2
        // -1, -7, 567, 89, 223-> 3
        
        Console.Write("Введите количество чисел: ");
        int M = Convert.ToInt32(Console.ReadLine()); // считываем количество чисел
        int[] numbers = new int[M]; // создаем массив для хранения чисел

        // считываем M чисел и сохраняем их в массиве
        for (int i = 0; i < M; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine()); 
        }

        int count = 0; // счетчик положительных чисел

        // проходимся по массиву и подсчитываем количество положительных чисел
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                count++;
            }
        }

        // выводим массив и количество положительных чисел
        Console.Write($"{string.Join(", ", numbers)} -> {count}");