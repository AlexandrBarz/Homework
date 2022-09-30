// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int[] FillArr(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrlen = ReadData("Введите длину массива: ");
int[] arr = FillArr(arrlen);
PrintArr(arr);
int count = 0;
for (int i = 0; i < arrlen; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(" ");
Console.WriteLine("Кол-во четных чисел в заданном массиве: " + count);