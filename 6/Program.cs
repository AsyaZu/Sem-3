//6. Выяснить является ли число чётным

void FindEven (int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("число является четным");
    }
    else
    {
        Console.WriteLine("число является нечетным");
    }

}

FindEven(35);