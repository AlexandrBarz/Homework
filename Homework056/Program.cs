// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void MinSumElements(int[,] array)
{
    int minsum = Int32.MaxValue;
    int numberrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки = {sumrow}");
        if (sumrow < minsum)
        {
            minsum = sumrow;
            numberrow = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов под номером {numberrow}");
}

int rows = ReadData("Введите кол-во строк в массиве: ");
int columns = ReadData("Введите кол-во столбцов в массиве: ");
int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
int[,] newarray = FillArray(rows, columns, lowbord, highbord);
PrintArray(newarray);
MinSumElements(newarray);
Console.ReadKey();