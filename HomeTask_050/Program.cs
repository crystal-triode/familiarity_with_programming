// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 5
// 17 -> такого числа в массиве нет

//using static System.ValueTuple;

Console.WriteLine("Введите количество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
Console.WriteLine("Введите искомое число от -20 до 20 ");
double Number = Convert.ToDouble(Console.ReadLine());
FillArray(numbers);
NumberSearch(numbers);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-20, 20));
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void NumberSearch(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == Number)
            {
                Console.WriteLine($"Позиция элемента: индекс строки - {i}; индекс столбца - {j}");
            }
        }
    }
    Console.WriteLine("Больше такого элемента в массиве нет");
}
