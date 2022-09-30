// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
double[] FillArr(int len, int lowbord, int highbord)
{
    //using Random = System.Random;
    double[] array = new double[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(lowbord, highbord + 1) + Convert.ToDouble(new Random().Next(lowbord, highbord + 1)) / 10;
    }
    return array;
}
void PrintArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "  ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrlen = ReadData("Введите длину массива: ");
int lowbord = ReadData("Введите нижнюю границу чисел: ");
int highbord = ReadData("Введите верхнюю границу чисел: ");
double[] arr = FillArr(arrlen, lowbord, highbord);
PrintArr(arr);
double max = arr[0];
double min = arr[0];
for (int i = 1; i < arrlen; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        i++;
    }
    if (arr[i] < min)
    {
        min = arr[i];
        i++;
    }
}
double diff = max - min;
Console.WriteLine(" ");
Console.WriteLine($"Разница между max {max} и min {min} элементами массива = {diff}");
Console.ReadKey();