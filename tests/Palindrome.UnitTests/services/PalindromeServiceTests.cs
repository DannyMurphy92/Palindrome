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
        [InlineData("caRraCe")]
        [InlineData(".mama..")]
        public void GivenAPalindromableStringWithNoWhitespace_CorrectlyIdentifiesAsPalindrome(string input)
        {
            var sut = new PalindromeService();

            Assert.True(sut.CanFormPalindrome(input));
        }

        [Theory]
        [InlineData(" carrace ")]
        [InlineData(" caRraCe")]
        public void GivenAPalindromableStringWithWhitespace_CorrectlyIdentifiesAsPalindromeIgnoringWhitespace(string input)
        {
            var sut = new PalindromeService();

            Assert.True(sut.CanFormPalindrome(input));
        }

        [Theory]
        [InlineData("palindrome")]
        [InlineData("dromepal")]
        public void GivenANonPalindromableString_CorrectlyIdentifiesAsNotPalindromable(string input)
        {
            var sut = new PalindromeService();

            Assert.False(sut.CanFormPalindrome(input));
        }
    }
}
