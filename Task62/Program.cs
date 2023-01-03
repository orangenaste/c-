// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Матрица заролняется вправо, по кругу. 
// Если ячейка не занята и в пределах массива, ставим цифру
// Если выходим за предел массива, идем вниз (меняем движение)
// Если n = 4, n квадрат = 16, конец матрицы
// Используем цикл while

int n = 4;
int[,] array = new int[n, n];

int number = 1;
int i = 0;
int j = 0;

while (number <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = number;
    number++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(array);

void PrintArray(int[,] GetArray)
{
    for (int i = 0; i < GetArray.GetLength(0); i++)
    {
        for (int j = 0; j < GetArray.GetLength(1); j++)
        {
            Console.Write(GetArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
