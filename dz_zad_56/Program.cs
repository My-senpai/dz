/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] array = initArray();
PrintArray(array);
System.Console.WriteLine();

int[] sum = sumArrayRow(array);

System.Console.WriteLine($"строка с минимальной суммой - {minRowArrSum(sum)}");



int[,] initArray()
{
    int[,] array = new int[3, 3];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"|{array[i, j] + "\t"}");
        }
        System.Console.WriteLine();
    }

}

int[] sumArrayRow(int[,] array)
{
    int[] arrayRowSum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRowSum[j] = arrayRowSum[j] + array[i, j];
        }
    }
    return arrayRowSum;
}

int minRowArrSum(int[] sum)
{
    int minSum = sum[0];
    int minimalIndex = 1;
    for (int i = 0; i < sum.Length; i++)
    {
        if (minSum < sum[i]) minimalIndex = i ;

    }
    return minimalIndex;
}







