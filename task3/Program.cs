// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr) Console.Write(item + " ");
    Console.WriteLine();
}

void PrintArrayReversed(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} ");
        PrintArrayReversed(arr, index - 1);
    }
}

int[] array = new int[10];
array = FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArrayReversed(array, array.Length - 1);

