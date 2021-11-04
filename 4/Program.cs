//4. Найти максимальное из трех чисел

int FindMax (int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
     if (c > max)
    {
        max = c;
    }

return max;
}

int res = FindMax (12,35,66);
Console.WriteLine(res);
