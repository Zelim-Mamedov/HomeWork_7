// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine("Введите индексы элемента:");
Console.Write("Индекс строки: ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс столбца: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());
if (indexRows < 0 || indexColumns < 0)
{
    Console.WriteLine("Ошибка! Введенный индекс должен быть не меньше нуля.");
    return;
}                                                              
if (indexRows > matrix.GetLength(0) || indexColumns > matrix.GetLength(1))
{
    Console.WriteLine($"{indexRows}, {indexColumns} -> такого элемента в массиве нет.");
    return;
}
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Элемент под этими индексами {indexRows} и {indexColumns} найден -> {matrix[indexRows, indexColumns]}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
                Console.Write($"{matrix[i, j], 2} | ");
            }
            else Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}