// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] generateArray ( int lenght = 6, int min = 10, int max = 100)
{
    int[] result = new int[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int [] array = generateArray();

int sumOfOdd(int[] array) 
    {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) 
        {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
        }
        return sum;
    }
    int Sum = sumOfOdd (array);
Console.WriteLine ($"Сгенерированный массив :[{string.Join (",", array)}]");
Console.WriteLine ("Сумма нечётных позиций массива: " + Sum);