/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] GetRandomArray()
{
    var result = new double[10];
    Random rnd = new Random();
    for (var i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 101);
    }
    return result;
}

void Print(double[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > (array[i]))
            min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < (array[i]))
            max = array[i];
    }
    return max;
}


double[] x = GetRandomArray();
Print(x);
System.Console.WriteLine($"{GetMax(x) - GetMin(x)}");



































































/*
var[] PositiveArray()
{
    var[] result = new var[10];
    Random rnd = new Random();
    for (var i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 101);
    }
    return result;
}

void Prvar(var[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double min = var32.MinValue;
double max = var32.MaxValue;

for (var i = 0; i < length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}







var[] arry = PositiveArray();
Prvar(arry);
summa(arry);
*/

