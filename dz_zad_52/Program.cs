/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] initArray()
{
    int[,] array = new int[5, 5];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rnd.Next(100);
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
            Console.Write($"{array[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}

double[] average(int[,] array)
{
    double[] averageArray = new double[array.GetLength(0)];
    for (int x = 0; x < array.GetLength(0); x++)
    {
        var columsSum = 0;
        for (int y = 0; y < array.GetLength(1); y++)
        {
            columsSum += array[x, y];
            averageArray[x] = (float)columsSum / (x + 1);
        }
    }
    return averageArray;
}


void PrintArrayFormat(double[] divArr)
{
    string res = $"{divArr[0]:0.0}";
    for (int i = 1; i < divArr.Length; i++)
    {
        res = res + "; " + $"{divArr[i]:0.0}";
    }
    Console.WriteLine(res);

}



int[,] array = initArray();
PrintArray(array);
var res = average(array);
PrintArrayFormat(res);


