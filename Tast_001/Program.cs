// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите позицию строки: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int stl = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[,]
{
    {3, 5, 77, 1, 99},
    {25, 1, 15, 9, 11},
    {13, 51, 5, 88, 41},
    {2, 15, 71, 9, 10}

};

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            Console.Write(matrixForPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);

if (str < matrix.GetLength(0) && stl < matrix.GetLength(1))
    Console.Write($"Значение элемента равно: {matrix[str, stl]} ");
else Console.Write("Такого элемента нет в массиве: ");

