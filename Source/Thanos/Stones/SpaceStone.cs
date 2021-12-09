namespace Thanos.Stones;

/// <summary>
/// Class SpaceStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class SpaceStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Blue;
}
