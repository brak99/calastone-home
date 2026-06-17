
using Xunit;
using Calastone;

namespace CalastoneTests
{
    public class VowelFilterTests
    {
        private readonly VowelFilter _vowelFilter;
        public VowelFilterTests()
        {
            _vowelFilter = new VowelFilter();
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsEmpty()
        {
            // Arrange
            string input = "";
            // Act
            var result = _vowelFilter.Filter(input);
            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsCurrently()
        {
            // Arrange
            string input = "currently";
            // Act
            var result = _vowelFilter.Filter(input);
            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsThe()
        {
            // Arrange
            string input = "the";
            // Act
            var result = _vowelFilter.Filter(input);
            // Assert
            Assert.Equal("the", result);
        }

        [Fact]
        public void Filter_ShouldReturnEmptyString_WhenInputIsRather()
        {
            // Arrange
            string input = "rather";
            // Act
            var result = _vowelFilter.Filter(input);
            // Assert
            Assert.Equal("rather", result);
        }
    }
}
