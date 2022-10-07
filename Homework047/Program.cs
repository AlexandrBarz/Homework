//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int row = ReadData("Введите количестов строк в массиве: ");
int column = ReadData("Введите количество столбцов в массиве: ");
int minimum = ReadData("Укажите нижнюю границу диапазона чисел для заполнения массива: ");
int maximum = ReadData("Укажите нижнюю верхнюю границу диапазона чисел для заполнения массива: ");
double[,] doubarray = new double[row, column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        doubarray[i, j] = Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum, 1);
        Console.Write($"{doubarray[i, j]} \t");
    }
    Console.WriteLine();
}