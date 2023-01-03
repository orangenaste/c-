// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = 2;
int columns = 2;
int[,] matrix1 = GetArray(rows, columns, 0, 10);
int[,] matrix2 = GetArray(rows, columns, 0, 10);
Console.WriteLine("Matrix 1: ");
PrintArray(matrix1);
Console.WriteLine("Matrix 2: ");
PrintArray(matrix2);

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

int[,] MultiplicationMatrix = new int[rows, columns];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        MultiplicationMatrix[i, j] = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            MultiplicationMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Multiplication of two matrices: ");
PrintArray(MultiplicationMatrix);