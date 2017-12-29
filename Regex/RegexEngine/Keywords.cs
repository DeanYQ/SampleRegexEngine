using System.Collections.Generic;

namespace RegexEngine
{
    public class Keywords
    {
        private static List<char> Quantifiers = new List<char>() { '?', '*', '+' };

        public static bool IsQuantifier(char c)
        {
            return Quantifiers.Contains(c);
        }

        //public static bool IsCharArray(char c)
        //{
        //
        //}
    }
}
