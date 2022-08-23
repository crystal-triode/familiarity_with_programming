// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int [] generateArray ( int lenght = 10, int min = 100, int max = 1000)
{
    int[] result = new int[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int [] array = generateArray();

int NumberOfEven (int [] array)
{
    int Number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            Number ++;
        } 
    }
    return Number;
}
int number = NumberOfEven(array);
Console.WriteLine ($"Сгенерированный массив :[{string.Join (",", array)}]");
Console.WriteLine ("Количество чётных элементов: " + number);