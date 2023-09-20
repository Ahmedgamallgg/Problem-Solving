namespace ProblemSolving
{
    internal class Program
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            ranked = ranked.Distinct().OrderByDescending(x => x).ToList();

            int rankPointer = ranked.Count - 1;

            foreach (int score in player)
            {

                while (rankPointer >= 0 && ranked[rankPointer] <= score)
                {
                    rankPointer--;
                }

                int playerRank = rankPointer + 2;
                result.Add(playerRank);
            }

            return result;
        }

        static void Main(string[] args)
        {
            
        }
    }
}