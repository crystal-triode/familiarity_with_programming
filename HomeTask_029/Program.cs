// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int N = 8;
int min = 1,
    max = 50;

int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(min, max);
}

for (int i = 0; i < N; i++)
{
    Console.Write(array[i] + " ");
}
