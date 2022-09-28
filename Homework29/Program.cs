// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int[] FillArr(int len, int lowbord, int highbord)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(lowbord, highbord + 1);
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
int lowbord = ReadData("Введите нижнюю границу чисел: ");
int highbord = ReadData("Введите верхнюю границу чисел: ");
int[] arr = FillArr(arrlen, lowbord, highbord);
PrintArr(arr);