
void FindSumInCols(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
            sum += array[i, j];
        }
        Console.Write($"Sum of elements in column {cols}: {sum}");
        Console.WriteLine();
    }
}

int[,] array =
{
    {9,8,7},
    {7,8,9},
    {4,5,6},
};
FindSumInCols(array);
