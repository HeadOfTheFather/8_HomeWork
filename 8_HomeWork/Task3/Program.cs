/*Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
*/

Random fillerForMatrix = new Random();
int matrixResolution = fillerForMatrix.Next(2,3);
int[,] matrixA = new int[matrixResolution,matrixResolution];
int[,] matrixB = new int[matrixResolution,matrixResolution];
void SquareMatrixFillerWithRandom(int[,] matrix)
{
    Random filler = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = filler.Next(10);
        }
    }
}
int[,] MatrixMultiplicator(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(0)];
    for(int i = 0; i < matrixC.GetLength(0); i++)
    {
        for(int j = 0; j < matrixC.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
             for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
        }
    }
    return matrixC; 
}
void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
SquareMatrixFillerWithRandom(matrixA);
SquareMatrixFillerWithRandom(matrixB);
int[,] matrixX = MatrixMultiplicator(matrixA,matrixB);
Console.WriteLine("Matrix A:");
PrintMatrix(matrixA);
Console.WriteLine("Matrix B:");
PrintMatrix(matrixB);
Console.WriteLine("Matrix A x B:");
PrintMatrix(matrixX);