// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,] CreateRandomArray(int line, int column, int start, int end)
{
    double [,] RandomArray = new double [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomArray[i, j] = Convert.ToDouble(new Random().Next(start, end)) / 10;
        }
    }
    return RandomArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double [,] matr = CreateRandomArray(3,4,-1,1);
ShowArray (matr);