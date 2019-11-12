using System;
using System.Collections.Generic;




namespace Palindrome.Domain.Models
{

  class Palindrome
  {

    public static bool IsPalindrome(string word)
    {
        int minLength = 0;
        int maxLength = word.Length - 1;
        while (true)
        {
            if (minLength > maxLength)
            {
                return true;
            }
            char a = minlength(word);
            char b = maxLength(word);
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            minLength++;
            maxLength--;
        }
    }
 
    static bool IsPalindrome(string);
    {
        string palindromeWord = {"civic"};
 
            if (IsPalindrome(word))
            {
                Console.WriteLine(word + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(word + " is not a Palindrome");
            }
        }
        Console.ReadKey();
    }

  }//ends class


}//ends namespace

    

