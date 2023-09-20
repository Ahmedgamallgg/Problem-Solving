namespace ProblemSolving
{
    internal class Program
    {


        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                int nextMultipleOf5 = ((grades[i] / 5) + 1) * 5;

                if (grades[i] < 38)
                {
                    roundedGrades.Add(grades[i]);
                }
                else
                {
                    if (nextMultipleOf5 - grades[i] < 3)
                    {
                        roundedGrades.Add(nextMultipleOf5);

                    }
                    else
                    {
                        roundedGrades.Add(grades[i]);

                    }
                }


            }
            return roundedGrades;

        }


        static void Main(string[] args)
        {
            
        }
    }
}