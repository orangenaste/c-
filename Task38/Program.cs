// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = { 3, 7, 22, 2, 78 };
Console.WriteLine($"[{String.Join(",", array)}]");

int maxelementarray = array[0];
int minelementarray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxelementarray)
    {
        maxelementarray = array[i];
    }
    else if (array[i] < minelementarray)
    {
        minelementarray = array[i];
    }
}
int differencemaxmin = maxelementarray - minelementarray;
Console.WriteLine($"Difference between max element {maxelementarray} and min element {minelementarray} is {differencemaxmin}");