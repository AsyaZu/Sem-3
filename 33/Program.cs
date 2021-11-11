// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];

void FillArray (int[] array)
{
    int length = array.Length;
     for (int i = 0; i < length; i++)
     {
         array[i] = new Random().Next(0, 10);
     }
}

string PrintArray (int[] array)
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
 
 string PrintSumP (int[] array)
 {
    int sumP = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
     {
        if (array[i] > 0)
        {
            sumP += array[i];
        }
     }
    return sumP.ToString();
 }

string PrintSumM (int[] array)
{
    int sumM = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
     {
        if (array[i] < 0)
        {
            sumM += array[i];
        }
     }
    return sumM.ToString();
}

Console.WriteLine(PrintSumP(array));
Console.WriteLine(PrintSumM(array));