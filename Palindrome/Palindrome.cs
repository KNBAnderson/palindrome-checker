using System;
using System.Collections.Generic;

namespace Palindromes
{
  class Palindrome
  {
    public string Word;

    public Palindrome(string word) {
      Word = word;
    }

    public bool IsWordPalindrome() {
      char[] chars = Word.ToCharArray();
      List<char> reverseList = new List<char>();
      for(int i = chars.Length - 1; i >= 0; i--) {
        reverseList.Add(chars[i]);
      }
      var reverseWord = String.Join("", reverseList.ToArray());
      return Word == reverseWord;
    }
    //The easy way
    // public bool IsWordPalindrome() {
    //   char[] chars = Word.ToCharArray();
    //   Array.Reverse(chars);
    //   string reverseWord = new string(chars);
    //   return Word == reverseWord;
    // }
  }
}
