
Console.Clear();
// string [] array1 = {"hello", "2", "world", "22", ":-)"};
string[] array1 = { "1234", "1567", "-2", "computer science"};
// string [] array1 = {"Russia", "Denmark", "Kazan"};

string[] array2 = new string[array1.Length];
void SortMassiveElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"  {Array[i]}");
    }
}

SortMassiveElements(array1, array2);
Console.WriteLine("Элементы массива:  ");
Print(array1);
Console.WriteLine();
Console.WriteLine($"\nЭлементы длиной менее или равно 3-х символов: ");
Print(array2);



