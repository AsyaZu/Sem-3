// Найти кубы чисел от 1 до N

void SquaresTable (int N)
{
    int res = 0;
    for (int n = 1; n <= N; n++)
    {
        res = n * n * n;
        Console.WriteLine($"{n}^3 = {res}");
    }
}
SquaresTable(15);