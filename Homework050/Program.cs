// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] GetArray(int row, int column, int lowbord, int highbord)
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

void PrintArray(int[,] randomarray)
{
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            Console.Write($"{randomarray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите кол-во строк в массиве: ");
int column = ReadData("Введите кол-во столбцов в массиве: ");
int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
int[,] newarray = GetArray(row, column, lowbord, highbord);
PrintArray(newarray);
int i = ReadData("Введите номер строки: ");
int j = ReadData("Введите номер столбца: ");
if (i > (row - 1) && j > (column - 1))
{
    Console.WriteLine($"Массив меньше введенных парfметров и элемента {newarray[i, j]} не существует");
}
else
{
    int element = newarray[i - 1, j - 1];
    ReadData($"Значение элемента на указанной позиции: {element}");
}
Console.ReadKey();