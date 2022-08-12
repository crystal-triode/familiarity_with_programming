Console.WriteLine("Введите число ");
string str = Console.ReadLine();
if (str.Length >= 3)
{
    Console.WriteLine("Третья цифра числа - ");
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры НЕТ");
}