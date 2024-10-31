
void FindMaxInRows(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        int max = array[i,0];
        for (int j = 0; j < col; j++)
        {
            if (array[i,j] > max)
            {
                max = array[i,j];
            }
        }
        Console.Write($"Max element in row{i}: {max}");
        Console.WriteLine();
    }
}


int[,] array = {
    {1,2,3,4},
    {5,6,7,4},
    {4,5,3,5},
};

FindMaxInRows(array);