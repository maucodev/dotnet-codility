namespace CodilityUnitTests._04_FrogJmp;

using Codility._04_FrogJmp;
using FluentAssertions;

public class FrogJmpUnitTests
{
    [Fact]
    public void Solution_SimpleCase_ReturnsCorrectJumps()
    {
        // Arrange
        const int x = 10;
        const int y = 85;
        const int d = 30;

        // Act
        var result = FrogJmp.Solution(x, y, d);

        // Assert
        result.Should().Be(3);
    }

    [Fact]
    public void Solution_ExactJumps_ReturnsCorrectJumps()
    {
        // Arrange
        const int x = 10;
        const int y = 70;
        const int d = 30;

        // Act
        var result = FrogJmp.Solution(x, y, d);

        // Assert
        result.Should().Be(2);
    }

    [Fact]
    public void Solution_NoJumpsNeeded_ReturnsZero()
    {
        // Arrange
        const int x = 10;
        const int y = 10;
        const int d = 30;

        // Act
        var result = FrogJmp.Solution(x, y, d);

        // Assert
        result.Should().Be(0);
    }

    [Fact]
    public void Solution_MinimalCase_ReturnsCorrectJumps()
    {
        // Arrange
        const int x = 1;
        const int y = 1_000_000_000;
        const int d = 1;

        // Act
        var result = FrogJmp.Solution(x, y, d);

        // Assert
        result.Should().Be(999_999_999);
    }

    [Fact]
    public void Solution_LargeJumpDistance_ReturnsCorrectJumps()
    {
        // Arrange
        const int x = 1;
        const int y = 1_000_000_000;
        const int d = 1_000_000_000;

        // Act
        var result = FrogJmp.Solution(x, y, d);

        // Assert
        result.Should().Be(1);
    }
}