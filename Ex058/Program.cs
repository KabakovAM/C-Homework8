// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateFillMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] MatrixMultipl(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int m = 0; m < matrixA.GetLength(0); m++)
            {
                result[i, j]+= matrixA[i, m] * matrixB[m, j];
            }
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.WriteLine($"{matrix[i, j],2}]");
        }
    }
}

int[,] mat = CreateFillMatrix(2, 2, 1, 9);
int[,] mat2 = CreateFillMatrix(2, 2, 1, 9);
PrintMatrix(mat);
Console.WriteLine();
PrintMatrix(mat2);
Console.WriteLine();
int[,] res = MatrixMultipl(mat, mat2);
PrintMatrix(res);
