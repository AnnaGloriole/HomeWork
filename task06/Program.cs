// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("введите целое число");
int num = Math.Abs(int.Parse(Console.ReadLine())); //модуль, если число отрицательное
if (num < 100)
{
    Console.WriteLine("Увы, нет 3й цифры");
}
else
{
    //Console.WriteLine(num);
    string num2 = Convert.ToString(num);
    Console.WriteLine(num2[2]);
}

//Подскажите, пожалуйста, какое решение проще по операциям:
// 1. Это решение - поиск 3го числа по индексу
// 2. Математический медод - % 10 в цикле?
// Можно ли использоать char[] и int[] для lго способа?

// Хотелось сделать так, чтобы при вводе букв, была указана ошибка ввода, но программа выдает ошибку сама "Input string is not in correct format"
// Как это можно обойти? Пример ниже
//Console.WriteLine("введите целое число");
//int num = Math.Abs(int.Parse(Console.ReadLine())); //модуль, если число отрицательное
//if (num < 100)
//{
//Console.WriteLine("Увы, нет 3й цифры");
//}
//else if (num >= 100)
//{
//string num2 = Convert.ToString(num);
//Console.WriteLine(num2[2]);
//}
//else
//{
//Console.WriteLine("Вы ввели не число, попытайтесь еще, мы верим в Вас");
//}