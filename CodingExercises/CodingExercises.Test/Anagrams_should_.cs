using Xunit;

namespace CodingExercises.Test
{
    public class Anagrams_should_
    {
        [Fact]
        public void indicate_when_two_words_are_anagrams_of_each_other()
        {
            var word1 = "rat";
            var word2 = "tar";

            var anagramsApp = new Anagrams();

            var wordsAreAnagrams = anagramsApp.DetermineIfWordsAreAnagrams(word1, word2);

            Assert.True(wordsAreAnagrams);
        }

        [Fact]
        public void indicate_two_words_are_not_anagrams_if_they_are_not_of_equal_length()
        {
            var word1 = "rat";
            var word2 = "ta";

            var anagramsApp = new Anagrams();

            var wordsAreAnagrams = anagramsApp.DetermineIfWordsAreAnagrams(word1, word2);

            Assert.False(wordsAreAnagrams);
        }

        [Fact]
        public void indicate_two_words_are_not_anagrams_if_one_is_null()
        {
            var anagramsApp = new Anagrams();

            var wordsAreAnagrams = anagramsApp.DetermineIfWordsAreAnagrams("rat", null);

            Assert.False(wordsAreAnagrams);
        }

        [Fact]
        public void indicate_two_words_are_not_anagrams_if_one_is_empty()
        {
            var anagramsApp = new Anagrams();

            var wordsAreAnagrams = anagramsApp.DetermineIfWordsAreAnagrams("rat", "");

            Assert.False(wordsAreAnagrams);
        }
    }
}

// rat and tar, god and dog
// Given two strings that are anagrams of each other,
// When the Anagrams class compares the strings
// Then it returns true

// Given two strings that are NOT anagrams of each other,
// When the Anagrams class compares the strings
// Then it returns false