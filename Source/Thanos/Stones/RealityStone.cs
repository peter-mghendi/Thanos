namespace Thanos.Stones;

/// <summary>
/// Class RealityStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class RealityStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Red;
}
