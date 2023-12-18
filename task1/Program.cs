// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }
}

Console.WriteLine($"Введите диапазон натуральных числел");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {M} до {N}:");
PrintNumbers(M, N);
