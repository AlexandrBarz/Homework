// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] FillArray(int lowbord, int highbord)
{
    int[,,] array = new int[2, 2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(lowbord, highbord + 1);
                // int temp = array[i, j, k];
                // if (temp == array[i, j, k]) 
                // Console.WriteLine(temp);
            }
        }
    }
    return array;
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int lowbord = ReadData("Введите нижнюю границу диапазона чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона чисел для заполнения массива: ");
PrintArray(FillArray(lowbord, highbord));
Console.ReadKey();