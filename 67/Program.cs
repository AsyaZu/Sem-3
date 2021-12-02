// Показать натуральные числа от 1 до N, N задано

string Numbers (int N)
{
    if (N == 1) return $"{1} ";
    return $"{Numbers(N - 1) + N} ";
}
Console.WriteLine(Numbers(10));