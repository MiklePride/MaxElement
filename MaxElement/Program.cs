class program
{
    static void Main(string[] args)
    {
        int[,] arrayMatrix = new int[10, 10];
        Random random = new Random();
        int minimumRandomNumber = 1;
        int maximumRandomNumber = 99;
        int stringArrayMatrix;
        int columnArrayMatrix;
        int maximumElementArrayMatrix = int.MinValue;
        int numberWriteToArrayMatrixCell = 0;

        for (columnArrayMatrix = 0; columnArrayMatrix < arrayMatrix.GetLength(0); columnArrayMatrix++)
        {
            for (stringArrayMatrix = 0; stringArrayMatrix < arrayMatrix.GetLength(1); stringArrayMatrix++)
            {
                arrayMatrix[columnArrayMatrix, stringArrayMatrix] = random.Next(minimumRandomNumber, maximumRandomNumber);
                Console.Write(arrayMatrix[columnArrayMatrix, stringArrayMatrix] + " ");

                if (maximumElementArrayMatrix < arrayMatrix[columnArrayMatrix, stringArrayMatrix])
                {
                    maximumElementArrayMatrix = arrayMatrix[columnArrayMatrix, stringArrayMatrix];
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\n Наибольший элемент в матрице массива - {maximumElementArrayMatrix}\n");

        for (columnArrayMatrix = 0; columnArrayMatrix < arrayMatrix.GetLength(0); columnArrayMatrix++)
        {
            for (stringArrayMatrix = 0; stringArrayMatrix < arrayMatrix.GetLength(1); stringArrayMatrix++)
            {
                if (maximumElementArrayMatrix == arrayMatrix[columnArrayMatrix, stringArrayMatrix])
                {
                    arrayMatrix[columnArrayMatrix, stringArrayMatrix] = numberWriteToArrayMatrixCell;
                }
                Console.Write(arrayMatrix[columnArrayMatrix, stringArrayMatrix] + " ");
            }
            Console.WriteLine();
        }
    }
}