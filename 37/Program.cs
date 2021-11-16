// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int [123];

void FillArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-100, 100);
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

int Find (int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine(Find(array));