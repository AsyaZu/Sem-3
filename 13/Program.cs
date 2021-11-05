//Выяснить, кратно ли число заданному, если нет, вывести остаток

void multiplicity (int dividend, int divider)
{
    if (dividend % divider == 0)
    {
        Console.WriteLine("Кратно");
    } 
    else 
    {
        Console.WriteLine(dividend % divider);
    }
}
multiplicity(7, 2);