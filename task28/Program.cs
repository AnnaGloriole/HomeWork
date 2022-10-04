// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int fNumber = EnterInt("Enter first number: ");
int sNumber = EnterInt("Enter second number: ");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

if (fNumber == sNumber)
{
    Console.WriteLine("Sum = 0");
}
else
{
    Console.WriteLine($"Sum = {SumBetweenNums(fNumber, sNumber)}");
}

int SumBetweenNums(int start, int end)
{
    int sum = start;
    if (start < 0 && end < 0) 
    {
        return sum = 0;
    }
    if (start < end)
    {
        while (start < 0)
        {
            start++;
        }
        sum = start + SumBetweenNums(start + 1, end);
    }
    if (start > end && start > 0) 
    {
        sum = start + SumBetweenNums(start - 1, end);
    }
    return sum;
}