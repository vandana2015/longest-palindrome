using System;

namespace longest_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Palindrome in abcdcbpt is " + Solution("abcdcbpt"));
            Console.WriteLine("Longest Palindrome in orgeeksskeegfor is " + Solution("orgeeksskeegfor"));
            Console.ReadKey();
        }
        public static bool IsPalindrom(string str)
        {
            str = str.ToLower();
            var strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return (new string(strArray)).Equals(str);
        }
        public static string Solution(string str)
        {
            var strArr = str.ToLower().ToCharArray();
            var result = String.Empty;
            for (int i = 0; i < strArr.Length; i++)
            {
                for (int j = i + 1; j < strArr.Length; j++)
                {
                    // to be Palindrome you need more than 2 char
                    if (j != 1)
                    {
                        var subSt = str.Substring(i, j - i);
                        if (IsPalindrom(subSt) && subSt.Length > result.Length)
                        {
                            result = subSt;
                        }
                    }
                }
            }
            return result;
        }
    }
}
