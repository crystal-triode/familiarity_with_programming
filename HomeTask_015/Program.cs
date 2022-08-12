Console.WriteLine("Введите число, обозначающее день недели (от 1 до 7)");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Ура! Это же выходной");
}
else if (num >= 7 || num < 0)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine("Печально! Нужно идти на работу");
}
