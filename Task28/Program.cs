﻿// // Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter num: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = 1;

for (int i=1; i<=num; i++)
{
 a = a*i;
}
Console.WriteLine($"{a}");