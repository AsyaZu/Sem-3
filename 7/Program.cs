//7. Показать числа от -N до N

void ShowNumbers (int a, int b)
{   
    int NextNumber = a;
    while (NextNumber <= b)
    {
        Console.WriteLine(NextNumber);
        NextNumber++;
    }
}
ShowNumbers(-3, 3);

