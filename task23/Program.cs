// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine();
Console.Write($"Smallest sum = {GetIndexSmallestSum(numbers)}");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

int GetIndexSmallestSum(int[,] innumbers)
{
    int[] sum = new int[innumbers.GetLength(0)];
    for (int i = 0; i < innumbers.GetLength(0); i++)
    {
        for (int j = 0; j < innumbers.GetLength(1); j++)
        {
            sum[i] = sum[i] + innumbers[i, j]; 
        }
    }    
   int min = sum[0];
   int index = 0;
    for (int n = 0; n < innumbers.GetLength(0); n++)
    {
        if (sum[n] < min) 
        {
        min = sum[n];
        index = n;
        }
    }
    return index;
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < height; i++)  // для каждой строки
    {
        for (int j = 0; j < width; j++)  // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j],5} ");
        }
        Console.WriteLine();
    }
}