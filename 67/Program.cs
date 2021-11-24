// Показать натуральные числа от 1 до N, N задано

string Numbers (int N)
{
    string res = string.Empty;
    for (int n = 1; n <= N; n++)
    {
        res = $"{Numbers(n - 1) + n} ";
    }
    return res;
}
Console.WriteLine(Numbers(10));