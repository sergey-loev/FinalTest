string[] FillInArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Console.ReadLine() ?? string.Empty;
    }

    return array;
}

string[] CreateNewCutArray(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            count++;
    }

    string[] cutArray = new string[count];
 
    for (int i = 0, j = 0; i < stringArray.Length && j < count; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            cutArray[j] = stringArray[i];
            j++;
        }
    }
    return cutArray;
}

void WriteStringArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.WriteLine();
}

Console.WriteLine("Input length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] myStringArray = FillInArray(length);
WriteStringArray(myStringArray);

string[] cutStringArray = CreateNewCutArray(myStringArray);
WriteStringArray(cutStringArray);