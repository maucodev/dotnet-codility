// ReSharper disable InconsistentNaming

namespace CodilityUnitTests._05_PermMissingElem;

using Codility._05_PermMissingElem;
using FluentAssertions;
using System.Linq;

public class PermMissingElemUnitTests
{
    [Fact]
    public void Solution_MissingElementInMiddle_ReturnsMissingElement()
    {
        // Arrange
        int[] A = [2, 3, 1, 5];

        // Act
        var result = PermMissingElem.Solution(A);

        // Assert
        result.Should().Be(4);
    }

    [Fact]
    public void Solution_SingleElementMissing_ReturnsMissingElement()
    {
        // Arrange
        int[] A = [2];

        // Act
        var result = PermMissingElem.Solution(A);

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Solution_NoElementMissing_ReturnsNextElement()
    {
        // Arrange
        int[] A = [1, 2, 3, 4, 5, 6, 7, 8];

        // Act
        var result = PermMissingElem.Solution(A);

        // Assert
        result.Should().Be(9);
    }

    [Fact]
    public void Solution_EmptyArray_ReturnsMissingElement()
    {
        // Arrange
        int[] A = [];

        // Act
        var result = PermMissingElem.Solution(A);

        // Assert
        result.Should().Be(1);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(50_000)]
    [InlineData(100_000)]
    public void Solution_LargeInput_ReturnsMissingElement(int randomValueMissing)
    {
        // Arrange
        var A = Enumerable.Range(1, 100_000).ToList();

        A.RemoveAt(randomValueMissing - 1);

        // Act
        var result = PermMissingElem.Solution([.. A]);

        // Assert
        result.Should().Be(randomValueMissing);
    }
}