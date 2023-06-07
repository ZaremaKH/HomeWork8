// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    // Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiMatrix(int[,] firstMatrix, int[,] secondMatrix, int [,] resultMatrix)
{
    int result = 0;
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
       for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            result = 0;
            for (int z = 0; z < firstMatrix.GetLength(1); z++)
            {
                result += firstMatrix[i,z] * secondMatrix[z,j];
            }
            resultMatrix[i,j] = result;
        }
    }
}


Console.Write("Введите количество строк для первой матрицы: ");
int rowFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int columnFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк для второй матрицы: ");
int rowSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int columnSecondMatrix = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[rowFirstMatrix, columnFirstMatrix];
int[,] secondMatrix = new int[rowSecondMatrix, columnSecondMatrix];
int[,] resultMatrix = new int[rowFirstMatrix, columnSecondMatrix];
FillArray(firstMatrix);
Console.WriteLine("Первая матрица");
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица");
PrintArray(secondMatrix);
Console.WriteLine();
MultiMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение двух матриц");
PrintArray(resultMatrix);
