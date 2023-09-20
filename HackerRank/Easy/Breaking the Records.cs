namespace ProblemSolving
{
    internal class Program
    {


        public static List<int> breakingRecords(List<int> scores)
        {
            int breakmax = scores[0];
            int breakcountmax = 0;
            int breakmin = scores[0];
            int breakcountmin = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (breakmax < scores[i])
                {
                    breakmax = scores[i];
                    breakcountmax += 1;
                }

                if (breakmin > scores[i])
                {
                    breakmin = scores[i];
                    breakcountmin += 1;
                }
            }
            return new List<int> { breakcountmax, breakcountmin };


        }



        static void Main(string[] args)
        {
            
        }
    }
}