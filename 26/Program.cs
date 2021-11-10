// Возведите число А в натуральную степень B используя цикл

int Degree (int a, int b)
{
    int res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}
Console.WriteLine(Degree(4, 3));
