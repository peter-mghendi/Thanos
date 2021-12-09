namespace Thanos.Stones;

/// <summary>
/// Represents an Infinity Stone.
/// </summary>
public abstract partial record InfinityStone
{
    /// <summary>
    /// Gets the name of this infinity stone.
    /// </summary>
    public string Name => this.Color switch
    {
        StoneColor.Blue => "Space Stone",
        StoneColor.Yellow => "Mind Stone",
        StoneColor.Red => "Reality Stone",
        StoneColor.Purple => "Power Stone",
        StoneColor.Green => "Time Stone",
        StoneColor.Orange => "Soul Stone",
        _ => throw new ArgumentException("Invalid Infinity Stone Color.", nameof(this.Color)),
    };

    /// <summary>
    /// Gets the <see cref="StoneColor"/> of this infinity stone.
    /// </summary>
    public abstract StoneColor Color { get; }
}
