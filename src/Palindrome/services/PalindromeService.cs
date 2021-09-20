using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.services
{
    public interface IPalindromeService
    {
        bool CanFormPalindrome(string input);
    }
    public class PalindromeService : IPalindromeService
    {
        public bool CanFormPalindrome(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var characterDictionary = new Dictionary<char, int>();

            var characters = input.ToLower().Replace(" ", "").ToCharArray();

            for(int i = 0; i < characters.Length; i++)
            {
                var character = characters[i];

                if (characterDictionary.ContainsKey(character))
                {
                    characterDictionary[character]++;
                }else
                {
                    characterDictionary[character] = 1;
                }
            }

            var oddCharacters = characterDictionary.Count(entry => entry.Value % 2 == 1);

            // If input is even a valid palindrome cannot be formed if there are any odd characters
            // Conversely if input has an odd length there must be 1 odd character to "pivot" the palindrome around
            if(characters.Length % 2  == 0)
            {
                return oddCharacters == 0;
            }

            return oddCharacters == 1;
        }
    }
}
