// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows, columns];
FillArray(array);
Average(array);

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-20, 20);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
void Average(int [,]array)
{
  double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = Math.Round(average / array.GetLength(0), 1, MidpointRounding.ToZero);
        Console.Write($" {average}; ");
        average = 0;
    }
}