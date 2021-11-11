// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] array = new int [8];

 string PrintArray (int[] array)
 {
    string res = string.Empty;
    int length = array.Length;
     for (int i = 0; i < length; i++)
     {
         array[i] = new Random().Next(0, 2); //[0; 2)
     }

     for (int i = 0; i < length; i++)
     {
        res += $"{array[i]}  ";
     }
    return res;
 }

Console.WriteLine(PrintArray(array));
