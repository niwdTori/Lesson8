// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintNewArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int rows = 4;
int columns = 4;

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine();

int[] mas = new int[rows];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    mas[i] = sum;
}

PrintNewArray(mas);
Console.WriteLine();

int result = 1;
int minEl = mas[0];
for (int i = 1; i < mas.Length; i++)
{
    if(mas[i] < minEl)
    {
    minEl = mas[i];
    result = i+1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");