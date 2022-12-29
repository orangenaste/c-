﻿// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}
Console.WriteLine(String.Join(" ", array));

int SumOddPosition(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i % 2 == 1)
        sum = sum + array[i];
        
    }
    return sum;
}

Console.WriteLine($"Sum of elements at odd positions is = {SumOddPosition(array)}");