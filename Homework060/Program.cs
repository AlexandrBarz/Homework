// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int element, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (array[i, j, z] == element) return true;
            }
        }
    }
    return false;
}

int[,,] FillArray(int lowbord, int highbord)
{
    int[,,] array = new int[2, 2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int rnd = new Random().Next(lowbord, highbord + 1);
                if (!FindElement(rnd, array))
                {
                    array[i, j, k] = rnd;
                    k++;
                }
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

int lowbord = ReadData("Введите нижнюю границу диапазона двухзначных чисел для заполнения массива: ");
int highbord = ReadData("Введите верхнюю границу диапазона двухзначных чисел для заполнения массива: ");
if (lowbord > 9 && highbord < 100) PrintArray(FillArray(lowbord, highbord));
else Console.WriteLine("Неверно введен диапазон. Попробуйте снова");
Console.ReadKey();