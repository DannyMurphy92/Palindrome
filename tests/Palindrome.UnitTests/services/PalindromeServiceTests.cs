using Palindrome.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Palindrome.UnitTests.services
{
    public class PalindromeServiceTests
    {
        [Theory]
        [InlineData("racecar")]
        [InlineData("carrace")]
        public void GivenAPalindromableStringWithNoWhitespace_CorrectlyIdentifiesAsPalindrome(string input)
        {
            var sut = new PalindromeService();

            Assert.True(sut.CanFormPalindrome(input));
        }
    }
}
