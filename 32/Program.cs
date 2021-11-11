// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] array = new int[8];

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

string PrintArray(int[] array)
{
    string res = string.Empty;
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]}  ";
    }
    return res;
}
FillArray(array);
Console.WriteLine(PrintArray(array));
