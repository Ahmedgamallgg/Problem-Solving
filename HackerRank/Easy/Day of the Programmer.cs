namespace ProblemSolving
{
    internal class Program
    {


        public static bool IsLeapJulianCalendar(int year)
        {
            return year % 4 == 0;
        }
        public static bool IsLeapGregorianCalendar(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0);
        }

        public static string dayOfProgrammer(int year)
        {
            if (1700 <= year && year <= 1917)
            {
                if (IsLeapJulianCalendar(year))
                {
                    return $"12.09.{year}";
                }
                else
                {
                    return $"13.09.{year}";

                }
            }
            else if (year == 1918)
            {
                return $"26.09.{year}";

            }

            else
            {
                if (IsLeapGregorianCalendar(year))
                {
                    return $"12.09.{year}";
                }
                else
                {
                    return $"13.09.{year}";
                }


            }

        }




        static void Main(string[] args)
        {
            
        }
    }
}