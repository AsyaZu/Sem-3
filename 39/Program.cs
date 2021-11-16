// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = {1, 0, 3, 4, 5, 6, 13, 2};

string Multiplication (int[] array)
{
    int length = array.Length;
    string mult = string.Empty;
    for (int i = 0; i < length; i++)
    {
        mult += $"{array[i] * array[length - 1]} ";
        length = length - 1;
    }
    return mult;
}
Console.WriteLine(Multiplication(array));
