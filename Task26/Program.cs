// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());
int i = 0;

for (;num > 0; num/=10)
{
 i++;
}
Console.WriteLine($"there are {i} digits in this number");