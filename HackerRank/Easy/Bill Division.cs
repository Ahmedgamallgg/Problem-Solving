namespace ProblemSolving
{
    internal class Program
    {

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int WhatAnnaShouldPay = (bill.Sum() - bill[k]) / 2;

            if (b == WhatAnnaShouldPay)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - WhatAnnaShouldPay);
            }

        }

        static void Main(string[] args)
        {
            
        }
    }
}