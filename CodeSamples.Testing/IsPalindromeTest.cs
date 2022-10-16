using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamplesWebApplication;
using Xunit;

namespace CodeSamples.Testing
{
    public class IsPalindromeTest
    {
        [Theory]
        [InlineData(121)]
        [InlineData(12321)]
        [InlineData(123321)]
        public void IsPalindromeTest_ShouldReturnTrue(int x)
        {
            //Arrange
            PalindromeBool isPalindrome = new PalindromeBool();
            //Act
            bool result = isPalindrome.IsPalindromeBool(x);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(123)]
        [InlineData(1234)]
        [InlineData(12345)]
        public void IsPalindromeTest_ShouldReturnFalse(int x)
        {
            //Arrange
            PalindromeBool isPalindrome = new PalindromeBool();
            //Act
            bool result = isPalindrome.IsPalindromeBool(x);
            //Assert
            Assert.False(result);
        }

    }
}
