using SearchInsertPositionDomain.Models;
using Xunit;

namespace SearchInsertPositionTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void SearchInsertPosition_Should_Return_Correct_Index()
        {
            var numbers = new [] { 1, 3, 5, 6 };
            var target = 2;
            const int ExpectedResult = 1;

            var result = SuperArray.SearchInsertPosition(numbers, target);

            Assert.Equal(result, ExpectedResult);
        }
    }
}