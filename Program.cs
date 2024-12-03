namespace Assignment_5._2._1
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int length = 0;
            bool isCounting = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                    isCounting = true;
                }
                else if (isCounting)
                {
                    break;
                }
            }

            return length;
        }
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            Console.WriteLine(LengthOfLastWord(s1));

            // Example 2
            string s2 = "   fly me   to   the moon  ";
            Console.WriteLine(LengthOfLastWord(s2));

            // Example 3
            string s3 = "a";
            Console.WriteLine(LengthOfLastWord(s3));
        }
    }
}

