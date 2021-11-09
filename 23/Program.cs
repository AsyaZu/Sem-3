// Показать таблицу квадратов чисел от 1 до N 
void SquaresTable (int N)
{
    int res = 0;
    for (int n = 1; n <= N; n++)
    {
        res = n * n;
        Console.WriteLine($"{n}^2 = {res}");
    }
}
SquaresTable(15);