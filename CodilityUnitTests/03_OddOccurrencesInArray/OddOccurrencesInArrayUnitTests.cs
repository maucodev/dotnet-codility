namespace CodilityUnitTests._03_OddOccurrencesInArray;

using Codility._03_OddOccurrencesInArray;
using FluentAssertions;

public class OddOccurrencesInArrayUnitTests
{
    [Fact]
    public void Solution_SingleElement_ReturnsElement()
    {
        // Arrange
        var array = new[] { 1 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Solution_TwoElementsOneUnpaired_ReturnsUnpaired()
    {
        // Arrange
        var array = new[] { 1, 2, 1 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(2);
    }

    [Fact]
    public void Solution_LargeInput_ReturnsCorrectUnpairedElement()
    {
        // Arrange
        var array = new[] { 9, 3, 9, 3, 9, 7, 9 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(7);
    }

    [Fact]
    public void Solution_AllElementsPaired_ReturnsZero()
    {
        // Arrange
        var array = new[] { 4, 4, 2, 2 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(0);
    }

    [Fact]
    public void Solution_UnpairedElementAtStart_ReturnsUnpairedElement()
    {
        // Arrange
        var array = new[] { 5, 1, 1 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(5);
    }

    [Fact]
    public void Solution_UnpairedElementAtEnd_ReturnsUnpairedElement()
    {
        // Arrange
        var array = new[] { 1, 1, 6 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(6);
    }

    [Fact]
    public void Solution_MultipleUnpairedElements_ReturnsLastUnpairedElement()
    {
        // Arrange
        var array = new[] { 2, 2, 3, 3, 4 };

        // Act
        var result = OddOccurrencesInArray.Solution(array);

        // Assert
        result.Should().Be(4);
    }
}