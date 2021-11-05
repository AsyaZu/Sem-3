// Найти третью цифру числа или сообщить, что её нет (с конца)

void number(int a)
{
    int res = ((a % 1000) - ((a % 1000) % 100)) / 100;
    if (res == 0)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(res);
    }
}

number(55933);
