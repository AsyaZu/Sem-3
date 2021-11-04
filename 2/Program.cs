 //2. Даны два числа. Показать большее и меньшее число

void a(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($"большее число = {a}");
        Console.WriteLine($"меньшее число = {b}");
    }
    else if (a < b)
    {
        Console.WriteLine($"большее число = {b}");
        Console.WriteLine($"меньшее число = {a}");
    }
    else
    {
        Console.WriteLine("числа равны");
    }

}

a(7, 7);