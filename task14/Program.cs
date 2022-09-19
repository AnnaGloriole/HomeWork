// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// вариант 1

int[] InputArray(int length)
{
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
    }
    return Array;
}

int Getsum(int[] IArray)
{
    int sum = 0;
    for (int n = 0; n < IArray.Length; n++)
    {
        if (IArray[n] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] result = InputArray(4);

PrintArray(result);

void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(" , ", array)}] Sum odd index = {Getsum(result)}");
}


//вариант 2 через foreach

// int Getsum(int[] IArray)
// {
//     int sum = 0;
//     foreach (int element in IArray)
//     {
//         if (element % 2 == 0)
//         sum++;
//     }
//     return sum;
// }