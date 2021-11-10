// Определить количество цифр в числе

int Count (int number)
{
    int count = 0;
    while (number >= 1)
    {
        number = (number - number % 10) / 10;
        count++;
    }
    return count;
}
Console.WriteLine(Count(156));
