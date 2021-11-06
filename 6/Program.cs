//6. Выяснить является ли число чётным

string FindEven (int number)
{
    if (number % 2 == 0)
    {
        return ("число является четным");
    }
    else
    {
        return ("число является нечетным");
    }
}

Console.WriteLine(FindEven(32));