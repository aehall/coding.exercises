using System;

namespace CodingExercises
{
    public class Anagrams
    {
        public bool DetermineIfWordsAreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                return false;
            }

            if (word1.Length != word2.Length)
            {
                return false;
            }

            var word1AsCharArray = word1.ToCharArray();
            var word2AsCharArray = word2.ToCharArray();

            Array.Sort(word1AsCharArray);
            Array.Sort(word2AsCharArray);

            for (var i = 0; i < word1AsCharArray.Length; i++)
            {
                if (word1AsCharArray[i] != word2AsCharArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
