/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


double[,] initArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i,j] = Math.Round(rnd.NextDouble() * 100 - 20, 3);
        }

    }
    return array;
}



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


System.Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());

double[,] a = initArray(m,n);
PrintArray(a);



















