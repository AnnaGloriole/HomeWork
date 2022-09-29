// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int height = EnterInt("Enter height/width: ");
int width = height;
int[,] numbers1 = new int[height, width];
int[,] numbers2 = new int[height, width];

Fill2DArray(numbers1);
Print2DArray(numbers1);
Console.WriteLine();
Fill2DArray(numbers2);
Print2DArray(numbers2);
Console.WriteLine();
Print2DArray(MultyplyArray(numbers1, numbers2));

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

int[,] MultyplyArray(int[,] numbersA, int[,] numbersB)
{
    int[,] numbersC = new int[height, width];
    for (int i = 0; i < numbersC.GetLength(0); i++)
    {
        for (int j = 0; j < numbersC.GetLength(1); j++)
        {
            for (int n = 0; n < numbersA.GetLength(1); n++)
            {
                numbersC[i, j] += numbersA[i, n] + numbersB[n, j];
            }
        }
    }
    return numbersC;
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