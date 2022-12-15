//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int 
static void ViewaThirdDigit2(int num, int index = 3);
{
Console.Clear();

// if (num-100<0)
if (num < 100)
{
    Console.WriteLine("The third digit doesn't exist");
   return;
}
while (num > 100)
{ num /= 10;
    //int thirdDigit = (num/100)%10;
    // int firstDigit = num / 100;
    // int secondDigit = (num/10)%10;
    // int thirdDigit = num%10;
Console.WriteLine($"Third digit of {num} is {thirdDigit}");
}}