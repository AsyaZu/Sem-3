// Выяснить являются ли три числа сторонами треугольника 
bool Find (int a, int b, int c)
{
    if (a > b && a > c && a < (b + c)) return true;
    if (b > a && b > c && b < (a + c)) return true;
    if (c > a && c > b && c < (a + b)) return true;
    else return false;
}

Console.WriteLine(Find(3, 4, 7));