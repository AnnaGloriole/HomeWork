// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int height = EnterInt ("Enter height: ");
int width = EnterInt ("Enter width: ");

double [ , ] numbers = new double [height, width];
Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);

int EnterInt (string prompt)
{
    Console.Write (prompt);
    return int.Parse (Console.ReadLine ()!);
}
// float EnterFloat (string prompt)
// {
//     Console.Write (prompt);
//     return float.Parse (Console.ReadLine ()!);
// }

void Fill2DArray (double [ , ] numbers, int height, int width) 
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++) 
        {
            numbers[i, j] = Math.Round (new Random().NextDouble() * 20 - 10, 1);
            
        }
    }
}

void Print2DArray (double [, ] numbers, double height, double width) 
{
    for (int i = 0; i < height; i++) 
    {
        for (int j = 0; j < width; j++)  
        {
            Console.Write ($"{numbers[i, j], 5}");
        }
        Console.WriteLine ();
    }
}