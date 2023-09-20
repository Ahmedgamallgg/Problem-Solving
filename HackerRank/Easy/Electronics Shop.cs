namespace ProblemSolving
{
    internal class Program
    {

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            int maxprice = -1;
            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    if (keyboard + drive > maxprice && keyboard + drive <= b)
                        maxprice = keyboard + drive;
                }
            }
            return maxprice;


        }


        static void Main(string[] args)
        {
            
        }
    }
}