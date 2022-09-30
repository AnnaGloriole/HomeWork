// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");
int deep = EnterInt("Enter deep: ");

int[,,] matrix = new int[height, width, deep];
// int[,,] theCube = GetNext3DArray(height, width, deep); для 2го варианта
// Print3DArray(theCube);
int[] fill = FillUniqArray(matrix);
Fill3DArray(matrix, fill);
Print3DArray(matrix);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int[] FillUniqArray(int[,,] array)
{
    int[] matrix = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    if (matrix.Length > 90)
    {
        throw new Exception("out of limit");
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random r = new Random();
        int y = 0;
        matrix[i] = r.Next(10, 100);
        y = matrix[i];

        for (int j = 0; j < i; j++)
        {
            while (matrix[i] == matrix[j])
            {
                matrix[i] = r.Next(10, 100);
                j = 0;
                y = matrix[i];
            }
            y = matrix[i];
        }
    }
    return matrix;
}

void Fill3DArray(int[,,] array, int[] fill)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = fill[n++];
            }
        }
    }
}

// вариант заполнения числами подряд:
// int [,,] GetNext3DArray(int m, int n, int d)
// {
//     int [,,] matrix = new int[m,n,d];
//     int step = 3;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int h = 0; h < matrix.GetLength(2); h++)
//             {
//                 matrix[i,j,h] = 10 + step;
//                 step++;
//             }
//         }
//     }
//     return matrix;
// }


void Print3DArray(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int d = 0; d < inputMatrix.GetLength(2); d++)
            {
                Console.Write($"{inputMatrix[i, j, d]}({i},{j},{d})   ");
            }
            Console.WriteLine();
        }
    }
}