namespace ProblemSolving
{
    internal class Program
    {
        static string catAndMouse(int x, int y, int z)
        {

            if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return "Cat B ";
            }
            else if (Math.Abs(x - z) < Math.Abs(y - z))
            {
                return "Cat A ";
            }
            else
            {
                return "Mouse C ";

            }


        }

        static void Main(string[] args)
        {
           
        }
    }
}