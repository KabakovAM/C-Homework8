// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int n)
{
    int i = 0;
    int j = -1;
    int count = 1;
    int upborder = n;
    int rightborder = n;
    int downborder = -1;
    int leftborder = 0;
    int[,] matrix = new int[n, n];
    while (count != n * n + 1)
    {
        for (j++; j < upborder; j++)
        {
            matrix[i, j] = count;
            count++;
        }
        j--;
        upborder--;
        for (i++; i < rightborder; i++)
        {
            matrix[i, j] = count;
            count++;
        }
        i--;
        rightborder--;
        for (j--; j > downborder; j--)
        {
            matrix[i, j] = count;
            count++;
        }
        j++;
        downborder++;
        for (i--; i > leftborder; i--)
        {
            matrix[i, j] = count;
            count++;
        }
        i++;
        leftborder++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.WriteLine($"{matrix[i, j],3}]");
        }
    }
}

int[,] mat = CreateSpiralMatrix(4);
PrintMatrix(mat);

