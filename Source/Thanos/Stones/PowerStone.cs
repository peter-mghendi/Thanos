namespace Thanos.Stones;

/// <summary>
/// Class PowerStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class PowerStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Purple;
}
