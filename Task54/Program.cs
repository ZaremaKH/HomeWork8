// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
// двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortDecrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = array[i, z + 1];
                    array[i, z + 1] = array[i, z];
                    array[i, z] = temp;
                }
            }
        }

    }
}

Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortDecrease(array);
PrintArray(array);


