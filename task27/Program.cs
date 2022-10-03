// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = EnterInt("Enter natural number: ");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int SumRec(int n)
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}

Console.WriteLine(SumRec(n)); 