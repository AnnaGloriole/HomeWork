// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] number = new int[height, width];
Fill2DArray(number);
Print2DArray(number);
GetОrderedArray(number);
Console.WriteLine();
Print2DArray(number);

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
            numbers[i, j] = new Random().Next(0, 11);
        }
    }
}

void GetОrderedArray(int[,] innumbers)
{
    for (int i = 0; i < innumbers.GetLength(0); i++)
    {
        for (int j = 0; j < innumbers.GetLength(1); j++)
        {
            for (int n = 0; n < innumbers.GetLength(1) - 1; n++)
            { 
                if (innumbers[i, n] < innumbers[i, n + 1])
                {
                    int temp = innumbers[i, n];
                    innumbers[i, n] = innumbers[i, n + 1];
                    innumbers[i, n + 1] = temp;
                }
            }
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < height; i++) 
    {
        for (int j = 0; j < width; j++)  
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}