// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X для точки A: "); 
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y для точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z для точки A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X для точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y для точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z для точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($"{res:f3}");
