namespace ProblemSolving
{
    internal class Program
    {

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2)
            {
                return "NO";
            }
            int relativeStartPosition = x1 - x2;
            int relativeJumpDistance = v1 - v2;
            if (relativeStartPosition % relativeJumpDistance == 0 && relativeJumpDistance > 0)
            {
                return "YES";

            }
            else
            {
                return "NO";
            }

        }

        static void Main(string[] args)
        {
            
        }
    }
}