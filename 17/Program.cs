// По двум заданным числам проверять является ли одно квадратом другого
bool Square (int a, int b)
{
    return a == b * b || b == a * a;
}
Console.WriteLine(Square(9, 9));