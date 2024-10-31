
void ColsToRows(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] trans = new int[cols,rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            trans[j,i] = array[i,j];
        }
    }
    Console.Write("Transpose matrix:");
    Console.WriteLine(" ");
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write(trans[i,j] + " ");
            Console.Write(" ");
        }
        Console.Write(" ");
    }
}

int[,] array =
{
    {1,2,3},
    {4,5,6},
    {7,8,9},
};

ColsToRows(array);