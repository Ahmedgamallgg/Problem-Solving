namespace ProblemSolving
{
    internal class Program
    {

        public static int pickingNumbers(List<int> a)
        {

            int MaxLength = 0;

            foreach (int num in a)
            {
                int CountNum = a.Count(x => x == num);
                int CountNextNum = a.Count(x => x == num + 1);
                int CurrentLength = CountNum + CountNextNum;

                if (CurrentLength > MaxLength)
                {
                    MaxLength = CurrentLength;
                }
            }

            return MaxLength;

        }

        static void Main(string[] args)
        {
            
        }
    }
}