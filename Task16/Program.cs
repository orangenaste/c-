// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет 

Console.WriteLine("Enter num1: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.WriteLine("Enter num2: ");
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);

int sqr;
if (num1>num2)
{
    sqr = num2*num2;
    if (sqr == num1)
    Console.WriteLine ("First number is a square of second number");
    else
    {Console.WriteLine ("First number isn't a square of second number");}
    }
else {sqr = num1*num1;
    if (sqr == num2)
    Console.WriteLine ("Second number is a square of first number");
    else
    {Console.WriteLine ("Second number isn't a square of first number");}}

