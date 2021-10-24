using System;

namespace RabinKarp
{
    public class RKP
    {
        // If algorithm returns -1, it means that the pattern is not found in the text;
        // Otherwise, the found index is returned.
        public int RabinKarpSearch(string text, string pattern)
        {
            var hashedPattern = RollingHash(pattern);
            for (int index = 0; index < text.Length - pattern.Length + 1; index++)
            {
                var partOfText = text.Substring(index, pattern.Length);
                var hashedPartOfText = RollingHash(partOfText);
                if (hashedPartOfText == hashedPattern)
                    if (partOfText == pattern)
                        return index;
            }
            return -1;
        }

        public string RollingHash(string text)
        {
            return null;
        }
    }
}
