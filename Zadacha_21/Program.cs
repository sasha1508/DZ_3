// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введи для точки A координату X: ");
int AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи для точки A координату Y: ");
int AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи для точки A координату Z: ");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи для точки B координату X: ");
int BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи для точки B координату Y: ");
int BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи для точки B координату Z: ");
int BZ = Convert.ToInt32(Console.ReadLine());

double rasstoyanie = Math.Round(Math.Sqrt(Math.Pow(AX-BX, 2) + Math.Pow(AY-BY, 2) + Math.Pow(AZ-BZ, 2)), 2);
Console.WriteLine("Расстояние между точками А и В равно " + rasstoyanie);