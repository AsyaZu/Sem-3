//1. По двум заданным числам проверять является ли первое квадратом второго

string result (int a, int b)
{
    if (b == a * a)
    {
        return ("Число является квадратом");
    }
    else
    {
        return ("Число не является квадратом");
    }
}
 Console.WriteLine(result(5, 26));
