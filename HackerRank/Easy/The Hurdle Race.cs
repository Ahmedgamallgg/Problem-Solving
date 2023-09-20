namespace ProblemSolving
{
    internal class Program
    {

        public static int hurdleRace(int k, List<int> height)
        {
            if (k >= height.Max())
            {
                return 0;

            }
            else
                return height.Max() - k;

        }

        static void Main(string[] args)
        {
            
        }
    }
}