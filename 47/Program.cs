// Написать программу копирования массива
int a = 25;
int[] array = new int [a];

void FillArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 50); 
    }
}

string PrintArray (int[] array)
{
    int length = array.Length;
    string res = string.Empty;
    for (int i = 0; i < length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}
FillArray(array);
Console.WriteLine(PrintArray(array));

string CopyArray (int[] array)
{
    int[] NewArray = new int [a];
    int length = NewArray.Length;
    string result = string.Empty;
    for (int i = 0; i < length; i++)
    {
        NewArray[i] = array[i];
        result += $"{NewArray[i]} ";
    } 
    return result;
}
Console.WriteLine(CopyArray(array));