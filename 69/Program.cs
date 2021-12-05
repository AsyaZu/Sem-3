// Найти сумму элементов от M до N, N и M задан

int Sum(int M, int N)
{
    if (M == N) return N;
    return M + Sum(M+1, N);
}
Console.WriteLine(Sum(2, 4));

