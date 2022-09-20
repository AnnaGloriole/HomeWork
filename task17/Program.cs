//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] InputArray(int Length)
{
    Console.WriteLine("input array elements");
    int[] arrInt = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        arrInt[i] = int.Parse(Console.ReadLine());
    }
    return arrInt;
}

int GetQauntity(int[] IArray)
{
    int sum = 0;
    foreach (int arg in IArray)
    {
        if (arg > 0)
            sum++;
    }
    return sum;
}

int[] NewArray = InputArray(5);

PrintArray(NewArray);

Console.WriteLine($"Quantity positive numbers = {GetQauntity(NewArray)}");

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}