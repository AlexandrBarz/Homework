//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double GetRandomNumber(double minimum, double maximum)
// {

//     return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum, 1);
// }




// Console.WriteLine("Укажите диапазон чисел для заполнения массива");

int maximum = 10;

Console.WriteLine("Введите количестов строк в массиве: ");
Console.WriteLine("Введите количество столбцов в массиве: ");

double[,] doubarray = new double[,];
for (i = 0; i < doubarray.GetLength(0); i++)
{
    for (j = 0; j < doubarray.GetLength(1); j++)
    {
        doubarray[i,j]=Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum, 1);
        Console.WriteLine(doubarray[j,j]=);
    }
}