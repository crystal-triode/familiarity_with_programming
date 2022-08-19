// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum (int N)
{
    int Length = Convert.ToString(N).Length;
    int dif = 0;
    int result = 0;

    for (int i = 0; i < Length; i++)
    {
        dif = N - N % 10;
        result = result + (N - dif);
        N = N / 10;
    }
    return result;
}

int sum = Sum(N);
Console.WriteLine("Сумма цифр в числе: " + sum);
