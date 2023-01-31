/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-100, 101);
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

int GetEvenNumSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 >0)
            sum += array[i];
    }

    return sum;
}

Console.WriteLine();

int[] array = InitArray(5);
PrintArray(array);
int EvenNumSum = GetEvenNumSum(array);
Console.WriteLine($"-> В указанном массиве {EvenNumSum} это сумма чисел на нечетных позициях.");