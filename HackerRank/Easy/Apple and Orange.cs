namespace ProblemSolving
{
    internal class Program
    {

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesinthehouse = 0, orangeinthehouse = 0;
            //apples
            for (int i = 0; i < apples.Count; i++)
            {
                apples[i] += a;
                if (apples[i] >= s && apples[i] <= t)
                {
                    applesinthehouse += 1;

                }

            }

            for (int i = 0; i < oranges.Count; i++)
            {
                oranges[i] += b;
                if (oranges[i] <= t && oranges[i] >= s)
                {
                    orangeinthehouse += 1;

                }

            }
            Console.WriteLine(applesinthehouse);
            Console.WriteLine(orangeinthehouse);


        }


        static void Main(string[] args)
        {
            
        }
    }
}