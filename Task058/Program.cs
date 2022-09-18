// Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
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

void PrintMatrix(int[,] matr)
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

void FillNewMatrix(int[,] firstMatr, int[,] secondMatrix, int[,] newMatr)
{
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatrix[k, j];
            }
            newMatr[i, j] = sum;
        }
    }
}

void PrintTwoMatrix(int[,] matr1, int[,] matr2)
{
    int sizeRows = matr1.GetLength(0);
    int[,] temporary = matr2;
    if (matr1.GetLength(0) > matr2.GetLength(0))
    {
        sizeRows = matr2.GetLength(0);
        temporary = matr1;
    }

    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.Write("| ");
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i, j]} ");
        }
        Console.WriteLine();
    }

    for (int i = sizeRows; i < temporary.GetLength(0); i++)
    {
        if (matr2.GetLength(0) > matr1.GetLength(0))
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                Console.Write("  ");
            }
            Console.Write("| ");
            for (int j = 0; j < temporary.GetLength(1); j++)
            {
                Console.Write($"{temporary[i, j]} ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 0; j < temporary.GetLength(1); j++)
            {
                Console.Write($"{temporary[i, j]} ");
            }
            Console.Write("| ");
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите колличество строк ПЕРВОЙ матрицы: ");
int rowsFirstMatrix = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ПЕРВОЙ (строк ВТОРОЙ) матрицы: ");
int columnsAndRowsMatrix = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов ВТОРОЙ матрицы: ");
int columnsSecondMatrix = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] firstMatrix = GetMatrix(rowsFirstMatrix, columnsAndRowsMatrix, 1, 9);
int[,] secondMatrix = GetMatrix(columnsAndRowsMatrix, columnsSecondMatrix, 1, 9);
PrintTwoMatrix(firstMatrix, secondMatrix);
Console.WriteLine();

int[,] newMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
FillNewMatrix(firstMatrix, secondMatrix, newMatrix);
PrintMatrix(newMatrix);
