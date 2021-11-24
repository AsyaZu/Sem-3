// Показать натуральные числа от M до N, N и M заданы

string Numbers (int M, int N)
{
    string res = string.Empty;
    for (int n = M; n <= N; n++)
    {
        res = $"{Numbers(M, n - 1) + n} ";
    }
    return res;
}
Console.WriteLine(Numbers(-10, 10));
