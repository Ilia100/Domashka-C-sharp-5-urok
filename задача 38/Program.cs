/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 101);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.WriteLine();
}


(int, int) GetMaxMin(int[] array)
{

    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else
            if (array[i] < min) min = array[i];
    }

    return (max, min);
}



Console.WriteLine();

int[] array = InitArray(5);
PrintArray(array);

(int maximum, int minimum) = GetMaxMin(array);
Console.WriteLine($"максимальное число {maximum} > минимальное число  {minimum}");

int dif = maximum-minimum;
Console.WriteLine($"-> разницу между максимальным и минимальным элементjv массива = {dif}");