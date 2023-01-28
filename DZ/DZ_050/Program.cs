// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
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

void FindNumberInArray (int [,] array, int n, int m){
    if (n>=array.GetLength(0)||m>=array.GetLength(1)){
        Console.WriteLine("Вы ввели неверный запрос, номер стоки или столбца должен быть меньше запрашиваемой");
    }
    else{
        Console.WriteLine($"По заданным координатам находится число {array[n-1,m-1]}");
    }
}

int [,] matr = CreateRandomArray(5,8,0,10);
ShowArray(matr);
Console.WriteLine("Введите номер строки в которой вы хотите найти число ");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца в которой вы хотите найти число ");
int column1 = Convert.ToInt32(Console.ReadLine());
FindNumberInArray(matr,line1,column1);