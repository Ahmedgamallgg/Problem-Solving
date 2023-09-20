namespace ProblemSolving
{
    internal class Program
    {

        public static bool IsSummer(int num)
        {
            return num % 2 == 0;
        }


        public static int utopianTree(int n)
        {
            int heightOfTree = 0;
            for (int i = 0; i <= n; i++)
            {
                if (IsSummer(i))
                    heightOfTree += 1;

                else
                    heightOfTree *= 2;

            }
            return heightOfTree;

        }

        static void Main(string[] args)
        {
            
        }
    }
}