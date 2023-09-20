namespace ProblemSolving
{
    internal class Program
    {


        public static int birthday(List<int> s, int d, int m)
        {
            int ways = 0;
            int n = s.Count;
            for (int i = 0; i <= n - m; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
                {
                    ways++;
                }
            }

            return ways;

        }



        static void Main(string[] args)
        {
            
        }
    }
}