// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да 

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if ((num % 7==0) && (num % 23==0))
{
    Console.WriteLine("multiply");
}
else
{
    Console.WriteLine("not multiply");
}