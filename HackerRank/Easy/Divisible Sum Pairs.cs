namespace ProblemSolving
{
    internal class Program
    {


        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int divisible = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        divisible += 1;
                    }
                }
            }
            return divisible;

        }



        static void Main(string[] args)
        {
            
        }
    }
}