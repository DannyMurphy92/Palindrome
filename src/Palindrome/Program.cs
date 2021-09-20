using Palindrome.services;
using System;

namespace Palindrome
{
    static class Program
    {
        static void Main(string[] args)
        {
            var palindromeSvc = new PalindromeService();

            Console.WriteLine("Welcome to your Palindrome input tester");
            Console.WriteLine("Enter in the text you wish to test, or enter \"EXIT\" to quit (its not a palindrome, I've checked)");
            var input = Console.ReadLine();
            while (input != "EXIT")
            { 
                var result = palindromeSvc.CanFormPalindrome(input);

                Console.WriteLine(result ? "TRUE" : "FALSE");
                input = Console.ReadLine();
            } 
        }
    }
}
