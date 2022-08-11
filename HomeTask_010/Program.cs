Console.WriteLine("Введите трёхзначное число");
string str = Console.ReadLine();
if (str.Length <= 3 && str.Length > 2)
{
    Console.Write("Вторая цифра числа - ");
    Console.WriteLine(str[1]);
}
else
{
    Console.Write("Число НЕ трёхзначное ");
}
