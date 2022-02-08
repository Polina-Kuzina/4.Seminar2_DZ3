// 22. Найти расстояние между точками в пространстве 2D/3D

// Для 3D:
Console.WriteLine("Ведите координаты точки А: ");
int xa = int.Parse(Console.ReadLine());
int ya = int.Parse(Console.ReadLine());
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите координаты точки B: ");
int xb = int.Parse(Console.ReadLine());
int yb = int.Parse(Console.ReadLine());
int zb = int.Parse(Console.ReadLine());
double AB = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine("Расстояние между точками = " + AB);