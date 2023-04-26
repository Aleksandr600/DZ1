// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine ("Введите координату точки А");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите координату точки А");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите координату точки А");
double z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите координату точки B");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите координату точки B");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите координату точки B");
double z2 = Convert.ToInt32 (Console.ReadLine());

double line = Math.Sqrt(Math.Pow(x1 - x2, 2)+Math.Pow (y1 - y2, 2)+Math.Pow (z1 - z2, 2));
System.Console.WriteLine(Math.Round(line, 2));
