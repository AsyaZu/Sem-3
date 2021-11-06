 //2. Даны два числа. Показать большее и меньшее число

string a(int a, int b)
{
    if (a > b)
    {
        return ($"большее число = {a}, меньшее число = {b}");
    }
    else if (a < b)
    {
        return ($"большее число = {b}, меньшее число = {a}");
    }
    else
    {
        return ("числа равны");
    }

}

Console.WriteLine(a(9, 8));