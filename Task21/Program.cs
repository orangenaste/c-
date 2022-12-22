// Задача 21 Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter the x-coordinate of the first point: ");
string s_x1 = Console.ReadLine();
int x1 = Convert.ToInt32(s_x1);
Console.WriteLine("Enter the y-coordinate of the first point: ");
string s_y1 = Console.ReadLine();
int y1 = Convert.ToInt32(s_y1);
Console.WriteLine("Enter the z-coordinate of the first point: ");
string s_z1 = Console.ReadLine();
int z1 = Convert.ToInt32(s_z1);
Console.WriteLine("Enter the x-coordinate of the second point: ");
string s_x2 = Console.ReadLine();
int x2 = Convert.ToInt32(s_x2);
Console.WriteLine("Enter the y-coordinate of the second point: ");
string s_y2 = Console.ReadLine();
int y2 = Convert.ToInt32(s_y2);
Console.WriteLine("Enter the z-coordinate of the second point: ");
string s_z2 = Console.ReadLine();
int z2 = Convert.ToInt32(s_z2);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double distance = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"The distance between coordinates in 3D space is  {distance}");
