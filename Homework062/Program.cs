// Напишите программу, которая заполнит спирально массив 4 на 4.
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] SpiralArray(int row, int column)
{
    int k = 1;
    int i = 0;
    int j = 0;
    int ibeg = 0;
    int iend = 0;
    int jbeg = 0;
    int jend = 0;
    int[,] array = new int[row, column];
    while (k <= row * column)
    {
        array[i, j] = k;
        if (i == ibeg && j < column - jend - 1) j++;
        else if (j == column - jend - 1 && i < row - iend - 1) i++;
        else if (i == row - iend - 1 && j > jbeg) j--;
        else i--;
        if ((i == ibeg + 1) && (j == jbeg) && (jbeg != column - jend - 1))
        {
            ibeg++;
            iend++;
            jbeg++;
            jend++;
        }
        k++;
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

int row = ReadData("Введите кол-во строк в массиве: ");
int column = ReadData("Введите кол-во столбцов в массиве: ");
int[,] sparray = SpiralArray(row, column);
PrintArray(sparray);
Console.ReadKey();