// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;  
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

// Выразим x: k1 * x + b1 = k2 * x + b2
//            k1 * x + b1 - k2 * x - b2 = 0
//            x(k1 - k2) + (b1 - b2) = 0 ; x = (b2 - b1) / (k1 - k2)

double pointX = (b2 - b1) / (k1 - k2);
double pointY = k1 * pointX + b1;

Console.WriteLine($"Point of intersection: {pointX},{pointY}");