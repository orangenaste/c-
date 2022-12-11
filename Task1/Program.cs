// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Enter num1: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.WriteLine("Enter num2: ");
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);

if (num1==num2*num2)
Console.WriteLine ("First number is a square of second number");
else
Console.WriteLine ("First number isn't a square of second number");