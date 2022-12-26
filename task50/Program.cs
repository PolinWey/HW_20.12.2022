/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] GetAndPrintArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(result[i,j]+" ");
        }
        Console.WriteLine();
    }
    return result;
}

void ElementArray(int[,] array, int indexRows, int indexColumns)
{
    if (indexRows >= array.GetLength(0) && indexColumns >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
        
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == indexRows && j == indexColumns)
                {
                    Console.WriteLine(array[indexRows, indexColumns]);
                    break;
                }
            }
        }
    }
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс строки: ");
int indexRows = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int indexColumns = int.Parse(Console.ReadLine()!);

int[,] array = GetAndPrintArray(rows, columns, 5, 30);
Console.WriteLine();
ElementArray(array, indexRows, indexColumns);

