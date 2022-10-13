// : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int row, int column, int lowbord, int highbord)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(lowbord, highbord + 1);
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
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

int rows1 = ReadData("Введите кол-во строк в массиве 1: ");
int columns1 = ReadData("Введите кол-во столбцов в массиве 1: ");
int rows2 = ReadData("Введите кол-во строк в массиве 2: ");
int columns2 = ReadData("Введите кол-во столбцов в массиве 2: ");
if (columns1 == rows2)
{
    int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
    int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
    Console.WriteLine(@"
    Матрица 1:");
    PrintArray(FillArray(rows1, columns1, lowbord, highbord));
    Console.WriteLine(@"
    Матрица 2:");
    PrintArray(FillArray(rows2, columns2, lowbord, highbord));
    Console.WriteLine(@"
    Результат произведения двух матриц:");
    PrintArray(MultiplicationMatrix(FillArray(rows1, columns1, lowbord, highbord), FillArray(rows2, columns2, lowbord, highbord)));
    Console.ReadKey();
}
else
{
    Console.WriteLine("Матрицы нельзя перемножить.");
    Console.ReadKey();    
}