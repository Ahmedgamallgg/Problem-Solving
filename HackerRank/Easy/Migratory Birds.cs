namespace ProblemSolving
{
    internal class Program
    {

        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int birdtype in arr)
            {
                if (frequency.ContainsKey(birdtype))
                {
                    frequency[birdtype] += 1;
                }
                else
                {
                    frequency[birdtype] = 1;
                }
            }
            int maxFrequency = frequency.Max(pair => pair.Value);


            List<int> mostFrequentBirds = frequency.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToList();


            int lowestType = mostFrequentBirds.Min();

            return lowestType;
        }


        static void Main(string[] args)
        {
            
        }
    }
}