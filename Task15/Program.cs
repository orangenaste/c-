// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number from 1 to 7: "); 
int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 4) 
{ 
Console.WriteLine("It's a weekday"); 
} 
else if (num >= 6 && num <= 7) 
{ 
Console.WriteLine("It's a weekend!"); 
} 
else if (num==5)
{
    Console.WriteLine("TGIF!");   
}
else Console.WriteLine("This day of the week doesn't exist. Try again!");  