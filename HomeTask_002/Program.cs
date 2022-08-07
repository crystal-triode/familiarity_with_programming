Console.WriteLine("Введите число 1 ");
int numberA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int numberB = int.Parse (Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Максимальное число = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("Максимальное число = ");
    Console.WriteLine(numberB); 
}
