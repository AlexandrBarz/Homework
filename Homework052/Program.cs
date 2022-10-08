// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

double ArithMean(double x, int value)
{
    int couvant=0;
}

int row = ReadData("Введите кол-во строк в массиве: ");
int column = ReadData("Введите кол-во столбцов в массиве: ");
int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
int[,] newarray = FillArray(row, column, lowbord, highbord);
PrintArray(newarray);
double arithmean = 0;
int count = 0;
for (column = 0; column < newarray.GetLength(1); column++)
{
    for (row = 0; row < newarray.GetLength(0); row++)
    {
        count++;
        arithmean = arithmean + newarray[column, row] / count;
        Console.WriteLine($"Среденефрифметическое {column} столбца = {arithmean}");
    }
}