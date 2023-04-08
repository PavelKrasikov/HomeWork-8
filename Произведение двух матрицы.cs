/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


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


int[,] matr1 = new int[2, 2];
Console.WriteLine("1st Matrix; ");
FillArr(matr1);
PrintArr(matr1);
Console.WriteLine("2nd Matrix; ");
int[,] matr2 = new int[2, 2];
FillArr(matr2);
PrintArr(matr2);

int[,] productmatr = new int[2, 2];
Productmatrix(matr1, matr2, productmatr);
Console.WriteLine($"Произведение матриц =");
PrintArr(productmatr);

void Productmatrix (int[,] matr1, int[,] matr2, int[,] productmatr)
{
  for (int i = 0; i < productmatr.GetLength(0); i++)
  {
    for (int j = 0; j < productmatr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum += matr1[i,k] * matr2[k,j];
      }
      productmatr[i,j] = sum;
    }
  }
}
