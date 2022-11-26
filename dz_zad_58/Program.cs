int firstMatrixRows = GetNumber("Введите число строк первой матрицы: ");
int firstMatrixColumns = GetNumber("Введите число столбцов  первой матрицы: ");
int secondMatrixRows = GetNumber("Введите число строк второй матрицы: ");
int secondMatrixColumns = GetNumber("Введите число столбцов второй матрицы: ");

int mMultRow;
int mMultCoumn;
int[,] tempOne;
int[,] tempTwo;

int GetNumber(string message)
{
    Console.Write(message);
    int useNum = Convert.ToInt32(Console.ReadLine()); ;
    return useNum;
}

Random rnd = new Random();
void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] tempArray = new int[m, n];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 10);
        }
    }

    return tempArray;
}

int[,] MatrixMulti(int[,] mOne, int[,] mTwo)
{

    if (mOne.GetLength(1) == mOne.GetLength(0))
    {
        tempOne = mOne;
        tempTwo = mTwo;
        mMultRow = mOne.GetLength(0);
        mMultCoumn = mTwo.GetLength(1);

    }
    else
    {
        tempOne = mTwo;
        tempTwo = mOne;
        mMultRow = mTwo.GetLength(0);
        mMultCoumn = mOne.GetLength(1);
    }
    int[,] mMult = new int[mMultRow, mMultCoumn];
    for (int i = 0; i < mMult.GetLength(0); i++)
    {
        for (int j = 0; j < mMult.GetLength(1); j++)
        {
            for (int k = 0; k < tempOne.GetLength(1); k++)
            {
                mMult[i, j] = mMult[i, j] + tempOne[i, k] * tempTwo[k, j];
            }
        }
    }
    return mMult;
}

if (firstMatrixRows == secondMatrixColumns || firstMatrixColumns == secondMatrixRows)
{
    int[,] firstMatrix = FillArray(firstMatrixRows, firstMatrixColumns);
    int[,] secondMatrix = FillArray(secondMatrixRows, secondMatrixColumns);
    PrintArray(firstMatrix);
    Console.WriteLine("*");
    PrintArray(secondMatrix);
    int[,] matrixMult = MatrixMulti(firstMatrix, secondMatrix);
    Console.WriteLine("|\n---");
    Console.WriteLine("Произведение матриц\n|\n---");
    PrintArray(matrixMult);
}
else
    Console.WriteLine("Таких матриц нет.");