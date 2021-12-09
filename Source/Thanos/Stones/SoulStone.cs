namespace Thanos.Stones;

/// <summary>
/// Class SoulStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class SoulStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Orange;
}
