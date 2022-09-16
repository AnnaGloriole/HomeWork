// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Вариант1

// Console.WriteLine("Point A: input coordinate x");
// double xA = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Point A: input coordinate y");
// double yA = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Point A: input coordinate z");
// double zA = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Point B: input coordinate x");
// double xB = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Point B: input coordinate y");
// double yB = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Point B: input coordinate z");
// double zB = double.Parse(Console.ReadLine()!);
// double distance = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2));
// Console.WriteLine(distance);

// Вариант 2

// int[] partsA = InputArray(3);
// int[] partsB = InputArray(3);

// int[] InputArray(int Length)
// {
//     Console.WriteLine("input coordinates");
//     int[] arrInt = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         arrInt[i] = int.Parse(Console.ReadLine());
//     }
//     return arrInt;
// }

// double distance = Math.Sqrt(Math.Pow(partsA[0]-partsB[0], 2) + Math.Pow(partsA[1]-partsB[1], 2) + Math.Pow(partsA[2]-partsB[2], 2));
// Console.WriteLine(Math.Round(distance, 2));


static double LengthBetweenPoint(int x1, int y1, int x2, int y2);
static class Coord
{
    static double LengthBetweenPoint(int x1, int y1, int x2, int y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}




