// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

try
{
    Console.WriteLine("input five-digit number");
    int number = Math.Abs(int.Parse(Console.ReadLine()!));
    Console.WriteLine(number);
    string num2 = Convert.ToString(number);
    if (num2[0] == num2[4] && num2[1] == num2[3])
    {
        Console.WriteLine("Yes, of course");
    }
    else
    {
        Console.WriteLine("No");
    }
}
catch
{
    Console.WriteLine("it's not correct number");
}