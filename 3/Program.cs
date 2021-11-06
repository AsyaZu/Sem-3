//  3.По заданному номеру дня недели вывести его название

string Day (int number)
{
    if (number == 1)
    {
        return ("понедельник");
    }
    else if (number == 2)
    {
        return ("вторник");
    }
    else if (number == 3)
    {
        return ("среда");
    }
    else if (number == 4)
    {
        return ("четверг");
    }
    else if (number == 5)
    {
        return ("пятница");
    }
    else if (number == 6)
    {
        return ("суббота");
    }
    else if (number == 7)
    {
        return ("воскресенье");
    }
    else
    {
        return ("такого дня недели не существует");
    }
}
    Console.WriteLine(Day(9));
