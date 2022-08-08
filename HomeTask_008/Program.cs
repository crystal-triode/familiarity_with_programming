int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N && N > 0)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
