// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Enter integers separating them with a space: ");
string numbers = Console.ReadLine();
var arrayNumbers = numbers.Split(" ");

int[] array = Array.ConvertAll(arrayNumbers, int.Parse);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sum += 1;
}

Console.WriteLine($"You have entered {sum} integers > 0");