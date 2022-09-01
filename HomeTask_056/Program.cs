// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите размер квадратного массива");
int arraySide = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[arraySide, arraySide];
FillArray(numbers);
PrintArray(numbers);
int minSumRow = Int32.MaxValue;
int indexRow = 0;
SearchMinRow(numbers);

void SearchMinRow(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            indexRow++;
        }
    }

    Console.WriteLine(
        $"Номер строки с наименьшей суммой елементов: {indexRow} . Сумма элементов = {minSumRow}"
    );
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
