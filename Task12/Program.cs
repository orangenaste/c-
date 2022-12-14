// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.WriteLine("Enter num1: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.WriteLine("Enter num2: ");
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);

int result =(num1 % num2);
if(result == 0)
Console.WriteLine ("multiple");
else
Console.WriteLine ("Not multiple. Remainder of division: " +result); 
