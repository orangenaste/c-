﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number from 1 to 7: "); 
int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
Console.Write(" Нет, это не выходной"); 
} 
else if (num >= 6 && num <= 7) 
{ 
Console.Write(" Да, это выходной"); 
} 
else Console.Write(" Не существует такого дня недели");  