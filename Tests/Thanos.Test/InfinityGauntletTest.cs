namespace Thanos.Test;

using Thanos;
using Thanos.Stones;
using Xunit;

public class InfinityGauntletTest
{
    [Fact]
    public void Add_Stone()
    {
        // Arrange
        var gauntlet = new InfinityGauntlet();
        var count = gauntlet.Stones.Count;

        gauntlet.Add(new SpaceStone());
        var expected = ++count;

        // Act
        var actual = gauntlet.Stones.Count;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Add_Duplicate_Stone()
    {
        // Arrange
        var gauntlet = new InfinityGauntlet();

        gauntlet.Add(new SpaceStone());
        gauntlet.Add(new SpaceStone());

        // Act
        var actual = gauntlet.Stones.Count;

        // Assert
        Assert.Equal(1, actual);
    }
}
