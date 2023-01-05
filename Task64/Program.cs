// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
int m = 1;

Console.Write($"All natural numbers in the interval from {n} to {m} : ");
NaturalNumbers(n, m);

void NaturalNumbers(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturalNumbers(n, m + 1);
        Console.Write(m + " ");
    }
}