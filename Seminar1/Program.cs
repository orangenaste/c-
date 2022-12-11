// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

int sqr = num * num;

Console.WriteLine($"Sqr = {sqr} ");