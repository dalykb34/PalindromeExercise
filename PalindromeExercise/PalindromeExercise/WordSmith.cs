using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            ////reverse the word
            //var reversed = "";
            //for(int i = word.Length - 1; i >= 0; i--)
            //{
            //    reversed += word[i];
            //}
            ////compare
            //if (reversed.ToLower() == word.ToLower())
            //{
            //    return true;
            //}
            //return false;
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}
