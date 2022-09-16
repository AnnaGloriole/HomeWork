// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("input integer numA numB");
    string numbersAB = Console.ReadLine()!;
    string[] parts = numbersAB.Split(' ');
    int numA = int.Parse(parts[0]);
    int numB = int.Parse(parts[1]);
    int result = 1;
for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
Console.WriteLine(result);