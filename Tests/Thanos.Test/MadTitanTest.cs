namespace Thanos.Test;

using System.IO;
using Thanos;
using Thanos.Stones;
using Xunit;

public class MadTitanTest
{
    [Fact]
    public void Snap_Without_Gauntlet()
    {
        // Arrange
        var thanos = new MadTitan();

        // Act
        var actual = thanos.Snap(location: string.Empty);

        // Assert
        Assert.False(condition: actual);
    }

    [Fact]
    public void Snap_With_Empty_Gauntlet()
    {
        // Arrange
        var infinityGauntlet = new InfinityGauntlet();
        var thanos = new MadTitan();
        thanos.Give(gauntlet: infinityGauntlet);

        // Act
        var actual = thanos.Snap(location: string.Empty);

        // Assert
        Assert.False(condition: actual);
    }

    [Fact]
    public void Snap_With_Full_Gauntlet()
    {
        // Arrange
        var infinityGauntlet = new InfinityGauntlet();
        infinityGauntlet.Add(stone: new SpaceStone());
        infinityGauntlet.Add(stone: new MindStone());
        infinityGauntlet.Add(stone: new RealityStone());
        infinityGauntlet.Add(stone: new PowerStone());
        infinityGauntlet.Add(stone: new TimeStone());
        infinityGauntlet.Add(stone: new SoulStone());

        var thanos = new MadTitan();
        thanos.Give(gauntlet: infinityGauntlet);

        // Act
        var actual = thanos.Snap(location: string.Empty);

        // Assert
        Assert.True(condition: actual);
    }

    [Fact]
    public void Snappen()
    {
        // Arrange
        var dir = Directory.CreateDirectory(path: "tmp");

        for (var i = 0; i < 10; i++)
        {
            var path = Path.Combine(path1: dir.FullName, path2: $"{i}.txt");
            File.Create(path: path).Close();
        }

        // Act
        MadTitan.Snappen(location: dir.FullName);
        var actual = Directory.GetFiles(path: dir.FullName).Length;
        dir.Delete(recursive: true);

        // Assert
        Assert.Equal(expected: 5, actual: actual);
    }
}
