// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter num1: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.WriteLine("Enter num2: ");
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);
Console.WriteLine("Enter num3: ");
string s_num3 = Console.ReadLine();
int num3 = Convert.ToInt32(s_num3);
int max = num1;

if(num1>max) max = num1;
if(num2>max) max = num2;
if(num3>max) max = num3;

Console.WriteLine ("max = ");
Console.WriteLine(max);
