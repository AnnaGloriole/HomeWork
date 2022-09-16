// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = new Random().Next(100, 100001);
Console.WriteLine(number);
string num2 = number.ToString();
int[] arrInt = new int[num2.Length];
int sum = 0;
for (int i = 0; i < num2.Length; i++)
{
    arrInt[i] = int.Parse(num2[i] + ""); // Подскажите, пожалуйста, почему недостаточно int.Parse(num2[i]) и нужно добавлять + ""?
// Также почему Convert.ToInt32() конвертирует двузначное число?
    sum += arrInt[i];
}
Console.Write($"Sum = {string.Join(" + ", arrInt)} = {sum}");

// можно и так:
// Comment1:

// int sum = 0;
// foreach (int element in arrInt)
// {
//     sum += element;
// }
// Console.Write($" = {sum}");


// Comment2:

// PrintArray(arrInt);

// void PrintArray(int[] array)
// {
//     foreach(int element in array)
//     {
//         Console.Write($"number {number} converted to array [{string.Join(", " element)}]");
//     }
// }