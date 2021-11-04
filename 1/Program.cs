//1. По двум заданным числам проверять является ли первое квадратом второго

void result(int a, int b)
{
    if (b == a * a)
    {
        Console.WriteLine("Число является квадратом");
    }
    else
    {
        Console.WriteLine("Число не является квадратом");
    }
}
 result(5, 25);
