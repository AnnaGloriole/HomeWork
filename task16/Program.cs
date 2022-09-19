// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] InputArray(int length)
{
    double[] Array = new double[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(-99, 100);
    }
    return Array;
}

double Max(double[] IArray)
{
    double max = IArray[0];
    foreach (double arg in IArray)
    {
        if (arg > max) max = arg;
    }
    return max;
}

double Min(double[] IArray)
{
    double min = IArray[0];
    foreach (double arg in IArray)
    {
        if (arg < min) min = arg;
    }
    return min;
}

double[] result = InputArray(4);
double subtraction = Max(result) - Min(result);

PrintArray(result);

void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(" , ", array)}]");
}

Console.Write($"max [{Max(result)}] - min [{Min(result)}] = {subtraction}");

// Правильно ли я понимаю, что double или float массив созданный с помощью Random.Next содержит, но не отображает цифры после запятой?
// Для отображения в этом случае Math.Round не подходит? Что может помочь?

// Вопрос 2 
// Можно ли вывести 2 значения сразу мин и макс, если объединить функции в одну? Если да - то каким образом?

// double MaxMin(double[] IArray, out double min, out double max)
// {
//     double max = IArray[0];
//     double min = IArray[0];
//     foreach (double arg in IArray)
//     {
//     if (arg > max) max = arg; out double max;
//     if (arg < min) min = arg;
//     }
// }