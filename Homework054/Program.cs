// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int row, int column, int lowbord, int highbord)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(lowbord, highbord + 1);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[] SortArray(int[] matrix, int[] array)
{
    int[] outs = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                array[i] = matrix[x, y];
                outs[i]++;
            }
            //     Array.Sort(array);
            //     Array.Reverse(array);
            //     Console.WriteLine(outs[i]);
        }
        Console.WriteLine(outs[i]);
    }
    return outs;
}

int rows = ReadData("Введите кол-во строк в массиве: ");
int columns = ReadData("Введите кол-во столбцов в массиве: ");
int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
int[,] newarray = GetArray(rows, columns, lowbord, highbord);
int[] rowarray = SortArray(newarray);
