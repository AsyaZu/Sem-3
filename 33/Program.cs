// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];

string PrintArray (int[] array)
 {
    string res = string.Empty;
    int length = array.Length;
     for (int i = 0; i < length; i++)
     {
         array[i] = new Random().Next(0, 10);
     }

     for (int i = 0; i < length; i++)
     {
        res += $"{array[i]}  ";
     }
    return res;
 }

Console.WriteLine(PrintArray(array));
 
 string PrintSum (int[] array)
 {
    int sumP = 0;
    int sumM = 0;
    int length = array.Length;
    
     for (int i = 0; i < length; i++)
     {
        if (array[i] > 0)
        {
            sumP += array[i];
        }
        else
        {
            sumM += array[i];
        }
     }
    return sumP.ToString() + " " + sumM.ToString();
 }

Console.WriteLine(PrintSum(array));
