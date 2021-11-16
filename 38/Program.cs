// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = {12, 101, 8, 16, 15, 17, 41, 2};

int Sum (int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        sum += array[i];
        i++;
    }
    return sum;
}
Console.WriteLine(Sum(array));
