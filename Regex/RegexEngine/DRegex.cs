using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexEngine
{
    public class DRegex
    {
        public static bool IsMatch(string target, string pattern)
        {
            return true;
        }

        public static bool IsMatch(string target, string pattern, DRegexOptions options)
        {
            return true;
        }
    }

    public enum DRegexOptions
    {
        None,
        IgnoreCase
    }
}
