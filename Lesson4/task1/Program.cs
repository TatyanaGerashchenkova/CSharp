// создать двумерный массив целых чмсел и вывести его на экран


int[,] CreateMatrix(int rowCount, int collumsCount)
{
    int[,] matrix = new int[rowCount, collumsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);