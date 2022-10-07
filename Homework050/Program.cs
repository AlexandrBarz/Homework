// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

int row = ReadData("Введите кол-во строк в массиве: ");
int column = ReadData("Введите кол-во столбцов в массиве: ");
int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
int[,] newarray = FillArray(row, column, lowbord, highbord);
PrintArray(newarray);
Console.WriteLine("Для выбора элемента введите следующие данные: ");
int indexrow = ReadData("\t1. номер строки: ")-1;
int indexcolumn = ReadData("\t2. номер столбца: ")-1;
if (indexrow < newarray.GetLength(0) && indexcolumn < newarray.GetLength(1))
{
    Console.WriteLine($"Значение элемента на указанной позиции newarray[{indexrow},{indexcolumn}]: {newarray[indexrow, indexcolumn]}");
}
else
{
    Console.WriteLine($"Элемента с индексом [{indexrow},{indexcolumn}] не существует в данном массиве");
}
Console.ReadKey();