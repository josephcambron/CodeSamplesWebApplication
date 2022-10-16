using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamplesWebApplication;
using Xunit;


namespace CodeSamples.Testing
{
    public class AddTwoIntsInArrayTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void AddTwoIntsInArrayTests_ShouldReturnTrue(int[] nums, int target, int[] expected)
        {
            //Arrange
            AddTwoIntsInArray addTwoIntsInArray = new AddTwoIntsInArray();
            //Act
            int[] result = addTwoIntsInArray.TwoSum(nums, target);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
