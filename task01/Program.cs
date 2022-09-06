Console.WriteLine("введите 2 числа");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max={num1}, min={num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"max={num2}, min={num1}");
}
else
{
    Console.WriteLine("числа равны");
}
