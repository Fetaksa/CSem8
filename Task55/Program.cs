// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int temp = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }

    return matrix;
}

if (matrixRnd.GetLength(0) == matrixRnd.GetLength(1))
{
    int[,] replaceMatrix = ReplaceRowsToColumns(matrixRnd);
    PrintMatrix(matrixRnd);
}
else Console.WriteLine("Вводите массив с равным количеством столбцов и строк");