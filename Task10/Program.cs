// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter num: ");
string s_num = Console.ReadLine();
int num = Convert.ToInt32(s_num);

if(num > 99 && num < 1000)
{
    int secondDigit = (num/10) % 10;
    Console.WriteLine($"Second digit of {num} is {secondDigit}");
}
else
Console.WriteLine($"{num} is not a three-digit number");
