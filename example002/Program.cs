// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double x1, x2, y1, y2, z1, z2;

x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());

x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToInt32(Console.ReadLine());
z2 = Convert.ToDouble(Console.ReadLine());

double AB = 0;
AB= Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

Console.WriteLine($"Расстояние между точками в 3д пространстве: {AB}");

