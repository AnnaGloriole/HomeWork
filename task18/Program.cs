// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[] InputAndSplitString()
{
    Console.WriteLine("input numbers, please use split, comma or slash");
    return Console.ReadLine()!.Split(' ', ',', '/');
}

string[] coefficient = InputAndSplitString();
double k1 = double.Parse(coefficient[0]);
double b1 = double.Parse(coefficient[1]);
double k2 = double.Parse(coefficient[2]);
double b2 = double.Parse(coefficient[3]);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("lines match");
}
else if (k1 == k2)
{
    Console.WriteLine("parallel lines");
}
else
{
    double x = (b2 -b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"lines cross at point ({Math.Round (x,3)}; {Math.Round (x,3)})");
}