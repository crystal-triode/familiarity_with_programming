// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] RealNumbers = new double[8];
  for (int i = 0; i < RealNumbers.Length; i++ )
  {
    RealNumbers[i] = new Random().Next(1, 50);
    Console.Write(RealNumbers[i] + " ");
  }

double max = RealNumbers[0];
double min = RealNumbers[0];

  for (int i = 1; i < RealNumbers.Length; i++)
  {
    if (max < RealNumbers[i])
    {
      max = RealNumbers[i];
    }
        if (min > RealNumbers[i])
    {
      min = RealNumbers[i];
    }
  }

  double diff = max - min;

  Console.Write($"\nразница между между максимальным ({max}) и минимальным({min}) элементами: {diff}");