// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();
Write("Введите размер матрицы через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1]);
PrintMatrix(matrix);
srArif(matrix);

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

int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

void srArif(int[,] inMatrix)
{
    for (int j = 0; j < inMatrix.GetLength(1); j++)
    {
        double chislo = 0;
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            chislo += inMatrix[i, j]; 
            //Write($"{chislo:f1}, ");
        }
        double result = chislo / inMatrix.GetLength(0);
        Write($"{result:f1}\t ");
        //WriteLine();
    }
}


