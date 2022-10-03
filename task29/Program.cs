﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int fNumber = EnterInt("Enter first number: ");
int sNumber = EnterInt("Enter second number: ");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

AkkermanFunction(fNumber, sNumber);
Console.WriteLine(AkkermanFunction(fNumber, sNumber));

int AkkermanFunction(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    if (m > 0 && n > 0) ;
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}
