// Показать натуральные числа от N до 1, N задано

string Numbers (int N)
{
    string res = string.Empty;
    for (int n = 1; n <= N; n++)
    {
        res = $"{n + " " + Numbers(n - 1)}";
    }
    return res;
}
Console.WriteLine(Numbers(4));
