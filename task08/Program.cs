// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("введите 5ти значное число");
//string number = Console.ReadLine ();
//if (number[0] == number[4] && number[1] == number[3])
//{
//    Console.WriteLine("Да");
//}
//else
//{
//    Console.WriteLine("Нет");
//}

Console.WriteLine("введите 5ти значное число");
int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(number);
string num2 = Convert.ToString(number);
if (num2[0] == num2[4] && num2[1] == num2[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
//else if ()