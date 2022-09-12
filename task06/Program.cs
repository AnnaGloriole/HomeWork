// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

try
{
    Console.WriteLine("Input integer:");
    int num = int.Parse(Console.ReadLine()!);
    if (num < 0)
    {
        num = num * -1;
    }
    if (num < 100)
    {
        Console.WriteLine("three-digit number go for a walk");
    }
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
catch
{
    Console.WriteLine("Try again, stupid");
}