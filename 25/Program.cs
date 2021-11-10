// Найти сумму чисел от 1 до А
int Sum (int A)
{
    int sum = 0;
    for (int n = 1; n <= A; n++)
    {
        sum = n + sum;
    }
    return sum;
}
Console.WriteLine(Sum(50));
