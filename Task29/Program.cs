// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// пользователю нужно ввести самому цифры

int[] array = new int[8];

for (int i =0; i < array.Length; i++)
{
    Console.Write($"Enter the array elements under the index {i}  ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Your array is ");
Console.WriteLine(string.Join(", ", array));

// Решение с семинара:
// int [] array = GetRandomArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }