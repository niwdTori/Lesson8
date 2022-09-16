// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine();


for (int i = 0; i < array.GetLength(0); i++)
{
     for (int n = array.GetLength(1); n > 0; n--)
     {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if(array[i,j] < array[i,j+1])
            {
                int temp = array[i,j];
                array[i,j] = array[i,j+1];
                array[i,j+1] = temp;
            }
        }
    }
}
PrintArray(array);   

