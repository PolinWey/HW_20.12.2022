/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
            System.Console.Write(result[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return result;
}

double[] SumArray(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            newArray[i]+=array[j,i];
        }
    }
    System.Console.WriteLine();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = newArray[i] / array.GetLength(0);
        System.Console.Write(newArray[i] + " ");
    }
    return newArray;
}
Console.Clear();
int[,] array = GetArray(4, 6, 4, 16);
double[] arr = SumArray(array);