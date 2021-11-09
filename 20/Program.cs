// Задать номер четверти, показать диапазоны для возможных координат
string D(int N)
{
    string res = string.Empty;
    if (N == 1)
    {
        res = "X = (0;infinity); Y = (0;infinity)";
    }
    else if (N == 2)
    {
        res = "X = (-infinity;0); Y = (0;infinity)";

    }
    else if (N == 3)
    {
        res = "X = (-infinity;0); Y = (-infinity;0)";

    }
    else if (N == 4)
    {
        res = "X = (0;infinity); Y = (-infinity;0)";
    }
    else
    {
        res = "такой четверти нет";
    }
    return res;
}
Console.WriteLine(D(5));
