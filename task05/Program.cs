//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Вариант 1
//Console.WriteLine("введите 3х значное число");
//string number = Console.ReadLine ();
//Console.WriteLine(number[1]);

//Вариант 2
int number = new Random().Next(99, 1000);
Console.WriteLine(number);
string num2 = Convert.ToString(number);
Console.WriteLine(num2[1]);