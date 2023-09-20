namespace ProblemSolving
{
    internal class Program
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger factorial = 1;
            for (int i = 0; i < n; i++)
            {
                factorial *= n - i;
            }
            Console.WriteLine(factorial);

        }

        static void Main(string[] args)
        {
            
        }
    }
}