namespace ProblemSolving
{
    internal class Program
    {

        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> pairs = new();

            foreach (int sock in ar)
            {
                if (pairs.ContainsKey(sock))
                    pairs[sock]++;
                else
                    pairs[sock] = 1;
            }
            int count = 0;
            foreach (var pair in pairs)
            {
                count += pair.Value / 2;
            }

            return count;

        }



        static void Main(string[] args)
        {
            
        }
    }
}