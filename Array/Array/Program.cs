using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, 2];

            int[] firstArr = new int[rows];
            int[] secondArr = new int[rows];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var splitedMatrix = Console.ReadLine().Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(splitedMatrix[col]);

                    if (row % 2 == 0)
                    {
                        firstArr[row] = matrix[row, 0];
                        secondArr[row] = matrix[row, 1];
                    }

                    else
                    {
                        firstArr[row] = matrix[row, 1];
                        secondArr[row] = matrix[row, 0];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.Write(firstArr[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < rows; j++)
            {
                Console.Write(secondArr[j] + " ");
            }
        }
    }
}
