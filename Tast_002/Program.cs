// Задача 2: Задайте двумерный массив. Напишите         4 3 1 => 4 6 2
// программу, которая поменяет местами первую и         2 6 9    2 6 9
// последнюю строку массива.                            4 6 2    4 3 1

int[,] array = new int[3, 3]
{
    {4, 3, 1},
    {2, 6, 9},
    {4, 6, 2}
};

void PrintMatrix(int[,] matrixP)
{
    for (int i = 0; i < matrixP.GetLength(0); i++)
    {
        for (int j = 0; j < matrixP.GetLength(1); j++)
        {
            Console.Write(matrixP[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void ReversArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[2, i];
        array[2, i] = array[0, i];
        array[0, i] = tmp;
    }
}

PrintMatrix(array);
Console.WriteLine();
ReversArray(array);

PrintMatrix(array);



