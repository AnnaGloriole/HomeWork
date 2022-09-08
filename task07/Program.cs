// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите день недели в виде цифры");
int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <= 5)
{
Console.WriteLine("Рабочий день! К станку!");
}
else if (number == 6 || number == 7)
{
Console.WriteLine("Ура выходной! Делаем домашку GB!");
}
else 
{
Console.WriteLine("Это уже календарь индейцев майя!");
}