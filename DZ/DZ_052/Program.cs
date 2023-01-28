// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateRandomArray(int line, int column, int start, int end)
{
    int[,] RandomArray = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomArray[i, j] = new Random().Next(start, end + 1);
        }
    }
    return RandomArray;
}

void ShowArray(int[,] array)

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

void Average(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + array[i, j];

        }
        double aver =  (double)summ / array.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {j+1} равно {Math.Round (aver,2)} ");
    }
}

int[,] matr = CreateRandomArray(3, 3, 5, 10);
ShowArray(matr);
Average(matr);