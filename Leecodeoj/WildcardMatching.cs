//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/wildcard-matching/</reference>
//----------------------------------------------------------------------
using System.Linq;

namespace Leecodeoj
{
    /// <summary>
    /// Implement wildcard pattern matching with support for '?' and '*'
    /// </summary>
    public class WildcardMatching
    {
        public static bool IsMatch(string text, string pattern)
        {
            char[] textArray = text.ToArray();
            char[] patternArray = pattern.ToArray();
            int textIndex = 0;
            int patternIndex = 0;
            int startIndex = -1;
            int ss = 0;

            while(textIndex < textArray.Length)
            {
                bool isNotPatternEnd = patternIndex < patternArray.Length;

                if (isNotPatternEnd && (patternArray[patternIndex] == '?' || textArray[textIndex] == patternArray[patternIndex]))
                {
                    textIndex++;
                    patternIndex++;
                    continue;
                }

                if (isNotPatternEnd && patternArray[patternIndex] == '*')
                {
                    startIndex = patternIndex++;
                    ss = textIndex;
                    continue;
                }

                if (startIndex != -1)
                {
                    textIndex = ++ss;
                    patternIndex = startIndex + 1;
                    continue;
                }
                return false;
            }

            while (patternIndex < patternArray.Length && patternArray[patternIndex]=='*')
                patternIndex++;

            return patternIndex == patternArray.Length;
        }
    }
}
