// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int [10];

void FillArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (100, 1000);
    }
}

string PrintArray (int[] array)
{
    string res = string.Empty;
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int Even (int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int Odd (int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine($"Четные {Even(array)}");
Console.WriteLine($"Нечетные {Odd(array)}");

