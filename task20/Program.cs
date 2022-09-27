// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.Write($"  [{string.Join("   ", GetArithmeticMean(numbers))}]");


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

double[] GetArithmeticMean(int[,] innumbers)
{
    double[] arithMean = new double[innumbers.GetLength(1)];
    for (int i = 0; i < innumbers.GetLength(1); i++)
    {
        for (int j = 0; j < innumbers.GetLength(0); j++)
        {
            arithMean[i] = arithMean[i] + innumbers[j, i];
        }
    }    
    for (int n = 0; n < innumbers.GetLength(1); n++)
    {
        arithMean[n] = Math.Round(arithMean[n] / innumbers.GetLength(0), 1);        
    }
    return arithMean;
}

void Print2DArray(int[,] numbers, int height, int width)
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