Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();
if (str[0] == str[4] || str[1] == str[3])
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это НЕ палиндром");
}
