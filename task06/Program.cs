// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("введите целое число");
//int number = int.Parse(Console.ReadLine());
int num = Math.Abs(int.Parse(Console.ReadLine()));

//Console.WriteLine(Math.Abs(int.Parse(Console.ReadLine())));
//int num = int.Parse(Console.ReadLine());
if (num < 100)
{
Console.WriteLine("Увы, нет 3й цифры");
}
else 
{
Console.WriteLine(num);

string num2 = Console.ReadLine();
Console.WriteLine(num2[2]);
}
 


