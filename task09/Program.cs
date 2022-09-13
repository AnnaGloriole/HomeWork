// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Point A: input coordinate x");
double xA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Point A: input coordinate y");
double yA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Point A: input coordinate z");
double zA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Point B: input coordinate x");
double xB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Point B: input coordinate y");
double yB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Point B: input coordinate z");
double zB = double.Parse(Console.ReadLine()!);
double distance = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2));
Console.WriteLine(distance);

// Попыталась упростить ввод данных через функцию, но не понятно как делеть return для 3х значений?
// Также не интересно можно ли после введения координат точек через функцию сделать так, чтобы координаты распознавались какой конкретной точке они принадлежат?
// int Method(int x, int y, int z)
// {
//     Console.WriteLine("input cooordinates x y z");
//     string xyz = Console.ReadLine()!;
//     string[] parts = xyz.Split(' ');
//     int x1 = int.Parse(parts[0]);
//     int y1 = int.Parse(parts[1]);
//     int z1 = int.Parse(parts[2]);
//     Console.WriteLine($"x={x1}, y={y1}, z={z1}");
//     return ???
// }

// Нашла 2 коротких варианта в сети на эту тему, но у меня они не работают - что-то не так (
// Что же не так?

// вариант 1
// static class Coord
// {
//     static double LengthBetweenPoint(int x1, int y1, int x2, int y2)
//     {
//         return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//     }
// }

// Вариант 2
// // static void Main(string[] args)
// //     {
// // //               try
// //         {
//             int firstArg = GetNumber("Введите первое число и нажмите клавишу Enter: ");
 
//             int secondArg = GetNumber("Введите второе число и нажмите клавишу Enter: ");
             
//             int result = firstArg + secondArg;
 
//     //         //Вывод результата
//     //         Console.WriteLine("Результат сложения введенных чисел: " + result.ToString());
//     //     }
//     //             catch (SystemException)
//     //     {
//     //          Console.WriteLine("Во время выполнения программы произошла ошибка, вероятно, были введены некорректные данные!");
//     //     }
//     // }
