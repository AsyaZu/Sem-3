// Показать натуральные числа от N до 1, N задано

string Numbers (int N)
{
    if (N == 1) return $" {1}";
    return $" {N + Numbers(N - 1)}";
}
Console.WriteLine(Numbers(10));
