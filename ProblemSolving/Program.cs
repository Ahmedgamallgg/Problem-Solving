namespace ProblemSolving
{
    internal class Program
    {
        public static void matrixRotation(List<List<int>> matrix, int r)
        {
            int NumRows = matrix.Count;
            int NumCols = matrix[0].Count;

            int NumLayers = Math.Min(NumRows, NumCols) / 2;

            for (int layer = 0; layer < NumLayers; layer++)
            {
                int RotationCount = r % (2 * (NumRows + NumCols - 4 * layer) - 4);

                for (int rotation = 0; rotation < RotationCount; rotation++)
                {

                    int temp = matrix[layer][layer];


                    for (int i = layer; i < NumCols - layer - 1; i++)
                    {
                        matrix[layer][i] = matrix[layer][i + 1];
                    }


                    for (int i = layer; i < NumRows - layer - 1; i++)
                    {
                        matrix[i][NumCols - layer - 1] = matrix[i + 1][NumCols - layer - 1];
                    }


                    for (int i = NumCols - layer - 1; i > layer; i--)
                    {
                        matrix[NumRows - layer - 1][i] = matrix[NumRows - layer - 1][i - 1];
                    }


                    for (int i = NumRows - layer - 1; i > layer; i--)
                    {
                        matrix[i][layer] = matrix[i - 1][layer];
                    }


                    matrix[layer + 1][layer] = temp;
                }
            }


            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}