// Найти сумму элементов от M до N, N и M заданы
int Sum(int M, int N)
{
    int sum = 0;
    for (int i = M; i <= N; i++)
    {
        sum = i + Sum(M, i - 1);
    }
    return sum;
}
Console.WriteLine(Sum(-10, 5));
