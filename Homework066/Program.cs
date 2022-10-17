// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SummaElements(int[] elements)
{
    int sum = 0;
    for (int i = 0; i < elements.Length; i++)
    {
        sum = sum + elements[i];
    }
    return sum;
}

int[] FillArr(int lowbord, int highbord)
{
    int[] array = new int[(highbord + 1) - lowbord];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = lowbord;
        lowbord++;
    }
    return array;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
}

int m = ReadData("Введите нижнюю границу диапазона натуральных чисел: ");
int n = ReadData("Введите верхнюю границу диапазона натуральных чисел: ");
int[] array = FillArr(m, n);
PrintArr(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} = {SummaElements(array)}");
Console.ReadKey();