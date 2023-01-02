// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
int columns = 4;
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int number = 0;
                    number = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = number;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Array with elements of each row ordered in descending order");

int[,] arraySortDescending = SortDescending(array);
PrintSortDescending(arraySortDescending);

void PrintSortDescending(int[,] arraySortDescending)
{
    for (int i = 0; i < arraySortDescending.GetLength(0); i++)
    {
        for (int j = 0; j < arraySortDescending.GetLength(1); j++)
        {
            Console.Write($"{arraySortDescending[i, j]} ");
        }
        Console.WriteLine();
    }
}
