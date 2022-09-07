// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
int count = N;
NaturalNumbers(M, count);

void NaturalNumbers(int M, int count)
{
    if(M > count)
    {
        return;
    }
    else
    {
        NaturalNumbers(M, count - 1);
        Console.Write(count + " ");
    }
}