// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Вариант 1 общий случай для введения массива вручную. Подскажите, пожалуйста, почему при тестировании вручную 
// при такой последовательности [2 3 555 2 3 ] выдает ошибку?

PrintArray(InputArray());

int[] InputArray()
{
    Console.WriteLine("input array elements. please use split to do it");
    string elements = Console.ReadLine()!;
    string[] parts = elements.Split(' ');
    int[] arrInt = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
        arrInt[i] = int.Parse(parts[i]);
    }
    return arrInt;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// для 8 элементов

// int[] NewArray = InputArray(8);
// PrintArray(NewArray);

// int[] InputArray(int Length)
// {
//     Console.WriteLine("input array elements");
//     int[] arrInt = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         arrInt[i] = int.Parse(Console.ReadLine());
//     }
//     return arrInt;
// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }