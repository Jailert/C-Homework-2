// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Enter first point coordinates :");

double x1 = int.Parse(Console.ReadLine() ?? "0"); 
double y1 = int.Parse(Console.ReadLine() ?? "0");
double z1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter second point coordinates :");

double x2 = int.Parse(Console.ReadLine() ?? "0");
double y2 = int.Parse(Console.ReadLine() ?? "0");
double z2 = int.Parse(Console.ReadLine() ?? "0");

double dist = Math.Sqrt(Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2));

Console.WriteLine("Our distance :");
Console.WriteLine(dist);
