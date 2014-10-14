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
            int textIndex = 0;
            int patternIndex = 0;
            int asteriskIndex = -1;
            int asteriskTextIndex = 0;

            while (textIndex < text.Count())
            {
                bool isEndOfPattern = patternIndex >= pattern.Count();
                if (!isEndOfPattern && IsTextEqualPatternOrQuestionMark(text[textIndex], pattern[patternIndex]))
                {
                    textIndex++;
                    patternIndex++;
                }

                else if (!isEndOfPattern && pattern[patternIndex] == '*')
                {
                    asteriskIndex = patternIndex;
                    patternIndex += 1;
                    asteriskTextIndex = textIndex;
                }
                else if (asteriskIndex != -1) // 表示前面有出現過 *
                {
                    textIndex = ++asteriskTextIndex;
                    patternIndex = asteriskIndex + 1;
                }
                else
                {
                    return false;
                }
            }

            while (patternIndex < pattern.Count() && pattern[patternIndex] == '*')
                patternIndex++;

            return patternIndex == pattern.Count();
        }

        public static bool IsTextEqualPatternOrQuestionMark(char character, char pattern)
        {
            if (character == pattern || pattern == '?')
                return true;
            return false;
        }      
    }
}
