// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter num1: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.WriteLine("Enter num2: ");
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);

if (num1>num2)
Console.WriteLine ($"max num = {num1}");
else
Console.WriteLine ($"max num = {num2}");