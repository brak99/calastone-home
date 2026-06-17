
using Xunit;
using Calastone;

namespace CalastoneTests
{
    public class ShortFilterTests
    {
        private readonly ShortFilter _filter;
        public ShortFilterTests()
        {
            _filter = new ShortFilter();
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
        public void Filter_ShouldReturnEmptyString_WhenInputIsAs()
        {
            // Arrange
            string input = "as";
            // Act
            var result = _filter.Filter(input);
            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Filter_ShouldReturnString_WhenInputIsRather()
        {
            // Arrange
            string input = "Two";
            // Act
            var result = _filter.Filter(input);
            // Assert
            Assert.Equal("Two", result);
        }
    }
}
