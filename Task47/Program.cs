// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
double[,] matrix = GetMatrixArray(parameters[0], parameters[1]);
PrintMatrix(matrix);


int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}


double[,] GetMatrixArray(int rows, int columns)
{
    double[,] resultMatrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = rnd.NextDouble()*20-10;
        }
    }
    return resultMatrix;
}

void PrintMatrix(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]:f1}\t");
        }
        WriteLine();
    }
}
