namespace ProblemSolving
{
    internal class Program
    {

        public static int pageCount(int n, int p)
        {
            int turnfromfront = p / 2;
            int turnfromback = (n / 2) - (p / 2);

            return Math.Min(turnfromfront, turnfromback);

        }


        static void Main(string[] args)
        {
            
        }
    }
}