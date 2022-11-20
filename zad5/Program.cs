/*
Задача 46
Задайте двумерный массив, размером  MxN заполненный случайными целыми числами
*/

int[,] IntMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

int[,] matrix = IntMatrix(m, n);
PrintMatrix(matrix);

