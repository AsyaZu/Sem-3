// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите числа");
int[] array = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
int Numbers (int[] array)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(Numbers(array));

