using System;
using System.Linq;

namespace TextUtils
{
    public static class WordCount
    {
        public static int GetWordCount(string searchWord, string inputString) 
        {
            // Null check these variables and dertermine if they have values
            if (String.IsNullOrEmpty(searchWord) || String.IsNullOrEmpty(inputString)) 
            {
                return 0;
            }

            // Convert the string into an array of words
            var source = inputString.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Create the query. Use ToLowerInvariant to match uppercase/lowercase strings.   
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchWord.ToLowerInvariant()
                             select word;

            // Count the matches, which executes the query. Return the reuslt.
            return matchQuery.Count();
        }
    }
}
