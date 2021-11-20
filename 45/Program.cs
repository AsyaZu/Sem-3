// Показать числа Фибоначчи

double[] array = new double [50];

string Fib (double[] array)
{
    int length = array.Length;
    int i = 0;
    array[0] = 0;
    array[1] = 1;
    string res = $"{array[0]} {array[1]} ";
    for (i = 2; i < length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        res += $"{array[i]} ";
    }
    return res;
}
Console.WriteLine(Fib(array));
