namespace ProblemSolving
{
    internal class Program
    {

        public static int countingValleys(int steps, string path)
        {
            int level = 0;
            int countofvalley = 0;
            foreach (var step in path)
            {
                if (step == 'D')
                    level++;

                else
                    level--;

                if (step == 'U' && level == 0)
                    countofvalley++;
            }
            return countofvalley;
        }

        static void Main(string[] args)
        {
            
        }
    }
}