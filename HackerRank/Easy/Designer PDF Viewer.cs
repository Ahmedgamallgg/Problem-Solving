namespace ProblemSolving
{
    internal class Program
    {

        public static int FindIndex(char letter)
        {
            char[] Allletter = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                              'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 
                                              'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < Allletter.Length; i++)
            {
                if (Allletter[i] == letter)
                    return i;
            }

            return -1;
        }

        public static int designerPdfViewer(List<int> h, string word)
        {
            char[] letters = word.ToCharArray();
            int area = 1;
            foreach (var letter in letters)
            {
                if (h[FindIndex(letter)] > area)
                    area = h[FindIndex(letter)];
            }
            return area * letters.Length;

        }

        static void Main(string[] args)
        {
            
        }
    }
}