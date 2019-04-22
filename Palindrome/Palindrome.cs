using System;

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
      Array.Reverse(chars);
      string reverseWord = new string(chars);
      return Word == reverseWord;
    }
  }
}
