﻿// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.WriteLine($"Введите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"A({m},{n}) = {result}");
