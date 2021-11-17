// Написать программу преобразования десятичного числа в двоичное

string Bin (int number)
{
    string bin = string.Empty;
    while (number > 0)
    {
        bin = $"{number % 2}{bin}";
        number = number / 2;
    }
    return bin;
}
Console.WriteLine(Bin(3));
