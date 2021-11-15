//  В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = {-12.3, 56.8, 0.9, 97.6};
double Diff (double[] array)
{
    double res = 0;
    int length = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    res = max - min;
    return res;
}
Console.WriteLine(Diff(array));
