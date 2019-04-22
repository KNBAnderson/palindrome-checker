using System;
using System.Collections.Generic;

namespace Palindromes {
  public class Program
  {
    public static void Main() {
      Console.WriteLine("Please enter a word: ");
      string word = Console.ReadLine();
      Palindrome palindrome = new Palindrome(word);

      if(palindrome.IsWordPalindrome())
      {
        Console.WriteLine( word + " is a palindrome");
      }
      else
      {
        Console.WriteLine( word + " is not a palindrome");
      }
    }
  }
}
