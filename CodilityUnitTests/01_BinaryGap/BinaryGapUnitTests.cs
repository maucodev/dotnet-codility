namespace CodilityUnitTests._01_BinaryGap;

using Codility._01_BinaryGap;
using FluentAssertions;

public class BinaryGapUnitTests
{
    [Fact]
    public void Solution_NoBinaryGap_ReturnsZero()
    {
        // Arrange
        const int n = 32;

        // Act
        var result = BinaryGap.Solution(n);

        // Assert
        result.Should().Be(0);
    }

    [Fact]
    public void Solution_SingleBinaryGap_ReturnsCorrectLength()
    {
        // Arrange
        const int n = 1041;

        // Act
        var result = BinaryGap.Solution(n);

        // Assert
        result.Should().Be(5);
    }

    [Fact]
    public void Solution_MultipleBinaryGaps_ReturnsLongestGap()
    {
        // Arrange
        const int n = 529;

        // Act
        var result = BinaryGap.Solution(n);

        // Assert
        result.Should().Be(4);
    }

    [Fact]
    public void Solution_NoBinaryGapInMiddle_ReturnsCorrectLength()
    {
        // Arrange
        const int n = 15;

        // Act
        var result = BinaryGap.Solution(n);

        // Assert
        result.Should().Be(0);
    }

    [Fact]
    public void Solution_ZeroInput_ReturnsZero()
    {
        // Arrange
        const int n = 0;

        // Act
        var result = BinaryGap.Solution(n);

        // Assert
        result.Should().Be(0);
    }
}