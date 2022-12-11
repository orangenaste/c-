//  Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if(num % 2 == 0)
Console.WriteLine("Even number");
else
Console.WriteLine("Not even number");