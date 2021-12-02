// Показать натуральные числа от M до N, N и M заданы

string Numbers (int M, int N)
{
    if (M == N) return $"{N} ";
    return $"{Numbers(M, N - 1) + N} ";;
}
Console.WriteLine(Numbers(-10, 10));
