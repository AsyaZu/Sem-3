// Написать программу замену элементов массива на противоположные
int[] array = new int[10];

void FillArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

string Change (int[] array)
{
    int size = array.Length;
    string result = string.Empty;
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] * (-1);
        result += $"{array[i]} ";
    }
    return result;
}

FillArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine(Change(array));