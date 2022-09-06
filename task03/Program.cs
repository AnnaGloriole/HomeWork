Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("ноль");
}
else if (num % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}