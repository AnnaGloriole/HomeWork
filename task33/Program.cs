
Console.WriteLine("input array length");
int arLength = int.Parse(Console.ReadLine()!);

Console.WriteLine("input max string length");
int maxLength = int.Parse(Console.ReadLine()!);

string[] NewArray = InputArray(arLength);

PrintArray(NewArray);
Console.Write(" -> ");
PrintArray(GetTreeDigitArray(NewArray));

string[] InputArray(int Length)
{
    Console.WriteLine("input array elements");
    string[] arrInt = new string[Length];
    for (int i = 0; i < Length; i++)
    {
        arrInt[i] = Console.ReadLine()!;
    }
    return arrInt;
}

string[] GetTreeDigitArray(string[] IArray)
{
    int LengthArray = 0;
    string[] emptyArray = new string[] { };
    for (int i = 0; i < IArray.Length; i++)
    {
        if (IArray[i].Length <= 3)
            LengthArray++;
    }
    if (LengthArray == 0) return emptyArray;
    string[] TreeDigitArray = new string[LengthArray];
    int n = 0;
    for (int i = 0; i < IArray.Length; i++)
    {
        if (IArray[i].Length <= 3)
        {
            TreeDigitArray[n] = IArray[i];
            n++;
        }
    }
    return TreeDigitArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.Write("[]");
    else
        Console.Write($"[\"{string.Join("\", \"", array)}\"]");
}