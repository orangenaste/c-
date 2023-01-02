// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Input number of array's rows: ");
var rows = int.Parse(Console.ReadLine());
Console.Write("Input number of array's columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, -99, 99);
PrintArrayDouble(arrayDouble);

double[,] GetArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue)/10.0;
        }
    }
    return result;
}

void PrintArrayDouble(double[,] inArray)
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
