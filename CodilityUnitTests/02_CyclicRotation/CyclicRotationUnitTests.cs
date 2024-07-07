// ReSharper disable InconsistentNaming

namespace CodilityUnitTests._02_CyclicRotation;

using Codility._02_CyclicRotation;
using FluentAssertions;

public class CyclicRotationUnitTests
{
    [Fact]
    public void Solution_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        const int K = 3;
        var A = new int[] { };
        var expected = new int[] { };

        // Act
        var result = CyclicRotation.Solution(A, K);

        // Assert
        result.Should().Equal(expected);
    }

    [Fact]
    public void Solution_KEqualsZero_ReturnsSameArray()
    {
        // Arrange
        const int K = 0;
        var A = new int[] { 3, 8, 9, 7, 6 };
        var expected = new int[] { 3, 8, 9, 7, 6 };

        // Act
        var result = CyclicRotation.Solution(A, K);

        // Assert
        result.Should().Equal(expected);
    }

    [Fact]
    public void Solution_KEqualsLength_ReturnsSameArray()
    {
        // Arrange
        const int K = 5;
        var A = new int[] { 3, 8, 9, 7, 6 };
        var expected = new int[] { 3, 8, 9, 7, 6 };

        // Act
        var result = CyclicRotation.Solution(A, K);

        // Assert
        result.Should().Equal(expected);
    }

    [Fact]
    public void Solution_SingleRotation_ReturnsExpectedArray()
    {
        // Arrange
        const int K = 1;
        var A = new int[] { 3, 8, 9, 7, 6 };
        var expected = new int[] { 6, 3, 8, 9, 7 };

        // Act
        var result = CyclicRotation.Solution(A, K);

        // Assert
        result.Should().Equal(expected);
    }

    [Fact]
    public void Solution_MultipleRotations_ReturnsExpectedArray()
    {
        // Arrange
        const int K = 3;
        var A = new int[] { 3, 8, 9, 7, 6 };
        var expected = new int[] { 9, 7, 6, 3, 8 };

        // Act
        var result = CyclicRotation.Solution(A, K);

        // Assert
        result.Should().Equal(expected);
    }
}