// ReSharper disable InconsistentNaming

using Codility._06_TapeEquilibrium;
using FluentAssertions;

namespace CodilityUnitTests._06_TapeEquilibrium;

public class TapeEquilibriumUnitTests
{
    [Fact]
    public void Solution_BasicCase1_ReturnsCorrect()
    {
        // Arrange
        int[] A = [3, 1, 2, 4, 3];

        // Act
        var result = TapeEquilibrium.Solution(A);

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Solution_BasicCase2_ReturnsCorrect()
    {
        // Arrange
        int[] A = [3, 1, 2, 4, 3];

        // Act
        var result = TapeEquilibrium.Solution(A);

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Solution_GeneralCase_ReturnsCorrect()
    {
        // Arrange
        int[] A = [3, 1, 2, 4, 3];

        // Act
        var result = TapeEquilibrium.Solution(A);

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Solution_NegativeNumbers_ReturnsCorrect()
    {
        // Arrange
        int[] A = [-10, -5, -3, -4, -1];

        // Act
        var result = TapeEquilibrium.Solution(A);

        // Assert
        result.Should().Be(3);
    }

    [Fact]
    public void Solution_LargeNumbers_ReturnsCorrect()
    {
        // Arrange
        int[] A = [1000, 10000, 100000, 1000000];

        // Act
        var result = TapeEquilibrium.Solution(A);

        // Assert
        result.Should().Be(809000);
    }
}