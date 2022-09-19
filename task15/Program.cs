// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] InputArray(int length)
{
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(-100, 100);
    }
    return Array;
}

int Getsum(int[] IArray)
{
    int sum = 0;
    for (int j = 1; j < IArray.Length; j += 2)
    {
        sum += IArray[j];
    }
    return sum;
}

int[] result = InputArray(4);

PrintArray(result);

void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(" , ", array)}]");
}

Console.Write($" Sum numbers uneven index = {Getsum(result)}");