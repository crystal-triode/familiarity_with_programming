// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double getDistance (int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}
;

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("ax?");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("ay?");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("az?");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("bx?");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("by?");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("bz?");
int bz = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками =  {getDistance (ax, ay, az, bx, by, bz)}"); 