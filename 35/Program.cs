// Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = {12, 5, -9, 11};
bool Find (int[] array, int N)
{
    bool res = false;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] == N) 
        {
            res = true;
        }
    }
    return res;
}
Console.WriteLine(Find(array, 12));

