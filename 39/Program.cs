// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = { 1, 2, 3, 4, 5, 0 };

string Multiplication(int[] array)
{
    int length = array.Length;
    string mult = string.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i != (length - 1))
        {
            mult += $"{array[i] * array[length - 1]} ";
            length = length - 1;
        }
        else
        {
            mult += $"{array[i]}";
        }
    }
    return mult;
}
Console.WriteLine(Multiplication(array));
