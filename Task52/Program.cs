// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = MatrixArray(3, 4, 1, 10);
PrintMatrix(array);

double[] myArray = SumMultiply(array);

PrintArray(myArray);

double[] SumMultiply(int[,] matrix)
{
    double res = 0;
    double[] sum = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res += matrix[i, j];
        }
        res = res / matrix.GetLength(0);
        res = Math.Round(res, 1, MidpointRounding.ToZero);
        sum[j] = res;
        res = 0;
    }
    return sum;
}

int[,] MatrixArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j],2} | ");
            }
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: |");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}; ");
        }
        else Console.Write($"{arr[i]}");
    }
    Console.Write("|");
}

