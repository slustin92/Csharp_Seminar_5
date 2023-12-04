// Задача 3: Задайте прямоугольный двумерный массив.     4 3 1 => Строка с индексом 0
// Напишите программу, которая будет находить строку с   2 6 9 
// наименьшей суммой элементов.                          4 6 2



int[,] matrix = new int[3, 3]
{
    {4, 3, 1},
    {2, 6, 9},
    {4, 6, 2}
};

void PrintMatrix(int[,] matrixFor)
{
    for (int i = 0; i < matrixFor.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrixFor[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

PrintMatrix(matrix);

int minSum = 0;
int sum = SumLine(matrix, 0);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
    }
}

Console.WriteLine($"\nСтрока c наименьшей суммой элементов: { minSum}");
