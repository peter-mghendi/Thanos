namespace Thanos.Stones;

/// <summary>
/// Class TimeStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class TimeStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Green;
}
