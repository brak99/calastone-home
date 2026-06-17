
using Xunit;
using Calastone;

namespace CalastoneTests
{
    public class TFilterTests
    {
        private readonly TFilter _filter;
        public TFilterTests()
        {
            _filter = new TFilter();
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsEmpty()
        {
            // Arrange
            string input = "";
            // Act
            var result = _filter.Filter(input);
            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsTshirt()
        {
            // Arrange
            string input = "Tshirt";
            // Act
            var result = _filter.Filter(input);
            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Filter_ShouldReturnString_WhenInputIsFree()
        {
            // Arrange
            string input = "Free";
            // Act
            var result = _filter.Filter(input);
            // Assert
            Assert.Equal("Free", result);
        }
    }
}
