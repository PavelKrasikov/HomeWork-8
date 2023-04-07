/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int minSum (int[,] array)
{
    int minRow = 1;
    int sumLine = sumRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int min = sumRow (array, i);
        if (sumLine > min)
         { sumLine = min;
           minRow = i + 1;
         }
    }
    return minRow;
}

int sumRow(int[,] arr, int i)
{
  int sum = arr[i, 0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sum = sum + arr[i, j];
  }
  return sum;
}

int[,] Massive = new int[6, 5];
FillArr(Massive);
PrintArr(Massive);
Console.WriteLine();
Console.WriteLine($"{minSum(Massive)}-ая" + " строка с наименьшей суммой");


